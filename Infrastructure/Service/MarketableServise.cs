using MyFirstProject.Infrastructure.Enum;
using MyFirstProject.Infrastructure.Interface;
using MyFirstProject.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;
using static System.Net.Mime.MediaTypeNames;

namespace MyFirstProject.Infrastructure.Service
{
    public class MarketableServise : IMarketable
    {
        private List<Sales> _sales;
        public List<Sales> Sales => _sales;

        private List<Products> _products;

        public List<Products> Products => _products;

        private List<SalesItem> _salesItems;

        public List<SalesItem> SalesItems => _salesItems;

     
        public MarketableServise()
        {
           
            _sales = new List<Sales>()
            {
                new Sales
                {
                    AmmountOfSale = 225,
                    saleQuantity = 42,
                    DateOfSold= DateTime.Now,
                    NumberOfSale = "15",
                    SalesItem=_salesItems,



                   _salesItems = new List<SalesItem>()
            {
                new SalesItem
                {
                    QuantityItemsOfSold=12,
                    NumberOfItem="054b",
                    ProductItemsOfSold=new Products()
                    {
                        ProductName = "tort",
                        ProductCode = "055",
                        ProductCategory=ProductCategory.Sweets,
                        ProductPrice = 12.7,
                        Quantity = 7,

                    }


                }
                   }

        }

            };


            _products = new List<Products>()
            {

                new Products
                {
                    ProductName = "sogan",
                    ProductCode = "123",
                    ProductCategory = ProductCategory.Food,
                    ProductPrice = 2,
                    Quantity = 5


                },
                     new Products
                {
                    ProductName = "su",
                    ProductCode = "12",
                    ProductCategory = ProductCategory.Beverages,
                    ProductPrice = 2,
                    Quantity = 5


                }
                                
           };




            
              
            
          

        }
               


        public void RemoveSaleProduct(string code)
        {
            try
            {
            var resultlist = _products.ToList();
           
            var single=resultlist.Single(r => r.ProductCode == code);
           
             _products.Remove(single);
               
                Console.WriteLine("qeyd etdiyiniz mehsul silindi");
            }
            
            catch (Exception)
            {

                Console.WriteLine("bele bir mehsul yoxdur");
            }

          
        }

        public void ShowAllSale()
        {

            _salesItems.Count();


        }

        public double GetSaleByDateRange(DateTime startDate, DateTime endDate)
        {
            Sales sale = new Sales();
            
            Products products = new Products();
         
            sale.AmmountOfSale = products.ProductPrice * products.Quantity;
        
            return  _sales.FindAll(s => s.DateOfSold >= startDate && s.DateOfSold <= endDate).Sum(s => s.AmmountOfSale);
}
           

        public double GetSaleByDate(DateTime date)
        {
            return _sales.Where(s => s.DateOfSold == date).Count();
        }

        public double GetSaleByAmountRange(double minAmout, double maxAmout)
        {
                var list = _products.ToList();
                var show = list.FindAll(p => p.ProductPrice>=minAmout&&p.ProductPrice<=maxAmout);

              foreach (var item in show)
            {
                Console.WriteLine("--------- " + item.ProductName);
                Console.WriteLine("--------- " + item.ProductPrice);
                Console.WriteLine("--------- " + item.ProductCategory);
                Console.WriteLine("--------- " + item.Quantity);
            }


            Sales sale = new Sales();
            Products products = new Products();
            sale.AmmountOfSale = products.ProductPrice * products.Quantity;
            return _sales.Where(a => a.AmmountOfSale >= minAmout && a.AmmountOfSale <= maxAmout).Sum(s => s.AmmountOfSale);
        }

        public double GetSaleByNumber(string numberOfsale)
        {
         return   _sales.Where(s => s.NumberOfSale == numberOfsale).Sum(s => s.AmmountOfSale);
        }

        public void AddNewProducts(Products product)
        {
            _products.Add(product);
        }

        public List<Products> FindProductForChangeByCode(string code)
        {
           
           var list =  _products.FindAll(p => p.ProductCode == code).ToList();
           
       return _products; 
        }

        public List<Products> ShowProductsByCategory(ProductCategory productCategory)
        {
           var list = _products.ToList();
         
            var show= list.FindAll(p => p.ProductCategory == productCategory);
       
            foreach (var item in show)
            {
                var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");

                int i = 1;

                    table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);
                    i++;

                
                table.Write();

            }
            return Products;
           
        
        }

        public List<Products> GetProductByPriceRange(double minPrice, double maxPrice)
        {
            Products products = new Products();
            
            if (minPrice>maxPrice)
                {
                
                Console.WriteLine("Minimal mebleg maxsimal meblegden boyukdur,yeniden cehd edin");
                }
           
            try
            {
                var show = _products.ToList();

                var list = show.FindAll(p => p.ProductPrice >= minPrice && p.ProductPrice <= maxPrice);
               

                foreach (var item in list)
                {
                    var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");

                    int i = 1;
                    i++;
                    table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);

                    table.Write();

                }
            }
          
            catch (Exception)
            {

                Console.WriteLine("qeyd etdiyiniz mebleg araliginda mehsul yoxdur");
            }
            
           
            return _products;
        }

        public List<Products> SearchProductByName(string text)
        {
            Products products = new Products();
            
            var list = _products.ToList();

            var show = list.FindAll(p => p.ProductName == text||p.ProductName.Contains(text));

            foreach (var item in show)
            {
                var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");

                int i = 1;

                table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);
                i++;


                table.Write();

            }
            return Products;


            //return _products.Where(p => p.ProductName == products).Contains(Text);
        }

        public List<Products> ShowAllProduct()
        {
            return _products;
        }

        public void RemoveSale(string NumberofSale)
        {
            try
            {
                var resultlist = _sales.ToList();



                var single = resultlist.Single(r => r.NumberOfSale == NumberofSale);

                _sales.Remove(single);

                Console.WriteLine("qeyd etdiyiniz satis silindi");
            }

            catch (Exception)
            {

                Console.WriteLine("bele bir mehsul yoxdur");
            }

            
        }

        public void AddNewSale(string code, int count)
        {
            List<Products> products = new List<Products>();
          
           
            
            List<SalesItem> items = new List<SalesItem>();
            
            Products product = products.Find(p => p.ProductCode == code);
            
            SalesItem salesItem = new SalesItem();
            
            salesItem.NumberOfItem = code;
            
            salesItem.QuantityItemsOfSold = count;
            
            salesItem.ProductItemsOfSold = product;
            
            
            SalesItems.Add(salesItem);
            List<Sales> sale = new List<Sales>();
        }
    }
}