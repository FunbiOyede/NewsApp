using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.RestClient
{
   public class ApiClient<T> : BaseClient<T>
    {
        private string BaseUrl = "http://newsapi.org/v2/top-headlines?country=us";
      
        public async Task<T> GetArticles()
        {
           
            try
            {
                return await GenericGet(BaseUrl);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

        }


        public async Task<T> SearchArticles(string param)
        {
            string url = $"https://newsapi.org/v2/everything?q={param}";
            try
            {
                return await GenericGet(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }
    }
}
