using HazzleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HazzleApi.Repository
{
    public class ExampleRepository : IExampleRepository<ExampleModel>
    {
        readonly ExampleDBContext _exampleContext;
       
        List<ExampleVM> ExampleList { get; set; }
        public ExampleRepository(ExampleDBContext context)
        {
            _exampleContext = context;
        }
        public int Add(ExampleModel entity)
        {
            return _exampleContext.Add(entity).Entity.Id;
        }
        public Task AddAsync(ExampleModel entity)
        {
            throw new NotImplementedException();
            
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

        public Task<ExampleModel> FindAsync(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExampleModel> FindBy(Func<ExampleModel, bool> predicate)
        {
            return _exampleContext.ExampleModels.Where(predicate);
        }

        public Task<ExampleModel> FirstAsync(Func<ExampleModel, bool> predicate)
        {
            return null; // (Task<ExampleModel>)ExampleList.Where(predicate);
           
        }

        public Task<ExampleModel> FirstOrDefaultAsync(Func<ExampleModel, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ExampleModel> GetAll()
        {
           
            return _exampleContext.ExampleModels.ToList();
        
        }

        public void SaveChanges()
        {
            _exampleContext.SaveChanges();
        }

        public Task SaveChangesAsync()
        {
            return _exampleContext.SaveChangesAsync();
        }

        public Task UpdateAsync(ExampleModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
