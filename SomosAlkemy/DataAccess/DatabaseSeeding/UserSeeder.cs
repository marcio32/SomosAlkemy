using Microsoft.EntityFrameworkCore;
using SomosAlkemy.Entities;

namespace SomosAlkemy.DataAccess.DatabaseSeeding
{
    public class UserSeeder : IEntitySeeder
    {
       public void SeedDatabase(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    DNI = "40073892",
                    Email = "Marcio@gmail.com",
                    FirstName = "Marcio",
                    LastName = "Abriola",
                    IsDeleted = false,
                    Password = "1234"
                },
                new User
                {
                    Id = 2,
                    DNI = "40073894",
                    Email = "Pepe@gmail.com",
                    FirstName = "Pepe",
                    LastName = "Abriola",
                    IsDeleted = false,
                    Password = "1234"
                });
        }
    }
}
