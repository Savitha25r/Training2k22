using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class Product
    {
        public Product()
        {
            ProductSales = new HashSet<ProductSale>();
        }

        public int ProductId { get; set; }
        public string ProdName { get; set; }
        public int? Price { get; set; }
        public int? QtyAvailable { get; set; }

        public virtual ICollection<ProductSale> ProductSales { get; set; }
    }
}
