using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Model
{
        public  class Sales
        
    {
        internal List<SalesItem> _salesItems;

        public string NumberOfSale { get; set; }
        public double AmmountOfSale { get; set; }
       public List <SalesItem> SalesItem { get; set; }
        public DateTime DateOfSold { get; set; }

        public int saleQuantity { get; set; }
    }
}
