using Domain.Models;
using EntityFrameworkConnection.Context;
using EntityFrameworkConnection.Repository;
using EntityFrameworkConnection.Repository.Interafaces;
using EntityFrameworkConnection.UnitOfWork.Interfaces;

namespace EntityFrameworkConnection.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext shopContext;
        private IRepository<Product> productRepository;
        private IRepository<User> userRepository;

        public UnitOfWork()
        {
            shopContext = new ShopContext();
        }


        public IRepository<Product> ProductRepository
        {
            get
            {
                if(productRepository == null)
                    productRepository = new Repository<Product>(shopContext);
                return productRepository;
            }
        }

        public IRepository<User> UserRepository
        {
            get
            {
                if(userRepository == null)
                    userRepository = new Repository<User>(shopContext);
                return userRepository;
            }
        }
    }
}
