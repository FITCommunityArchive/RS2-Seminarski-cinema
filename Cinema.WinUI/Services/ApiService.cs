using Cinema.Models.Requests.Users;
using Cinema.Shared.Helpers;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Cinema.WinUI.Services
{
    public class ApiService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }

        public static string Role { get; set; }
        public static string Token { get; set; }

        private string _route = null;

        public ApiService(string route)
        {
            _route = route;
        }

        public async Task<bool> AuthUser()
        {
            var loginUrl = $"{Properties.Settings.Default.APIUrl}/login";

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

                var decodeUrl = $"{Properties.Settings.Default.APIUrl}/decode";
                var decodeResult = await decodeUrl.SetQueryParams(new { token = Token }).GetJsonAsync<List<string>>();

                if (decodeResult.Count > 0)
                {
                    Role = decodeResult[2];
                }

                return true;
            }
            else
            {
                Token = "";
            }

            return false;
        }

        public async Task<bool> ResetPassword(int id, UserPasswordResetRequest request)
        {
            var resetPassUrl = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}/resetPassword";

            var result = await resetPassUrl.WithOAuthBearerToken(Token).PutJsonAsync(request);

            if (result.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }

        public async Task<string> ResetPasswordToken(int id)
        {
            var resetPassTokenUrl = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}/resetPasswordToken";
            var tokenResult = await resetPassTokenUrl.WithOAuthBearerToken(Token).GetStringAsync();
            return tokenResult;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            var result = await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> GetById<T>(object id, object includes = null)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            if (includes != null)
            {
                url += "?";
                url += await includes.ToQueryString();
            }

            return await url.WithOAuthBearerToken(Token).GetJsonAsync<T>();
        }

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            return await url.WithOAuthBearerToken(Token).PostJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Update<T>(object id, object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithOAuthBearerToken(Token).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> UpdateWithRoute<T>(object id, object request, string route)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}/{route}";

            return await url.WithOAuthBearerToken(Token).PutJsonAsync(request).ReceiveJson<T>();
        }

        public async Task<T> Delete<T>(object id)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithOAuthBearerToken(Token).DeleteAsync().ReceiveJson<T>();
        }
    }
}
