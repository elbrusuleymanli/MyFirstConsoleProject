using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Model
{
        public class SalesItem
    {
        public int NumberOfItem { get; set; }
        public Products ProductItemsOfSold { get; set; }
        public int QuantityItemsOfSold { get; set; }
    }
}
