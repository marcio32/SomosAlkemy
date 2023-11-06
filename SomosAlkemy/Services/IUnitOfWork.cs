using SomosAlkemy.Repository;

namespace SomosAlkemy.Services
{
    public interface IUnitOfWork
    {
        public UserRepository UserRepository { get; set; }

        public Task<int> Complete();
    }
}
