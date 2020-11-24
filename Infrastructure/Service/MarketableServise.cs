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
            _sales = new List<Sales>();

            _products = new List<Products>();




        }
    

            


        public void AddNewSale(Sales sales)
        {
            Products products = new Products();
            Sales sale = new Sales();
            
           
            _sales.Add(sales);

        }

        public void RemoveSaleProduct(int index)
        {
            _sales.RemoveAt(index);
        }

        public List <Sales> ShowAllSale()
        {

            Sales sale = new Sales();
           
            Products products = new Products();

            
            

            return  _sales;
        }

        public double GetSaleByDateRange(DateTime startDate, DateTime endDate)
        {
            Sales sale = new Sales();
            
            Products products = new Products();
         
            sale.AmmountOfSale = products.ProductPrice * products.Quantity;
          
            return  _sales.Where(s => s.DateOfSold >= startDate && s.DateOfSold <= endDate).Sum(s => s.AmmountOfSale);
        }

        public double GetSaleByDate(DateTime date)
        {
            return _sales.Where(s => s.DateOfSold == date).Count();
        }

        public double GetSaleByAmountRange(double minAmout, double maxAmout)
        {
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

        public void FindProductForChangeByCode(Products product)
        {
            _products.Add(product);
        }

        public List<Products> ShowProductsByCategory(ProductCategory productCategory)
        {
          return _products;
        }

        public List<Products> GetProductByPriceRange(double minPrice, double maxPrice)
        {
            return _products;
        }

        public List<Products> SearchProductByName(string productName)
        {
            return _products;
        }

        public List<Products> ShowAllProduct()
        {
            return _products;
        }

        public void RemoveSale(int index)
        {
            _sales.RemoveAt(index);
        }
    }
}