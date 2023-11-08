using Microsoft.EntityFrameworkCore;
using SomosAlkemy.DataAccess;
using SomosAlkemy.DTOs;
using SomosAlkemy.Entities;
using SomosAlkemy.Services;

namespace SomosAlkemy.Repository
{
    public class UserRepository : Repository<User>
    {

        public UserRepository(ContextDB contextDB) : base(contextDB)
        {

        }

        public async Task<List<User>> GetAllUsers()
        {
            try
            {
                return await _contextDB.Users.Where(x => x.IsDeleted == false).ToListAsync(); ;
            }
            catch (Exception ex) {

                return null;
            }
            
        }

        public async Task<User?> GetUserId(int id)
        {
            try
            {
                return await _contextDB.Users.Where(x => x.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public async Task<bool> InsertUser(UserRegisterDTO userRegisterDTO)
        {
            try
            {
                var users = new User();
                users = userRegisterDTO;

                return await base.Insert(users);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateUser(UserRegisterDTO userRegisterDTO, int id)
        {
            try
            {
                var users = new User();
                users = userRegisterDTO;
                users.Id = id;
                users.IsDeleted = userRegisterDTO.IsDeleted;

                return await base.Update(users);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteUser(int id)
        {
            try
            {
                var user = await GetUserId(id);
                user.IsDeleted = true;

                return await base.Update(user);
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public async Task<User?> AuthenticateCredentials(UserLoginDTO userLoginDTO)
        {
            try
            {
                return await _contextDB.Users.FirstOrDefaultAsync(x=> x.Email == userLoginDTO.Email && x.Password == userLoginDTO.Password);
            }
            catch { return null; }
        }


    }
}
