using HazzleApi.Models;
using HazzleApi.Repository;
using System.Collections.Generic;
using System.Linq;

namespace HazzleApi.Services
{
    public class ExampleService : IExampleService
    {
        private readonly IExampleRepository<ExampleModel> _repository;

        public ExampleService(IExampleRepository<ExampleModel> repository)
        {
            _repository = repository;
        }

        protected bool ValidateModel(ExampleVM exampleModel)
        {

            //Data validation...
            return true;
        }

        public IEnumerable<ExampleModel> GetExampleModels()
        {
            
            return _repository.GetAll();
        }

        public bool CreateExampleModel(ExampleModel exampleModel)
        {
            try
            {
                _repository.Add(exampleModel);
                _repository.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteExampleModel(int id)
        {
            try
            {
                _repository.Delete(id);
                _repository.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public ExampleModel GetExampleModel(int id)
        {
            return _repository.FindBy(item => item.Id == id).First();
        }

        public bool UpdateExampleModel(ExampleModel model)
        {
            return true;
        }
    }
}

