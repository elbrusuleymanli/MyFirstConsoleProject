using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Model
{
        public  class Sales
        
    
    {
        public string NumberOfSale { get; set; }
        public double AmmountOfSale { get; set; }
        List <SalesItem> SalesItem { get; set; }
        public DateTime DateOfSold { get; set; }
        public int saleQuantity { get; set; }


    }
}
