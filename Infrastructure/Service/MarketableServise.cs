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

        // Summary:
        // Created default goods
        public MarketableServise()
        {
            _products = new List<Products>()
            {

               new Products
                {
                    ProductName = "onion",
                    ProductCode = "123",
                    ProductCategory = ProductCategory.Food,
                    ProductPrice = 1,
                    Quantity = 5


                }, new Products
                {
                    ProductName = "twix",
                    ProductCode = "054B",
                    ProductCategory = ProductCategory.Sweets,
                    ProductPrice = 8,
                    Quantity = 15


                }, new Products
                {
                    ProductName = "bonaqua",
                    ProductCode = "27C",
                    ProductCategory = ProductCategory.Beverages,
                    ProductPrice = 2,
                    Quantity = 50


                },
                                   };



            _salesItems = new List<SalesItem>()
            {
                    new SalesItem
                    {
                    QuantityItemsOfSold =4,
                    ProductItemsOfSold=_products.Find(p=>p.ProductCode=="123"),
                      NumberOfItem =1,
                    },
                     new SalesItem
                    {
                    QuantityItemsOfSold =5,
                    ProductItemsOfSold=_products.Find(p=>p.ProductCode=="054B"),
                    NumberOfItem =2,
                    },
                      new SalesItem
                    {
                    QuantityItemsOfSold =6,
                    ProductItemsOfSold=_products.Find(p=>p.ProductCode=="27C"),
                      NumberOfItem =3,
                    }
                    };

            _sales = new List<Sales>()
            {
                new Sales
                {
                    AmmountOfSale = 225,
                    DateOfSold = new DateTime (2020,10,01),
                    NumberOfSale = 1,
                   SalesItem=_salesItems.FindAll(s=>s.QuantityItemsOfSold==1)

                },


            };

        }

        public void AddNewProducts(Products product)
        {
            _products.Add(product);
        }

        public void RemoveSaleProduct(string code)
        {
            bool delete = _products.Exists(r => r.ProductCode == code);

            if (delete == true)
            {
                var del = _products.Find(p => p.ProductCode == code);

                _products.Remove(del);

                Console.WriteLine(" By selected product has been deleted");
            }

            else
            {

                Console.WriteLine("Product has not found");
            }









            //i/*f (products.ProductCode != code) throw new Exception("Has not found any product by this number for remove");*/
        }

        public List<Products> FindProductForChangeByCode(string code)
        {

            bool check = _products.Exists(p => p.ProductCode == code);

            if (check == true)
            {

                var cod = _products.FindAll(p => p.ProductCode == code);

                Console.WriteLine("Enter new name of the product");

                string name = Console.ReadLine();

                Console.WriteLine("Enter new price of the product");


                string priceInput = Console.ReadLine();

                double amount;

                while (!double.TryParse(priceInput, out amount))
                {
                    Console.WriteLine("Your should enter a digit!");

                    priceInput = Console.ReadLine();
                }


                Console.WriteLine("Enter new count of the product");

                string countInput = Console.ReadLine();

                int count;

                while (!int.TryParse(countInput, out count))
                {
                    Console.WriteLine("Your should enter a digit!");

                    countInput = Console.ReadLine();
                }


                Console.WriteLine("Enter new category of the product");

                int category;
                do
                {
                    Products products = new Products();
                    Console.WriteLine("Choose category for according to the desired product");

                    Console.WriteLine("0. Food");
                    Console.WriteLine("1. Beverages");
                    Console.WriteLine("2. Sweets");


                    string select = Console.ReadLine();

                    while (!int.TryParse(select, out category))
                    {

                        Console.WriteLine("You should enter a digit!: ");
                        select = Console.ReadLine();
                    }

                    switch (category)
                    {
                        case 0:
                            products.ProductCategory = ProductCategory.Food;
                            break;
                        case 1:
                            products.ProductCategory = ProductCategory.Beverages;
                            break;
                        case 2:
                            products.ProductCategory = ProductCategory.Sweets;
                            break;

                        default:
                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Your choise is wrong, please try again");
                            Console.WriteLine("--------------------------------");
                            break;
                    }


                } while (category > 2);

                Console.WriteLine("Product has been added");

                foreach (var prod in cod)
                {
                    prod.ProductName = name;
                    prod.ProductPrice = amount;
                    prod.Quantity = count;
                    prod.ProductCategory = (ProductCategory)category;
                    prod.ProductCode = code;
                }


            }

            else
            {

                Console.WriteLine("Product code is wrong");
            }
            return _products;
        }

        public List<Products> ShowAllProduct()
        {
            return _products;
        }

        public void ShowAllSale()
        {

            _salesItems.Count();


        }

        public List<Sales> GetSaleByDateRange(DateTime startDate, DateTime endDate)
        {
            bool date = _sales.Exists(p => p.DateOfSold >= startDate && p.DateOfSold <= endDate);

            var count = SalesItems.Select(s => s.QuantityItemsOfSold).FirstOrDefault();

            if (date == true)
            {
                var Date = _sales.FindAll(p => p.DateOfSold >= startDate && p.DateOfSold <= endDate);

                int i = 1;
              
                foreach (var item in Date)
                {

                    var table = new ConsoleTable("#", "Number", "Amount", "Quantity", "Date");

                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale.ToString("#.##"), count, item.DateOfSold.ToString("dd.MM.yyyy"));
                    i++;
                    table.Write();
                }
            }
            else
                    if (endDate < startDate)
            {
                if (endDate < startDate) throw new NotOrdinaryException("Not ordinary format,end date can not be higher than start date");
                        }


            else
            {
                Console.WriteLine("Has not any sales from " + startDate + " till " + endDate);
            }
            return _sales;
       
            }
       
        public List<Sales> GetSaleByDate(DateTime date)
        {
            bool Date = _sales.Exists(s => s.DateOfSold == date);

            if (Date == true) {

                var ddate = _sales.FindAll(s => s.DateOfSold == date);

                int i = 1;

                var count = SalesItems.Select(s => s.QuantityItemsOfSold).FirstOrDefault();

                foreach (var item in ddate)
                {

                    var table = new ConsoleTable("#", "Number", "Amount", "Quantity", "Date");

                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale, count, item.DateOfSold.ToString("dd.MM.yyyy"));

                    i++;

                    table.Write();

                    //if (date == null) throw new ArgumentNullException("Has not some sales");
                }
            }
            else
            {
                Console.WriteLine("Has not any sales on " + date);
            }
            return _sales;
        }

        public List<Sales> GetSaleByAmountRange(double minAmout, double maxAmout)
        {

            bool amount = _sales.Exists(p => p.AmmountOfSale >= minAmout && p.AmmountOfSale <= maxAmout);

            if (amount == true)
            {

                var Amount = _sales.FindAll(p => p.AmmountOfSale >= minAmout && p.AmmountOfSale <= maxAmout);

                int i = 1;

                var count = SalesItems.Select(s => s.QuantityItemsOfSold).FirstOrDefault();

                foreach (var item in Amount)
                {
                    var table = new ConsoleTable("#", "Number", "amount", "quantity", "date");


                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale.ToString("#.##"), count, item.DateOfSold);
                    i++;
                    table.Write();
                }
            }

            else if (minAmout > maxAmout)
            {
                Console.WriteLine("minimal value can not be exceed than maximal value");

                if (minAmout > maxAmout) throw new ValueExceedException("minimal value can not be exceed than maximal value");
            }


            else
            {
                Console.WriteLine("Has not any sales in range from " + minAmout + " till " + maxAmout);


            }


            return _sales;
        }

        public List<Sales> GetSaleByNumber(int numberOfsale)
        {
            bool num = _sales.Exists(s => s.NumberOfSale == numberOfsale);

            if (num == true)
            {
                var number = _sales.FindAll(s => s.NumberOfSale == numberOfsale);

                int i = 1;
              
                var count = SalesItems.Select(s => s.QuantityItemsOfSold).FirstOrDefault();

                foreach (var item in number)
                {

                    var table = new ConsoleTable("#", "Number", "amount", "quantity", "date");

                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale, count, item.DateOfSold.ToString("dd.MM.yyyy"));
                    i++;
                    table.Write();
                }
            }
            else
            {
                Console.WriteLine("Has not any sales by number - " + numberOfsale);


            }
            return _sales;
        }

       
        public List<Products> ShowProductsByCategory(ProductCategory productCategory)
        {
            bool show = _products.Exists(p => p.ProductCategory == productCategory);

            if (show == true)
            {
                List<Products> category = _products.FindAll(p => p.ProductCategory == productCategory);

                foreach (var item in category)
                {
                    var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");

                    int i = 1;

                    table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);
                    i++;


                    table.Write();
                }
            }

            else
            {
                Console.WriteLine("Has not found any products by this category");
            }
            return _products;
        }

        public List<Products> GetProductByPriceRange(double minPrice, double maxPrice)
        {
            bool diff = _products.Exists(p => p.ProductPrice >= minPrice && p.ProductPrice <= maxPrice);

            if (diff == true) {

                List<Products> show = _products.FindAll(p => p.ProductPrice >= minPrice && p.ProductPrice <= maxPrice);

                int i = 1;
                foreach (var item in show)
                {
                    var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");


                    i++;
                    table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);

                    table.Write();
                }
            }
            else
            {
                Console.WriteLine("Not found any products by this price range");
            }
            return _products;
        }

        public List<Products> SearchProductByName(string text)
        {
            bool name = _products.Exists(p => p.ProductName == text || p.ProductName.Contains(text));

            if (name == true) {

                var tekst = _products.FindAll(p => p.ProductName == text || p.ProductName.Contains(text));

                foreach (var item in tekst)
                {
                    var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");

                    int i = 1;

                    table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);
                    i++;


                    table.Write();
                }
            }
            else
            {
                Console.WriteLine("Has not found the product with consist - " + text);
            }
            return _products;



        }

        

        public void RemoveSale(int number)
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

            var kod = code;

            bool checking = _products.Exists(p => p.ProductCode == code);

            if (checking == false)
            {

                Console.WriteLine("Product could not found");
            }
            else
            {
                saleItem.QuantityItemsOfSold = count;

                if (product.Quantity < count)
                {

                    Console.WriteLine("Has not enough quantity of product");

                }
                else
                {
                    product.Quantity -= count;

                    saleItem.ProductItemsOfSold = product;

                    saleItem.QuantityItemsOfSold = SalesItems.Count + 1;

                    SalesItems.Add(saleItem);

                    amount += count * saleItem.ProductItemsOfSold.ProductPrice;

                    var saleNo = _sales.Count + 1;

                    var saleDate = DateTime.Now;

                    var sale = new Sales();

                    sale.NumberOfSale = saleNo;

                    sale.AmmountOfSale = amount;

                    sale.DateOfSold = saleDate;

                    _sales.Add(sale);
               Console.WriteLine("--------------- New sales is added ----------------");
                }

                
            }
            }
       
        public double RemoveSaleby3Param(int no, string code, int count)
            {

                SalesItem salesItems = new SalesItem();

                Sales sales = new Sales();

                Products products = new Products();

                double amount = 0;

                var Lprod = _products.ToList();

                var Lsale = _sales.ToList();

                bool checkNumber = _sales.Exists(s => s.NumberOfSale == no);

                if (checkNumber == false)
                {

                    Console.WriteLine("Has not any sales by this number");
                }
                else
                {
                    var sale = Lsale.Find(r => r.NumberOfSale == no);

                    bool checkProdNumber = Lprod.Exists(p => p.ProductCode == code);

                    if (checkProdNumber == false)
                    {

                        Console.WriteLine("Has not found");
                    }
                    else
                    {
                        var list = Lprod.Find(r => r.ProductCode == code);

                        if (sale.AmmountOfSale > list.ProductPrice * count)
                        {
                            sale.AmmountOfSale -= list.ProductPrice * count;
                        }
                        else if (sale.AmmountOfSale == list.ProductPrice * count)
                        {
                            _sales.Remove(sale);

                        Console.WriteLine("Sales has been removed");
                        }
                        else
                        {

                            Console.WriteLine("Has not that quantity of sales, please try again");
                        }
                    }

                }
                return amount;

            }

        }
    }


