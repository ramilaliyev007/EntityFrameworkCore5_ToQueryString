using Microsoft.EntityFrameworkCore;

namespace EFCore5ExamplesToQueryString
{
    public class Ef5ExampleDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=SERVER_NAME; Initial Catalog=EFCore5ExamplesToQueryString; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
