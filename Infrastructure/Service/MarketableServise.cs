using MyFirstProject.Infrastructure.Enum;
using MyFirstProject.Infrastructure.Interface;
using MyFirstProject.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;


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
                    NumberOfSale = "22dd",
                    AmmountOfSale = 172,
                    DateOfSold = new DateTime(2020,10,01),
                   
                },
                 new Sales
                {
                    NumberOfSale = "11BB",
                    AmmountOfSale = 218,
                    DateOfSold = new DateTime(2020,10,05),

                },
                 
  };
            



            _products = new List<Products>()
            {
                new Products
                {
                    ProductName = "Sugar",
                    ProductPrice = 2.5,
                    Quantity = 55,
                    ProductCode ="1234abcd",
                    
                },
                new Products
                {
                    ProductName = "Sweet",
                    ProductPrice = 1.7,
                    Quantity = 205,
                    ProductCode ="253agfd",

                }


            };
            
       
        
        }
        

        public void AddNewSale(Sales sales)
        {
           _sales.Add(sales);
        }

        public void RemoveSaleProduct(string numberOfsale)
        {
            _sales.RemoveAt(1);
        }

        public List <Sales> ShowAllSale()
        {
          return  _sales;
        }

        public double GetSaleByDateRange(DateTime startDate, DateTime endDate)
        {
          return  _sales.Where(s => s.DateOfSold >= startDate && s.DateOfSold <= endDate).Sum(s => s.AmmountOfSale);
        }

        public List<Sales> GetSaleByDate(DateTime date)
        {
            return (List<Sales>)_sales.Where(s => s.DateOfSold == date);
        }

        public double GetSaleByAmountRange(double minAmout, double maxAmout)
        {
          return  _sales.Where(s => s.AmmountOfSale >= minAmout && s.AmmountOfSale <= maxAmout).Sum(s => s.AmmountOfSale);
        }

        public double GetSaleByNumber(string numberOfsale)
        {
         return   _sales.Where(s => s.NumberOfSale == numberOfsale).Sum(s => s.AmmountOfSale);
        }

        public void AddNewProducts(Products product)
        {
            _products.Add(product);
        }

        public void FindProductForChangeByCode(string productCode)
        {
            _products.Where(p => p.ProductCode == productCode);
        }

        public List<Products> ShowProductsByCategory(ProductCategory productCategory)
        {
          return(List<Products>) _products.Where(p => p.ProductCategory == productCategory);
        }

        public List<Products> GetProductByPriceRange(double minPrice, double maxPrice)
        {
            return (List<Products>) _products.Where(p => p.ProductPrice >= minPrice && p.ProductPrice <= maxPrice);
        }

        public List<Products> SearchProductByName(string productName)
        {
            return (List<Products>)_products.Where(p => p.ProductName == productName);
        }

       

       
    }
}