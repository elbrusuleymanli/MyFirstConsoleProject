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
                    NumberOfSale = "11AA",
                    AmmountOfSale = 172,
                    DateOfSold = new DateTime(2020,10,01),
                   
                },
                 new Sales
                {
                    NumberOfSale = "11BB",
                    AmmountOfSale = 218,
                    DateOfSold = new DateTime(2020,10,05),

                },
                  new Sales
                {
                    NumberOfSale = "11CC",
                    AmmountOfSale = 120,
                    DateOfSold = new DateTime(2020,10,08),

                },
                  new Sales
                {
                    NumberOfSale = "11DD",
                    AmmountOfSale = 355,
                    DateOfSold = new DateTime(2020,10,11),

                },
                 new Sales
                {
                    NumberOfSale = "11EE",
                    AmmountOfSale = 32,
                    DateOfSold = new DateTime(2020,10,21),

                }
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

                },
                new Products
                {
                    ProductName = "Milk",
                    ProductPrice = 2.53,
                    Quantity = 217,
                    ProductCode ="153nocd",

                },
                new Products
                {
                    ProductName = "Juice",
                    ProductPrice = 3.17,
                    Quantity = 103,
                    ProductCode ="161kjd",

                },
                new Products
                {
                    ProductName = "Cake",
                    ProductPrice = 19,
                    Quantity = 26,
                    ProductCode ="453hgk",

                }


            };

            _salesItems = new List<SalesItem>();




        }

        public void AddNewSale(Sales sales)
        {
            throw new NotImplementedException();
        }

        public void RemoveSaleProduct()
        {
            throw new NotImplementedException();
        }

        public string ShowAllSale()
        {
          throw new NotImplementedException();
        }

        public double GetSaleByDateRange(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public double GetSaleByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public string GetSaleByAmountRange(double minAmout, double maxAmout)
        {
            throw new NotImplementedException();
        }

        public double GetSaleByNumber(int numberOfsale)
        {
            throw new NotImplementedException();
        }

        public void AddNewProducts(Products product)
        {
            throw new NotImplementedException();
        }

        public string FindProductForChangeByCode(Products productCode)
        {
            throw new NotImplementedException();
        }

        public string ShowProductsByCategory(ProductCategory productCategory)
        {
            throw new NotImplementedException();
        }

        public double GetProductByAmountRange(double minPrice, double maxPrice)
        {
            throw new NotImplementedException();
        }

        public string SearchProductByName(string productName)
        {
            throw new NotImplementedException();
        }
    }
}