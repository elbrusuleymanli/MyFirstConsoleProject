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
        List<Sales> GetSaleByDateRange(DateTime startDate, DateTime endDate);
        List<Sales> GetSaleByDate(DateTime date);
        List<Sales> GetSaleByAmountRange(double minAmout, double maxAmout);
        List<Sales> GetSaleByNumber(string number);
        void AddNewProducts(Products product);
        List<Products> FindProductForChangeByCode(string code);
        List<Products> ShowProductsByCategory(ProductCategory productCategory);
        List<Products> GetProductByPriceRange(double minPrice, double maxPrice);
        List<Products> SearchProductByName(string productName);

        public void RemoveSale(string numberofSale);

        public double RemoveSaleby3Param(string no,string code,int count);







    }
}
