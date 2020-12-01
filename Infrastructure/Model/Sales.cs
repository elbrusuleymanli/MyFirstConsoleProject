using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Model
{
        public  class Sales
        
    {
        public int NumberOfSale { get; set; }
        public double AmmountOfSale { get; set; }
        public List <SalesItem> SalesItem { get; set; }
        public DateTime DateOfSold { get; set; }

    }
}
