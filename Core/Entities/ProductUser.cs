using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class ProductUser
    {
        public int IdUser { get; set;}
        public int IdProduct { get; set;}

        public User ? Users { get; set;}
        public Product ? Products { get; set;}
    }
