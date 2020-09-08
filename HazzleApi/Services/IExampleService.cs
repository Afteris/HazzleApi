using HazzleApi.Models;
using System.Collections.Generic;

namespace HazzleApi.Services
{
    public interface IExampleService
    {
        IEnumerable<ExampleModel> GetExampleModels();

        bool CreateExampleModel(ExampleModel exampleModel);

        bool DeleteExampleModel(int id);
    }
}
