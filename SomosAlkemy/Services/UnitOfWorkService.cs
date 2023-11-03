using SomosAlkemy.DataAccess;
using SomosAlkemy.Repository;

namespace SomosAlkemy.Services
{
    public class UnitOfWorkService : IUnitOfWork
    {
        public UserRepository UserRepository { get; set; }
        public UnitOfWorkService(ContextDB contextDB)
        {
            UserRepository = new UserRepository(contextDB);
        }

      
    }
}
