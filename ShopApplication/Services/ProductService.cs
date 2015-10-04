using Domain.Models;
using EntityFrameworkConnection.UnitOfWork.Interfaces;
using ShopApplication.Services.Interfaces;

namespace ShopApplication.Services
{
    public class ProductService: CRUDService<Product>, IProductService 
    {
        private IUnitOfWork unitOfWork;
        public ProductService(IUnitOfWork unitOfWork) : base(unitOfWork.ProductRepository)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
