using NewsApp.Models;
using NewsApp.RestClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{

    public interface IApiServices {
        Task<List<Article>> GetArticles();
        Task<List<Article>> SearchArticles(string param);
    }

    public class ApiServices : IApiServices
    {

        public async Task<List<Article>> GetArticles()
        {
            ApiClient<BaseResultModel<Article>> apiClient = new ApiClient<BaseResultModel<Article>>();
            try
            {
                var result = await apiClient.GetArticles();
                return result.articles;
            } catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
                throw ex;
            }

        }
        public async Task<List<Article>> SearchArticles(string param)
        {
            ApiClient<BaseResultModel<Article>> apiClient = new ApiClient<BaseResultModel<Article>>();
            try
            {
                var result = await apiClient.SearchArticles(param);
                return result.articles;
            } catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
                throw ex;
            }

        }

       
    }
}
