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
        void RemoveSaleProduct();
        string ShowAllSale();
        double GetSaleByDateRange(DateTime startDate, DateTime endDate);
        double GetSaleByDate(DateTime date);
        string GetSaleByAmountRange(double minAmout, double maxAmout);
        double GetSaleByNumber(int numberOfsale);
        void AddNewProducts(Products product);
        string FindProductForChangeByCode(Products productCode);
        string ShowProductsByCategory(ProductCategory productCategory);
        double GetProductByAmountRange(double minPrice, double maxPrice);
        string SearchProductByName(string productName);

       
        


    }
}
