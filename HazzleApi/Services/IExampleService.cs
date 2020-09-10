using HazzleApi.Models;
using System.Collections.Generic;

namespace HazzleApi.Services
{
    public interface IExampleService
    {
        IEnumerable<ExampleModel> GetExampleModels();

        ExampleModel GetExampleModel(int id);

        bool CreateExampleModel(ExampleModel exampleModel);

        bool DeleteExampleModel(int id);
        bool UpdateExampleModel(ExampleModel model);
    }
}
