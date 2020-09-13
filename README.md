# Introduction 
Cinema is a bundle of the following applications:
#### Cinema back-end REST API (ASP.NET Core 3.1)
Technical implementations of Cinema.Web.Api:
- SQL Server database
- Repository pattern with Unit of Work
- Service layer
- ML .NET based movie recommender system
- Email service
- Automapper
- JWT Authorization with Bearer scheme
#### Cinema Desktop Client (Windows Forms)
- Movies, screenings, pricing, employees, reservations and content management
- Sales and screenings dashboard overview
- Yearly sales report
- Screening capacities report
- Print to Excel/PDF/Printer feature
#### Cinema Mobile (Xamarin)
- Customer registration and profile edit
- Now showing movies
- Recommended movies
- Screening reservations with seat overview and seat picker
- Sending reservation code to email feature
- "My reservations" overview with reservation cancelation
- News and events overview

# Getting Started
1.	Clone/Download project
2.	Enter EmailConfiguration data in appsettings.json of Cinema.Web.Api (If data is already present, proceed to next step)
3.  Set Cinema.WinUI and Cinema.Mobile.UWP as solution Startup projects
4.  Start Docker Desktop
5. 	Open console, open "cinema" root folder in console
6.  Run "docker-compose build"
6.  Run "docker-compose up"
7. 	After a console message that the application has started appears, open http://localhost:5000/swagger/index.html in browser
**NOTE: docker-compose build may take a few minutes, due to the number of Reviews being seeded (required for the MovieRecommenderService)**

# Login Credentials

#### Cinema Desktop:
**username:** "desktop"
**password:** "test"
(role: administrator)

**username:** "content.editor"
**password:** "test"
(role: content editor)

#### Cinema Mobile:
**username:** "mobile"
**password:** "test"
(role: customer)

**username:** "customer598t"
**password:** "test"
(role: customer) (with enough data to show recommendations instantly)

