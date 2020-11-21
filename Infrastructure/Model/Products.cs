using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructure.Enum;


namespace MyFirstProject.Infrastructure.Model
{    

        public class Products
    {
        public string ProductName { get; set; }
        public double ProductPrice{ get; set; }
        public int Quantity { get; set; }
        public string ProductCode { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
