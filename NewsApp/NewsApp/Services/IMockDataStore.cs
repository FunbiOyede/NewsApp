using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
   public interface IMockDataStore<T>
    {
        Task<IEnumerable<T>> GetResult();
    }
}
