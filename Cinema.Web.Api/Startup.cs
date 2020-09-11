using AutoMapper;
using Cinema.Dal.Data;
using Cinema.Dal.Repository;
using Cinema.Domain.Entities;
using Cinema.Domain.Entities.Identity;
using Cinema.EmailService;
using Cinema.Models.Dtos;
using Cinema.Models.Requests;
using Cinema.Models.Requests.Pricing;
using Cinema.Models.Requests.Screenings;
using Cinema.Models.Requests.Users;
using Cinema.MovieRecommenderService;
using Cinema.Services;
using Cinema.Utilities.Interfaces;
using Cinema.Utilities.Interfaces.Dal;
using Cinema.Utilities.Interfaces.Integrations;
using Cinema.Utilities.Interfaces.Services;
using Cinema.Web.Api.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.ML;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace Cinema.Web.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPredictionEnginePool<Cinema.MovieRecommenderService.Models.MovieRating, Cinema.MovieRecommenderService.Models.MovieRatingPrediction>()
                .FromFile(modelName: "MovieRatingAnalysisModel", filePath: "MLModels/MovieRecommenderModel.zip", watchForChanges: true);

            services.AddControllers(x => x.Filters.Add<ErrorFilter>()).AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddRouting(options => options.LowercaseUrls = true);

            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Cinema API", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef\"",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                            {
                                Reference = new OpenApiReference
                                {
                                    Type = ReferenceType.SecurityScheme,
                                    Id = "Bearer"
                                }
                            },
                            new string[] {}

                    }
                });
            });

            services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])) //Configuration["JwtToken:SecretKey"]  
                };
            });

            services.AddHttpContextAccessor();

            var emailConfig = Configuration.GetSection("EmailConfiguration")
                                           .Get<EmailConfiguration>();

            services.AddSingleton(emailConfig);

            services.Configure<FormOptions>(o =>
            {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICinemaDbContext, CinemaDbContext>();

            services.AddScoped<IService<NewsTypeDto, BaseSearchRequest>, BaseService<NewsTypeDto, BaseSearchRequest, NewsType>>();
            services.AddScoped<IService<EventTypeDto, BaseSearchRequest>, BaseService<EventTypeDto, BaseSearchRequest, EventType>>();
            services.AddScoped<IService<ApplicationRoleDto, BaseSearchRequest>, BaseService<ApplicationRoleDto, BaseSearchRequest, ApplicationRole>>();
            services.AddScoped<IService<GenreDto, BaseSearchRequest>, BaseService<GenreDto, BaseSearchRequest, Genre>>();
            services.AddScoped<IService<HallDto, BaseSearchRequest>, BaseService<HallDto, BaseSearchRequest, Hall>>();
            services.AddScoped<ICRUDService<PricingDto, PricingSearchRequest, PricingUpsertRequest, PricingUpsertRequest>, PricingService>();
            services.AddScoped<ICRUDService<ApplicationUserDto, UserSearchRequest, UserInsertRequest, UserUpdateRequest>, UserService>();
            services.AddScoped<ICRUDService<ScreeningDto, ScreeningSearchRequest, ScreeningUpsertRequest, ScreeningUpsertRequest>, ScreeningService>();

            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IScreeningService, ScreeningService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IReservationService, ReservationService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IQRCodeService, QRCodeService>();
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IMovieRecommender, MovieRecommender>();
            services.AddScoped<INewsService, NewsService>();
            services.AddScoped<IEventService, EventService>();

            services.AddScoped<IMovieRepository, MovieRepository>();
            services.AddScoped<IReviewRepository, ReviewRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IInvoiceRepository, InvoiceRepository>();
            services.AddScoped<IReservationRepository, ReservationRepository>();
            services.AddScoped<ISeatReservationRepository, SeatReservationRepository>();

            services.AddScoped<IRepository<ApplicationUser, int>, UserRepository>();
            services.AddScoped<IRepository<Movie, int>, MovieRepository>();
            services.AddScoped<IRepository<Reservation, int>, ReservationRepository>();
            services.AddScoped<IRepository<SeatReservation, int>, SeatReservationRepository>();
            services.AddScoped<IRepository<Invoice, int>, InvoiceRepository>();

            string connection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<CinemaDbContext>(options => options.UseSqlServer(connection));

            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                //options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<CinemaDbContext>().AddDefaultTokenProviders();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cinema API V1");
            });
        }
    }
}
