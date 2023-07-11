using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string ? Description { get; set; }
        public int Quantity { get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public double Price { get; set; }
        public int EstadoId { get; set; }
        public Estado ? Estado { get; set; }

         public ICollection<ProductUser> ? ProductsUsers { get; set; }

    }
}