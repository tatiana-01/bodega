using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class DetailsMovement
    {
        public int Id {get; set;}
        public string ? DestinyWarehouse {get; set;}
        public string ? AddressDestiny {get; set;}
        public int ProductsQuantity {get; set;}
    }
