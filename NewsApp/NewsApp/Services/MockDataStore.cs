using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    public class MockDataStore : IMockDataStore<test>
    {
        public List<test> Goods;
        public List<test> Bookmarks;

        public MockDataStore()
        {
            Goods = new List<test>()
            {
                new test{ Id = 3, Name = "X item", Description="This is an item description."},
                new test { Id = 4, Name = "A item", Description = "This is an item description." },
                new test { Id = 5, Name = "B item", Description = "This is an item description." },
                new test{ Id = 6, Name = "C item", Description="This is an item description."},
                new test{ Id = 7, Name = "D item", Description="This is an item description."}
            };

        }

        public async Task<IEnumerable<test>> GetResult()
        {
            return await Task.FromResult(Goods);
        }


        public async Task<bool> AddToBookMarks(test t)
        {
            Bookmarks.Add(t);
            return await Task.FromResult(true);
        }
        
    }
}
