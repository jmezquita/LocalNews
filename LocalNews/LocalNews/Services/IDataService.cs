using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LocalNews.Models;

namespace LocalNews.Services
{



    public interface IDataService
    {
        Task<IEnumerable<Source>> GetSourcesAsync();
        Task<IEnumerable<TopHeadlines>> GetTopHeadlinesAsync(string SourceID, int pageSize);
        Task<IEnumerable<Everything>> GetEverythingsAsync(string SourceID, int pageSize);
        Task<IEnumerable<Country>> GetCountriesAsync();


       
    }
}
