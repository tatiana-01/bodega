using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class User
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string ? Email { get; set; }
        public DateTime UpdateDate { get; set; }
        public string ? Photo { get; set; }
        public string ? Password { get; set; }
        public ICollection<ProductUser> ? ProductsUsers { get; set; }
    }
