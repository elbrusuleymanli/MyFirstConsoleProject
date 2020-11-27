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
            _products = new List<Products>()
            {

               new Products
                {
                    ProductName = "onion",
                    ProductCode = "123",
                    ProductCategory = ProductCategory.Food,
                    ProductPrice = 2,
                    Quantity = 5


                },
                     new Products
                {
                    ProductName = "water",
                    ProductCode = "12",
                    ProductCategory = ProductCategory.Beverages,
                    ProductPrice = 2,
                    Quantity = 5

                     }
                };



            _salesItems = new List<SalesItem>()
            {
                    new SalesItem
                    {
                    QuantityItemsOfSold =1,
                    ProductItemsOfSold=_products.Find(p=>p.ProductCode=="123"),
                      NumberOfItem ="1",
                    }
                    };

            _sales = new List<Sales>()
            {
                new Sales
                {
                    AmmountOfSale = 225,
                    DateOfSold = new DateTime (2020,10,01),
                    NumberOfSale = "15",
                   SalesItem=_salesItems.FindAll(s=>s.QuantityItemsOfSold==1)

                }
            };

        }


        public void RemoveSaleProduct(string code)
        {
            try
            {
            var resultlist = _products.ToList();
           
            var single=resultlist.Find(r => r.ProductCode == code);
           
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

        public List<Sales> GetSaleByDateRange(DateTime startDate, DateTime endDate)
        {
            return  _sales.Where(p => p.DateOfSold >= startDate && p.DateOfSold <= endDate).ToList();

        }
        public List<Sales> GetSaleByDate(DateTime date)
        {
            return _sales.Where(s => s.DateOfSold == date).ToList();
        }

        public List<Sales> GetSaleByAmountRange(double minAmout, double maxAmout)
        {

            return _sales.Where(p => p.AmmountOfSale >= minAmout && p.AmmountOfSale <= maxAmout).ToList();

        }

        public List<Sales> GetSaleByNumber(string numberOfsale)
        {
         return   _sales.Where(s => s.NumberOfSale == numberOfsale).ToList();
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

        public void RemoveSale(string number)
        {
            try
            {
                Sales sales = new Sales();
              
              var sale =_sales.Find(s => s.NumberOfSale == number);
                
                _sales.Remove(sale);

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
            
            double amount = 0;
           
            var product = _products.Where(p => p.ProductCode == code).FirstOrDefault();
            
            var saleItem = new SalesItem();
            
            var Code = code;
            
            saleItem.QuantityItemsOfSold = count;
            
            saleItem.ProductItemsOfSold = product;
            
            saleItem.QuantityItemsOfSold = SalesItems.Count + 1;
            
            SalesItems.Add(saleItem);
            
            amount += count * saleItem.ProductItemsOfSold.ProductPrice;
            
            var saleNo = _sales.Count + 1;
            
            var saleDate = DateTime.Now;
            
            var sale = new Sales();
            
            sale.NumberOfSale = "123";
            
            sale.AmmountOfSale = amount;
            
            sale.DateOfSold = saleDate;
            
            sale.SalesItem = items;
            
            _sales.Add(sale);

            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
         
        }

        public void RemoveSold(string code, int count)
        {
            try
            {
                Products products= new Products();

                var sale = _products.Find(s => s.ProductCode == code&&s.Quantity==count);

                var remove = _products.Remove(sale);


                Console.WriteLine(remove); 

                Console.WriteLine("qeyd etdiyiniz satis silindi");
            }

            catch (Exception)
            {

                Console.WriteLine("bele bir mehsul yoxdur");
            }


        }

    }
}
