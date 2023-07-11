using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class ProductUser
    {
        public int IdUser { get; set;}
        public int IdProduct { get; set;}

        public User ? User { get; set;}
        public Product ? Product { get; set;}
    }
