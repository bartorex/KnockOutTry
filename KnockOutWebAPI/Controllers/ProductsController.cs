using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Domain.Models;


namespace KnockOutWebAPI.Controllers
{
    [EnableCors(origins: "http://localhost:14778", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {
        public List<Product> Products; 
        public ProductsController()
        {
            Products = new List<Product>
            {
                new Product {Id = 1, Category = "Toys", Name = "Yo-yo", Price = 12},
                new Product{Id = 2, Category = "Food", Name = "Tomato soup", Price = 6.5M},
                new Product{Id = 3, Category = "Some", Name = "sdas", Price = 55}
            };
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return Products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = Products.FirstOrDefault(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
