using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static FacebookPosting.MainWindow;

namespace FacebookPosting
{
    internal class MonaWebApiClient
    {
        public async Task<HttpResponseMessage> Register(string Id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:47920/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           
                var registrationInfo = new RegistrationInfo
                {
                    Email = "test@gmail.com",
                    Password = "Password1!",
                    ConfirmPassword = "Password1!"
                };
               
                Task<HttpResponseMessage> responseTask =  client.PostAsync<RegistrationInfo>("/api/Account/Register", registrationInfo, new JsonMediaTypeFormatter());

                var responseMessage = await responseTask;
                await Task.Delay(4000);
                //no we heave the message
                var headers = responseMessage.Headers;
                return responseMessage;
                
            }

        }

        public async Task<AccessToken> GetAccessTokenAsync(string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:47920/");
                client.DefaultRequestHeaders.Accept.Clear();
            
                string postData = $"grant_type=password&username={username}&password={password}";
                StringContent queryString = new StringContent(postData);
              
                var httpResponse =  await client.PostAsync("/Token", queryString);

                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {
                    dynamic result = await httpResponse.Content.ReadAsAsync<dynamic>();

                    AccessToken newToken = new AccessToken
                    {
                        TokenString = result.access_token,
                        Expiration = DateTime.Now.Add(TimeSpan.FromSeconds((double)result.expires_in))
                    };

                    return newToken;
                }

                throw new Exception("HTTP error occured -" + httpResponse.StatusCode);

            }
        }

        public class RegistrationInfo
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }

     
    }
}
