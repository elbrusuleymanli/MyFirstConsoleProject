using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Model
{
    class Sales
    {
        public int NumberOfSale { get; set; }
        public double AmmountOfSale { get; set; }
        List <SalesItem> SalesItem { get; set; }
        public DateTime DateOfSold { get; set; }

    }
}
