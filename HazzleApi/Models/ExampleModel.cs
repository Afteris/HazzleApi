using System.ComponentModel.DataAnnotations;

namespace HazzleApi.Models
{
    public class ExampleModel
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Job title is required")]
        public string JobTitle { get; set; }

        [Required(ErrorMessage = "Username is required")]
        public string Username { get; internal set; }
    }
}
