using HazzleApi.Models;
using HazzleApi.Repository;
using System.Collections.Generic;

namespace HazzleApi.Services
{
    public class ExampleService : IExampleService
    {

        IExampleRepository _repository;

        public ExampleService(IExampleRepository repository)
        {
            _repository = repository;
        }

        protected bool ValidateModel(ExampleModel exampleModel)
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
       
            // Database logic
            try
            {
                _repository.AddAsync(exampleModel);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool DeleteExampleModel(int id)
        {
            _repository.Delete(id);

            return true;
        }
    }
}

