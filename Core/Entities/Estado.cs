using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Estado
    {
        public int Id { get; set; }
        public string ? Description { get; set; }
        public ICollection<Product> ? Products { get; set; }
    }
