using Administration.Classes;
using Mona.Webapi.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Administration
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

        public async Task<IEnumerable<Product>> GetProducts()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:47920/");
                client.DefaultRequestHeaders.Accept.Clear();

                StringContent queryString = new StringContent("");

                var httpResponse = await client.GetAsync("/api/Product");

                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {              
                    return await httpResponse.Content.ReadAsAsync<IEnumerable<Product>>();                
                }

            }
            return null;
        }

        public async Task<Product> GetProduct(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:47920/");
                client.DefaultRequestHeaders.Accept.Clear();

                string postData = $"id={id}";
                StringContent queryString = new StringContent(postData);


                var httpResponse = await client.GetAsync($"/api/Product/{id}", HttpCompletionOption.ResponseHeadersRead);

                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {
                    var result = await httpResponse.Content.ReadAsAsync<Product>();
                    

                    return result;
                }

            }
            return null;
        }

        public async Task<bool> AddProduct(Product product)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:47920/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var httpResponse = await client.PostAsync<Product>("/api/Product", product, new JsonMediaTypeFormatter());

                if (httpResponse.StatusCode == HttpStatusCode.Created)
                {
                    dynamic result = await httpResponse.Content.ReadAsAsync<dynamic>();
                   



                  
                    return true;
                }

            }
            return false;
        }

        public async Task<bool> UpdateProduct(int id, Product product)
        {
            //TODO: method doesn't work, still have to figure out how to pass in the id along with the complex type
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:47920/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



                var httpResponse = await client.PutAsync<Product>($"/api/Product/{id}", product, new JsonMediaTypeFormatter());

                if (httpResponse.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }

            }
            return false;
        }

        public class RegistrationInfo
        {
            public string Email { get; set; }
            public string Password { get; set; }
            public string ConfirmPassword { get; set; }
        }

     
    }
}
