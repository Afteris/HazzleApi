using Microsoft.EntityFrameworkCore;

namespace HazzleApi.Models
{
    public class ExampleDBContext : DbContext
    {
        public DbSet<ExampleModel> ExampleModels { get; set; }
        public ExampleDBContext(DbContextOptions<ExampleDBContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExampleModel>().HasData(
               new ExampleModel
               {
                   Id = 1,
                   Username = "MoN",
                   Age = 33,
                   JobTitle = "Master of None",
                   Name = "Jamppa Javonen"

               }, new ExampleModel
               {
                   Id = 2,
                   Username = "MoN",
                   Age = 33,
                   JobTitle = "Master of None",
                   Name = "Jamppa Javonen"
               }) ;
        }
    }
}
