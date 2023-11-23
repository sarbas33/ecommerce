using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public string? Description { get; set; }
        public int? Category { get; set; }
        public int? QuantityAvailable { get; set; }
        public int? Mrp { get; set; }
    }
}
