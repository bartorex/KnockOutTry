using System.Collections.Generic;
using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public List<Product> Products { get; set; }
    }
}
