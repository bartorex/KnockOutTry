using Domain.Models;
using EntityFrameworkConnection.UnitOfWork.Interfaces;
using ShopApplication.Services.Interfaces;

namespace ShopApplication.Services
{
    public class UserService:CRUDService<User>,IUserService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork.UserRepository)
        {
        }
    }
}
