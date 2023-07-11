using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class InventoryMovement
    {
        public string ? IdDocument { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ? OriginWarehouse{ get; set; }
        public string ? AddressDestiny { get; set; }
        public int ProductsQuantity { get; set; }
    }
