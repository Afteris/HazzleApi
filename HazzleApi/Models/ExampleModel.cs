using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HazzleApi.Models
{
    public class ExampleModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public int Age { get; set; }
    
        public string JobTitle { get; set; }
        public string Username { get; set; }
    }
}
