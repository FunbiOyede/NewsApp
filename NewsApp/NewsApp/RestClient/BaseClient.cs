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
        //readonly NewsApiClient newsApiClient = new NewsApiClient("0f108cb1c6744b3ba179a42e46b11f89");
        public async Task<T> GenericGet(string url)
        {
            //try
            //{
            //    var articlesResponse = await newsApiClient.GetTopHeadlinesAsync(new TopHeadlinesRequest
            //    {
            //        Page = 1,
            //        PageSize = 50,
            //        Language = Languages.EN
            //    });

            //    return articlesResponse;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    throw ex;
            //}

            try
            {

                var handler = new HttpClientHandler();
                var client = new HttpClient(handler);
        
                
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
                throw;
            }

        }

    }
}
