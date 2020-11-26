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

        void AddNewSale(string code,int count);
        void RemoveSaleProduct(string code);
        void ShowAllSale();

        List<Products> ShowAllProduct();
        double GetSaleByDateRange(DateTime startDate, DateTime endDate);
        double GetSaleByDate(DateTime date);
        double GetSaleByAmountRange(double minAmout, double maxAmout);
        double GetSaleByNumber(string numberOfsale);
        void AddNewProducts(Products product);
        List<Products> FindProductForChangeByCode(string code);
        List<Products> ShowProductsByCategory(ProductCategory productCategory);
        List<Products> GetProductByPriceRange(double minPrice, double maxPrice);
        List<Products> SearchProductByName(string productName);

        public void RemoveSale(string numberofSale);



       
        


    }
}
