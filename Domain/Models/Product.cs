using Domain.Interfaces;

namespace Domain.Models
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
