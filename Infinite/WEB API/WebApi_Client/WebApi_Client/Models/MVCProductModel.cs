using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Client.Models
{
    public class MVCProductModel
    {
        public int ProductID { get; set; }
        public string ProdName { get; set; }
        public int Price { get; set; }
        public int QtyAvailable { get; set; }
    }
}