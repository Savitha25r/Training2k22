using System;
using System.Collections.Generic;

#nullable disable

namespace Core_EF_DBFirst.Models
{
    public partial class ProductSale
    {
        public int ProductSalesId { get; set; }
        public int? ProductId { get; set; }
        public int? QtySold { get; set; }

        public virtual Product Product { get; set; }
    }
}
