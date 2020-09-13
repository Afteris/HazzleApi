using HazzleApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HazzleApi.Services
{
    public interface IExampleService
    {
        IEnumerable<ExampleModel> GetExampleModels();

        ExampleModel GetExampleModel(int id);

        bool CreateExampleModel(ExampleModel model);

        bool DeleteExampleModel(int id);
        Task<int> UpdateExampleModelAsync(ExampleModel model);
    }
}
