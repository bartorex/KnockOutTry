using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using Antlr.Runtime.Misc;
using Domain.Models;
using EntityFrameworkConnection.Context;
using EntityFrameworkConnection.Repository;
using EntityFrameworkConnection.Repository.Interafaces;
using EntityFrameworkConnection.UnitOfWork;
using ShopApplication.Services;
using ShopApplication.Services.Interfaces;

namespace WebApi.Controllers
{
    [EnableCors(origins: "http://localhost:14778", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        private readonly List<Product> products;
        private readonly IProductService productService;
        
        public ProductController()
        {
            productService = new ProductService(new UnitOfWork());
            productService.Add(new Product()
            {
                Name = "Cos",
                Id = 1,
                Price = 21,
                Category = "Sdasd",
                User = null,
            });
        }

        public async Task<Product[]> GetAllProducts()
        {
            IRepository<Product> repository = new Repository<Product>(new ShopContext());
            await repository.Add(new Product()
            {
                Name = "Cos",
                Id = 1,
                Price = 21,
                Category = "Sdasd",
                User = null,
            });
            var products = await repository.GetAll();
            return products.ToArray();
        } 
    }
}
