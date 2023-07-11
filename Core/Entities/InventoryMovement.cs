using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class InventoryMovement
    {
        [Key]
        public string ? IdDocument { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ? IdOriginWarehouse{ get; set; }
       
    }
