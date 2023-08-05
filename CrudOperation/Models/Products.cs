using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudOperation.Models
{
    public class Products
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductPrice { get; set;}
        public int CategoryId { get; set; }



    }
}