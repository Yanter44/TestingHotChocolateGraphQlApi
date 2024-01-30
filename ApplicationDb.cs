using Microsoft.EntityFrameworkCore;
using TestApiForPostgreAndGraphQL.Entityes;


namespace TestApiForPostgreAndGraphQL
{
    public class ApplicationDb : DbContext
    {

       public DbSet<Person> Persons { get; set; }
   

        public ApplicationDb(DbContextOptions<ApplicationDb> options) : base(options)
        {
            Database.EnsureCreated();
            Database.OpenConnection();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

            modelBuilder.Entity<Person>().Property(employee => employee.Id).ValueGeneratedOnAdd();
        }
    }
}
