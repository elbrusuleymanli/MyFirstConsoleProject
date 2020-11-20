using System;
using System.Collections.Generic;
using System.Text;
using MyFirstProject.Infrastructure.Model;

namespace MyFirstProject.Infrastructure.Interface
{
    class IMarketable
    {
       List<Sales> Sales  { get; set; }
       List<Products> Products { get; set; }
       void AddSale(string productName,double productQuantity,double productPrice)
        {

        }
       void GetSoldProduct()
        {


        } 
    
        void GetTotalSoldProduct()
        {

        }
        void GetProductByRangeDate(DateTime startDate,DateTime endDate)
        {

        }
        void TotalSoldProductsByRangeDate(DateTime startDate, DateTime endDate)
        {

        }
        void SoldProductsByDate(DateTime date)
        {

        }
        
        void GetSoldProductsByRangeAmmount(double minAmmount,double maxAmmount)
        {

        }
        void RemoveSalesBySoldNumber(string numberOfSold)
        {

        }
        void AddNewProduct()
        {

        }
        

    
    
    }
}
