
namespace HazzleApi.Models
{
    public class ExampleModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string JobTitle { get; set; }
        public string Username { get; internal set; }
    }
}
