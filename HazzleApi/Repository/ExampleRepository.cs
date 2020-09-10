using HazzleApi.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HazzleApi.Repository
{
    public class ExampleRepository : IExampleRepository
    {
        List<ExampleModel> ExampleList { get; set; }
        public ExampleRepository()
        {
            //This is just Example code, for simulate db data...
            ExampleList = new List<ExampleModel>();
            var item = new ExampleModel
            {
                Name = "test",
                Id = 1,
                Username = "test!!!",
                JobTitle = "something",
                Age = 32
            };
            var item2 = new ExampleModel
            {
                Name = "test1",
                Id = 2,
                Username = "test!!!",
                JobTitle = "something",
                Age = 33
            };
            var item3 = new ExampleModel
            {
                Name = "test2",
                Id = 3,
                Username = "test!!!",
                JobTitle = "something",
                Age = 35
            };
            var item4 = new ExampleModel
            {
                Name = "test3",
                Id = 4,
                Username = "test!!!",
                JobTitle = "something",
                Age = 22
            };
            var item5 = new ExampleModel
            {
                Name = "test4",
                Id = 5,
                Username = "test!!!",
                JobTitle = "something",
                Age = 43
            };
            ExampleList.Add(item);
            ExampleList.Add(item2);
            ExampleList.Add(item3);
            ExampleList.Add(item4);
            ExampleList.Add(item5);

        }

        public Task AddAsync(ExampleModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ExampleModel entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            ExampleList.Remove(ExampleList.FirstOrDefault(item => item.Id == id));
        }

        public Task<ExampleModel> FindAsync(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExampleModel> FindBy(Func<ExampleModel, bool> predicate)
        {
            return ExampleList.Where(predicate);
        }

        public Task<ExampleModel> FirstAsync(Func<ExampleModel, bool> predicate)
        {
            return (Task<ExampleModel>)ExampleList.Where(predicate);
           
        }

        public Task<ExampleModel> FirstOrDefaultAsync(Func<ExampleModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExampleModel> GetAll()
        {
            return ExampleList;
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ExampleModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
