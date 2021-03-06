﻿using System;
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
        void AddNewProducts(Products product);
        public void RemoveSale(int numberofSale);
        public double RemoveSaleby3Param(int no, string code, int count);
        List<Products> ShowAllProduct();
        List<Sales> GetSaleByDateRange(DateTime startDate, DateTime endDate);
        List<Sales> GetSaleByDate(DateTime date);
        List<Sales> GetSaleByAmountRange(double minAmout, double maxAmout);
        List<Sales> GetSaleByNumber(int number);
        List<Products> FindProductForChangeByCode(string code);
        List<Products> ShowProductsByCategory(ProductCategory productCategory);
        List<Products> GetProductByPriceRange(double minPrice, double maxPrice);
        List<Products> SearchProductByName(string productName);

      







    }
}
