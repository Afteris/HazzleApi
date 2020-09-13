using HazzleApi.Models;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HazzleApi.Repository
{
    public class ExampleRepository : IExampleRepository<ExampleModel>
    {
        readonly ExampleDBContext _exampleContext;
       
        public ExampleRepository(ExampleDBContext context)
        {
            _exampleContext = context;
        }
        public int Add(ExampleModel entity)
        {
            return _exampleContext.Add(entity).Entity.Id;
        }
        public async Task AddAsync(ExampleModel entity)
        {
            await _exampleContext.AddAsync(entity);
        }

        public void Delete(ExampleModel entity)
        {
            _exampleContext.ExampleModels.Remove(
               _exampleContext.ExampleModels.First(item => item.Id == entity.Id));
        }

        public void Delete(int id)
        {
            _exampleContext.ExampleModels.Remove(
                _exampleContext.ExampleModels.First(item => item.Id == id));
        }

        public async Task<ExampleModel> FindAsync(params object[] keys)
        {
            return await _exampleContext.FindAsync<ExampleModel>(keys);
        }

        public IEnumerable<ExampleModel> FindBy(Func<ExampleModel, bool> predicate)
        {
            return _exampleContext.ExampleModels.Where(predicate);
        }

        public async Task<ExampleModel> FirstAsync(Func<ExampleModel, bool> predicate)
        {
            return await _exampleContext.FindAsync<ExampleModel>(predicate);       
        }

        public async Task<ExampleModel> FirstOrDefaultAsync(Func<ExampleModel, bool> predicate)
        {
            return await _exampleContext.FindAsync<ExampleModel>(predicate);
        }

        public IEnumerable<ExampleModel> GetAll()
        {
            if (_exampleContext.ExampleModels.Any())
            {
                return _exampleContext.ExampleModels.ToList();
            }
            return null;
        }

        public void SaveChanges()
        {
            _exampleContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _exampleContext.SaveChangesAsync();
        }

        public ExampleModel Update(ExampleModel entity)
        {
            return _exampleContext.Update(entity).Entity;
        }

        public async Task<int> UpdateAsync(ExampleModel entity)
        {
            return await Task.Run(() =>
            {
                _exampleContext.Update(entity);
                return _exampleContext.SaveChangesAsync();
                
            });
        }
    }
}
