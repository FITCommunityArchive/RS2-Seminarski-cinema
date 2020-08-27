using Flurl.Http;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Cinema.Shared.Helpers;
using Cinema.Shared.Constants;
using System.Globalization;
using Newtonsoft.Json;

namespace Cinema.Mobile.Services
{
    public class ApiService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Role { get; set; }
        public static string Token { get; set; }

        private string _route = null;

#if DEBUG
        private string _apiUrl = "http://localhost:5000/api";
#endif

#if RELEASE
        private string _apiUrl = "https://mywebsite.azure.com/api";
#endif

        public ApiService(string route)
        {
            _route = route;
        }

        public async Task<bool> AuthUser()
        {
            var loginUrl = $"{_apiUrl}/login";

            var result = await loginUrl.PostJsonAsync(new
            {
                userName = Username,
                password = Password
            });
            if (result.IsSuccessStatusCode)
            {
                var json = await result.Content.ReadAsStringAsync();
                var dynamicJson = JsonConvert.DeserializeObject<dynamic>(json);
                Token = dynamicJson.token;

                return true;
            }
            else
            {
                Token = "";
            }

            return false;
        }

        public async Task<T> Get<T>(object search, string route = null)
        {           
            try
            {
                var url = $"{_apiUrl}/{_route}";

                if (!string.IsNullOrEmpty(route))
                {
                    url += $"/{route}";
                }

                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }

                return await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", ValidationMessages.NOT_AUTHENTICATED, "OK");
                }

                throw;
            }            
        }

        public async Task<T> GetById<T>(object id)
        {
            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {           
            try
            {
                var url = $"{_apiUrl}/{_route}";
                return await url.WithOAuthBearerToken(Token).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }

            
        }

        public async Task<T> Register<T>(object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}";
                return await url.WithOAuthBearerToken(Token).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");
                return default(T);
            }


        }

        public async Task<T> Update<T>(object id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";
                return await url.WithOAuthBearerToken(Token).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, {string.Join(",", error.Value)}");
                }

                await Application.Current.MainPage.DisplayAlert("Error", stringBuilder.ToString(), "OK");

                return default(T);
            }

        }
    }
}
