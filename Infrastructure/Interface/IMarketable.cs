using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructure.Enum;
using MyFirstProject.Infrastructure.Model;

namespace MyFirstProject.Infrastructure.Interface
{
        public interface IMarketable
       {
        List<Sales> Sales{ get; }

        List<Products> Products { get; }

        void AddNewSale(Sales sales);
        void RemoveSaleProduct(string numberOfsale);
        List<Sales>ShowAllSale();
        double GetSaleByDateRange(DateTime startDate, DateTime endDate);
        List<Sales> GetSaleByDate(DateTime date);
        double GetSaleByAmountRange(double minAmout, double maxAmout);
        double GetSaleByNumber(string numberOfsale);
        void AddNewProducts(Products product);
        void FindProductForChangeByCode(string productCode);
        List<Products> ShowProductsByCategory(ProductCategory productCategory);
        List<Products> GetProductByPriceRange(double minPrice, double maxPrice);
        List<Products> SearchProductByName(string productName);

       
        


    }
}
