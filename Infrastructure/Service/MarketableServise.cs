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

        public void RemoveSaleProduct(string numberOfsale)
        {
            _sales.RemoveAt(1);
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

        public List<Products> ShowAllProduct()
        {
            return _products;
        }
    }
}