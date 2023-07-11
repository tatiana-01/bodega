using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Bodega
    {
        [Key]
        public string ? IdBodega { get; set; }
        public string ? Warehouse { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime updatedAt { get; set; }

    }
