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
        //private string apiKey = "0f108cb1c6744b3ba179a42e46b11f89";
        //readonly NewsApiClient newsApiClient = new NewsApiClient("0f108cb1c6744b3ba179a42e46b11f89");
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


        //public async Task<T> GetArticle()
        //{

        //    try
        //    {
        //        var articlesResponse = await newsApiClient.GetTopHeadlinesAsync(new TopHeadlinesRequest
        //        {
        //            Page = 1,
        //            PageSize = 50,
        //            Language = Languages.EN
        //        });

        //        return articlesResponse.Articles;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        throw ex;
        //    }

        //}
    }
}
