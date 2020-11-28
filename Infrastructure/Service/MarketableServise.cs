using MyFirstProject.Infrastructure.Enum;
using MyFirstProject.Infrastructure.Interface;
using MyFirstProject.Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleTables;
using MyFirstProject.Infrastructure.Exceptions;

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
            _products = new List<Products>()
            {

               new Products
                {
                    ProductName = "onion",
                    ProductCode = "123",
                    ProductCategory = ProductCategory.Food,
                    ProductPrice = 20,
                    Quantity = 5


                },
                                   };



            _salesItems = new List<SalesItem>()
            {
                    new SalesItem
                    {
                    QuantityItemsOfSold =1,
                    ProductItemsOfSold=_products.Find(p=>p.ProductCode=="123"),
                      NumberOfItem ="1",
                    }
                    };

            _sales = new List<Sales>()
            {
                new Sales
                {
                    AmmountOfSale = 225,
                    DateOfSold = new DateTime (2020,10,01),
                    NumberOfSale = "15",
                   SalesItem=_salesItems.FindAll(s=>s.QuantityItemsOfSold==1)

                }
            };

        }


        public void RemoveSaleProduct(string code)
        {
            Products products = new Products();

            var resultlist = _products.ToList();


            Console.WriteLine(" By selected product has been deleted");


            var delete = resultlist.Find(r => r.ProductCode == code);


            _products.Remove(delete);


            //i/*f (products.ProductCode != code) throw new Exception("Has not found any product by this number for remove");*/
        }

        public void ShowAllSale()
        {

            _salesItems.Count();


        }

        public List<Sales> GetSaleByDateRange(DateTime startDate, DateTime endDate)
        {
            return _sales.Where(p => p.DateOfSold >= startDate && p.DateOfSold <= endDate).ToList();

        }
        public List<Sales> GetSaleByDate(DateTime date)
        {
            return _sales.Where(s => s.DateOfSold == date).ToList();
        }

        public List<Sales> GetSaleByAmountRange(double minAmout, double maxAmout)
        {

            return _sales.Where(p => p.AmmountOfSale >= minAmout && p.AmmountOfSale <= maxAmout).ToList();

        }

        public List<Sales> GetSaleByNumber(string numberOfsale)
        {


            return _sales.Where(s => s.NumberOfSale == numberOfsale).ToList();

            throw new SaleNotFoundExp(string.Format("Sale by number {0} not found", numberOfsale));
        }

        public void AddNewProducts(Products product)
        {
            _products.Add(product);
        }

        public List<Products> FindProductForChangeByCode(string code)
        {

            var list = _products.FindAll(p => p.ProductCode == code).ToList();

            return _products;
        }

        public List<Products> ShowProductsByCategory(ProductCategory productCategory)
        {
            var list = _products.ToList();

            var show = list.FindAll(p => p.ProductCategory == productCategory);

            foreach (var item in show)
            {
                var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");

                int i = 1;

                table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);
                i++;


                table.Write();

            }
            return Products;


        }

        public List<Products> GetProductByPriceRange(double minPrice, double maxPrice)
        {


            return _products.FindAll(p => p.ProductPrice >= minPrice && p.ProductPrice <= maxPrice).ToList();
        }

        public List<Products> SearchProductByName(string text)
        {
            Products products = new Products();

            var list = _products.ToList();

            var show = list.FindAll(p => p.ProductName == text || p.ProductName.Contains(text));

            foreach (var item in show)
            {
                var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");

                int i = 1;

                table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);
                i++;


                table.Write();

            }
            return Products;



        }

        public List<Products> ShowAllProduct()
        {
            return _products;
        }

        public void RemoveSale(string number)
        {


            bool yoxla = _sales.Exists(s => s.NumberOfSale == number);

            if (yoxla == true)
            {
                var sale = _sales.Find(s => s.NumberOfSale == number);

                _sales.Remove(sale);

                Console.WriteLine("Has been deleted");
            }
            else
            {

                Console.WriteLine("This number is not found");
                throw new SaleNotFoundExp(string.Format("Sale by number {0} not found", number));

            }


        }

        public void AddNewSale(string code, int count)
        {
            List<Products> products = new List<Products>();

            List<SalesItem> items = new List<SalesItem>();

            double amount = 0;

            var product = _products.Where(p => p.ProductCode == code).FirstOrDefault();

            var saleItem = new SalesItem();

            saleItem.QuantityItemsOfSold = count;

            saleItem.ProductItemsOfSold = product;

            saleItem.QuantityItemsOfSold = SalesItems.Count + 1;

            SalesItems.Add(saleItem);

            amount += count * saleItem.ProductItemsOfSold.ProductPrice;

            count = saleItem.QuantityItemsOfSold;

            var saleNo = _sales.Count + 1;

            var saleDate = DateTime.Now;

            var sale = new Sales();

            sale.NumberOfSale = "123";

            sale.AmmountOfSale = amount;

            sale.DateOfSold = saleDate;

            sale.SalesItem = items;

            _sales.Add(sale);



















        }

        public void RemoveSaleby2Param(string code, int count)
        {
            //    Sales sales = new Sales();

            //    double amount = 0;

            //    int DeleteIndex = -1;

            //    //for (int i = 0; i < sales.SalesItem.Count; i++)

            //    //{
            //    //    var saleItem = sales.SalesItem[i];
            //    SalesItem saleItem = new SalesItem();

            //    if (code == saleItem.ProductItemsOfSold.ProductCode)
            //    {
            //        amount = saleItem.ProductItemsOfSold.ProductPrice * count;

            //        if (saleItem.QuantityItemsOfSold > count)
            //        {
            //            saleItem.QuantityItemsOfSold -= count;
            //        }
            //        else if (saleItem.QuantityItemsOfSold == count)
            //        {
            //            saleItem.QuantityItemsOfSold = 1;
            //        }
            //        else
            //        {
            //            throw new QuantityExceededException(string.Format("There is no enough quantity {0} of products  ", count));
            //        }
            //    }
            //    //}
            //    sales.AmmountOfSale -= amount;
            //    if (DeleteIndex >= 0)
            //    {
            //        sales.SalesItem.RemoveAt(DeleteIndex);
            //    }
            //    return amount;
            //}

            bool yoxla = _salesItems.Exists(s => s.NumberOfItem == code && s.QuantityItemsOfSold >= count);

            if (yoxla == true)
            {
                var sale = _salesItems.Find(s => s.NumberOfItem == code && s.QuantityItemsOfSold >= count);

                _salesItems.Remove(sale);

                Console.WriteLine("Has been deleted");
            }

            else
            {

                Console.WriteLine("This number is not found");
                //throw new SaleNotFoundExp(string.Format("Sale by number {0} not found", number));

            }

        }

    }
}

