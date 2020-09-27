using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace My_Application.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Models.User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int index = 1; index <= 50; index++)
            {
                modelBuilder.Entity<Models.User>().HasData(


                    new Models.User()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = $" FirstName { index } ",
                        LastName = $" LastName { index } ",
                        UserId = index,
                        Email = $"TempEmail {index} @hotmail.com",
                        Username = $"Username {index} ",
                        Password = $"! {index} ! Password",
                        IsAdmin = false,
                    }
                );
            }

            base.OnModelCreating(modelBuilder);

        }
    }
}
