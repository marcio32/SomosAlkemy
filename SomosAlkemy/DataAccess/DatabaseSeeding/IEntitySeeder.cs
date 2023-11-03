using Microsoft.EntityFrameworkCore;

namespace SomosAlkemy.DataAccess.DatabaseSeeding
{
    public interface IEntitySeeder
    {
        void SeedDatabase(ModelBuilder modelBuilder);
    }
}
