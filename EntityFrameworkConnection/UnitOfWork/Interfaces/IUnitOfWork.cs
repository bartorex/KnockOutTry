using Domain.Models;
using EntityFrameworkConnection.Repository.Interafaces;

namespace EntityFrameworkConnection.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Product> ProductRepository { get; }
        IRepository<User> UserRepository { get; } 
    }
}
