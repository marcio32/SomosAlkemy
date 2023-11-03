using Microsoft.EntityFrameworkCore;
using SomosAlkemy.DataAccess;
using SomosAlkemy.Entities;

namespace SomosAlkemy.Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(ContextDB contextDB) : base(contextDB)
        {
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _contextDB.Users.Where(x=> x.IsDeleted == false).ToListAsync();
            return users;
        }

    }
}
