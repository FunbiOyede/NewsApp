using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using NewsApp.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.RestClient
{
  public  class BaseClient<T>
    {
       
        public async Task<T> GenericGet(string url)
        {
           

            try
            {

                var handler = new HttpClientHandler();
                var client = new HttpClient(handler);
                client.Timeout = TimeSpan.FromMinutes(10);

                var requestMessage = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(url)
                };

                requestMessage.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Settings.API_KEY);


                var response = await client.SendAsync(requestMessage);

                // var connection =  response.StatusCode;
                if (response.IsSuccessStatusCode == true)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    T resultModel = JsonConvert.DeserializeObject<T>(content);
                    return resultModel;
                }
                else
                {
                    return default;
                }
               
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                throw ex;
            }

        }

    }
}
