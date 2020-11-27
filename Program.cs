using System;
using System.Text;
using MyFirstProject.Infrastructure.Enum;
using MyFirstProject.Infrastructure.Model;
using MyFirstProject.Infrastructure.Service;
using ConsoleTables;
using System.Collections.Generic;

namespace MyFirstProject
{
    class Program
    {
        private static MarketableServise _marketableServise = new MarketableServise();

        // Summary:
        // Created new consol table
        static void Main(string[] args)
        {
            int select;

            do
            {

                Console.WriteLine("==========Manage Sales and Products==========");
                Console.WriteLine("                                                       ");
                Console.WriteLine("==========================MENU=========================");
                Console.WriteLine("1. Carry out operations on products");
                Console.WriteLine("2. Carry out operations on sales");
                Console.WriteLine("3. Leave out");

                Console.WriteLine("========================================================");
                Console.WriteLine("Make your choose :");

                string choose = Console.ReadLine();


                while (!int.TryParse(choose, out select))
                {

                    Console.WriteLine("Rəqəm daxil etməlisiniz!");

                    choose = Console.ReadLine();

                }

                switch (select)
                {
                    case 1:


                        Console.WriteLine("0. Back to MENU");
                        Console.WriteLine("1. Add new product");
                        Console.WriteLine("2. Carry out edit on products");
                        Console.WriteLine("3. Remove product");
                        Console.WriteLine("4. Show all products");
                        Console.WriteLine("5. Show products by category");
                        Console.WriteLine("6. Show products by price range");
                        Console.WriteLine("7. Search by name among products");
                        FirstCase();


                        break;

                    case 2:
                        Console.WriteLine("0. Back to MENU");
                        Console.WriteLine("1. Add new sales");
                        Console.WriteLine("2. Return any product on sales");
                        Console.WriteLine("3. Remove sales");
                        Console.WriteLine("4. Show all sales(number,amount,product quantity,date)");
                        Console.WriteLine("5. Get sales by date range");
                        Console.WriteLine("6. Get sales by amount range");
                        Console.WriteLine("7. Show sales within the given date");
                        Console.WriteLine("8. Show sale details by according to the given number");
                        SecondCase();
                        break;

                    case 3:
                        Console.WriteLine("=============THANK YOU FOR USED THE SYSTEM=============");
                        break;

                    default:

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("You made wrong choise,you should choose 1-3 ");
                        Console.WriteLine("--------------------------------");
                        break;

                }
            } while (select != 3);




            Console.WriteLine("==============================================================================");
        }
        // Summary:
        // Created switch method for choise first option 
        static void FirstCase()
        {

            int SecondSelect;
            Console.WriteLine("==============================================================================");
            Console.WriteLine("Which operations you wanna make?");
            Console.WriteLine("==============================================================================");

            do
            {



                string Choose1 = Console.ReadLine();



                while (!int.TryParse(Choose1, out SecondSelect))
                {

                    Console.WriteLine("You should enter digit!");

                    Choose1 = Console.ReadLine();
                }






                switch (SecondSelect)
                {
                    case 0:
                        continue;


                    case 1:

                        Console.WriteLine("1. Add new product");
                        Console.WriteLine("============================================================");
                        AddNewProduct();

                        break;
                    case 2:

                        Console.WriteLine("2. Carry out edit on products");
                        Console.WriteLine("============================================================");
                        EditCurrentProduct();
                        break;

                    case 3:

                        Console.WriteLine("3. Remove product ");
                        Console.WriteLine("==============================================================================");
                        RemoveProductByCode();
                        break;

                    case 4:

                        Console.WriteLine("4. Show all products");
                        Console.WriteLine("==============================================================================");
                        ShowAllProducts();
                        break;

                    case 5:
                        Console.WriteLine("5. Show products by category ");
                        Console.WriteLine("==============================================================================");
                        ShowProductsByCategory();
                        break;

                    case 6:

                        Console.WriteLine("6. Show products by price range");
                        Console.WriteLine("==============================================================================");
                        GetProductsByPriceRange();
                        break;

                    case 7:
                        Console.WriteLine("7. Search by name among products");
                        Console.WriteLine("==============================================================================");
                        SearchProductByName();
                        break;

                    default:

                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("You made wrong choise,you should choose 1-7");
                        Console.WriteLine("-------------------------------------------");
                        break;


                }


            } while (SecondSelect != 0);
        }
        // Summary:
        // Method created for add new product
        // Exception:
        // Category can not convert to any symbols
        static void AddNewProduct()
        {
            Products products = new Products();

            ProductCategory category;

            Console.WriteLine("Choose the category of the product ");

            Console.WriteLine("1. Beverages");
            Console.WriteLine("2. Food");
            Console.WriteLine("3. Sweets");



            category = (ProductCategory)int.Parse(Console.ReadLine());

            if ((int)category == 0 || (int)category > 3) throw new Exception("Your choise should be up to 3");

            switch (category)
            {

                case (ProductCategory)1:
                    products.ProductCategory = ProductCategory.Beverages;
                    break;

                case (ProductCategory)2:
                    products.ProductCategory = ProductCategory.Food;
                    break;

                case (ProductCategory)3:
                    products.ProductCategory = ProductCategory.Sweets;
                    break;
                default:
                    Console.WriteLine("Please, try again");
                    break;
            }


            Console.WriteLine("Enter the name of the product:");

            string name = Console.ReadLine();

            products.ProductName = name;


            Console.WriteLine("Enter the price of the product :");

            string priceInput = Console.ReadLine();

            double price;

            while (!double.TryParse(priceInput, out price))
            {
                Console.WriteLine("Your should enter a digit!");

                priceInput = Console.ReadLine();
            }

            products.ProductPrice = price;

            Console.WriteLine("Enter the number of product");

            products.ProductCode = Console.ReadLine();


            Console.WriteLine("Enter the qunatity of the product");

            string quantityInput = Console.ReadLine();


            int quantity;

            while (!int.TryParse(quantityInput, out quantity))
            {
                Console.WriteLine("Your should enter a digit!");

                quantityInput = Console.ReadLine();

            }
            products.Quantity = quantity;



            Console.WriteLine("Product is added");



            _marketableServise.AddNewProducts(products);

        }
        // Summary:
        // Method created for edit current product
        static void EditCurrentProduct()
        {
            Products products = new Products();

            Sales sale = new Sales();

            SalesItem salesItem = new SalesItem();


            Console.WriteLine("Enter code of product for search");

            string code = Console.ReadLine();

            List<Products> list = _marketableServise.FindProductForChangeByCode(code);

            foreach (var item in list)
            {
                if (item.ProductCode == code)
                {

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

                    products.ProductPrice = amount;

                    sale.AmmountOfSale = +products.ProductPrice;

                    Console.WriteLine("Enter new count of the product");

                    string countInput = Console.ReadLine();

                    int count;

                    while (!int.TryParse(countInput, out count))
                    {
                        Console.WriteLine("Your should enter a digit!");

                        countInput = Console.ReadLine();
                    }

                    products.Quantity = count;

                    salesItem.QuantityItemsOfSold = +products.Quantity;


                    Console.WriteLine("Enter new category of the product");

                    Console.WriteLine("1. Beverages");
                    Console.WriteLine("2. Food");
                    Console.WriteLine("3. Sweets");

                    ProductCategory category = (ProductCategory)int.Parse(Console.ReadLine());

                    if ((int)category == 0 || (int)category > 3) throw new Exception("Your choise should be up to 3");

                    if (category == ProductCategory.Beverages)
                    {
                        category = ProductCategory.Beverages;
                    }
                    else if (category == ProductCategory.Food)
                    {
                        category = ProductCategory.Food;

                    }
                    else if (category == ProductCategory.Sweets)
                    {
                        category = ProductCategory.Sweets;

                    }
                    else
                    {
                        Console.WriteLine("You made wrong choise");
                    }

                    Console.WriteLine("Enter new code of the product");

                    string cod = Console.ReadLine();

                    products.ProductCode = cod;

                    Console.WriteLine("Product has been added");

                    foreach (var prod in list)
                    {
                        prod.ProductName = name;
                        prod.ProductPrice = amount;
                        prod.Quantity = count;
                        prod.ProductCategory = category;
                        prod.ProductCode = cod;
                    }

                }

                if (products.ProductCode != code)
                {
                    Console.WriteLine("is not found");

                }
            }
        }
        // Summary:
        // Method created for remove current product by code
        static void RemoveProductByCode()
        {
            Console.WriteLine("Enter code of product for remove");

            string code = Console.ReadLine();



            _marketableServise.RemoveSaleProduct(code);

        }
        // Summary:
        // Method created for show all products 
        static void ShowAllProducts()
        {
            Console.WriteLine("-------------- CURRENT PRODUCTS --------------");

            var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");

            int i = 1;
            foreach (var item in _marketableServise.Products)
            {

                table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);
                i++;

            }
            table.Write();

            _marketableServise.ShowAllProduct();

        }
        // Summary:
        // Method created for show all products by category
        static void ShowProductsByCategory()

        {

            Products products = new Products();

            int selectInt;
            do
            {
                #region Product Category Menu 
                Console.WriteLine("Choose category for according to the desired product");

                Console.WriteLine("0. Food");
                Console.WriteLine("1. Beverages");
                Console.WriteLine("2. Sweets");
                #endregion


                Console.WriteLine("");
                Console.WriteLine("Make your choise");
                string select = Console.ReadLine();

                while (!int.TryParse(select, out selectInt))
                {
                    Console.WriteLine("");
                    Console.Write("You should enter a digit!: ");
                    select = Console.ReadLine();
                }

                switch (selectInt)
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


            } while (selectInt == 3);

            _marketableServise.ShowProductsByCategory((ProductCategory)selectInt);

        }
        // Summary:
        // Method created for searching among products by category
        // Exception:
        // Method has some exceptions one of them it is difference between min and max value
        static void GetProductsByPriceRange()
        {

            Console.WriteLine("Choose price range of products what you wanna see");

            Console.WriteLine("Enter minimal value");

            string input = Console.ReadLine();

            double Minprice;

            while (!double.TryParse(input, out Minprice))
            {
                Console.WriteLine("You should enter a digit");

                input = Console.ReadLine();
            }

            Console.WriteLine("Enter maximal value");


            string input2 = Console.ReadLine();

            double Maxprice;

            while (!double.TryParse(input2, out Maxprice))
            {
                Console.WriteLine("You should enter a digit");

                input2 = Console.ReadLine();
            }


            if (Minprice > Maxprice) throw new Exception("Minimal value too much than maximal value");


            var list = _marketableServise.GetProductByPriceRange(Minprice, Maxprice);

            int i = 1;
            foreach (var item in list)
            {
                var table = new ConsoleTable("#", "Name", "Price", "Category", "Quantuty", "Code");


                i++;
                table.AddRow(i, item.ProductName, item.ProductPrice, item.ProductCategory, item.Quantity, item.ProductCode);

                table.Write();

            }

        }
        // Summary:
        // Method created for searching among products by name
        // Exception:
        // Method has can not found exceptions 
        static void SearchProductByName()
            {

                Console.WriteLine("Enter text");
                try
                {

                    string text = Console.ReadLine();

                    var list = _marketableServise.SearchProductByName(text);

                }
                catch (KeyNotFoundException e)
                {

                    Console.WriteLine("Can not found");
                }
                    
            }
        // Summary:
        // Created switch method for choise second option 
        static void SecondCase()
            {
                int SSelect;

                Console.WriteLine("Which operations you wanna make?");
                Console.WriteLine("==============================================================================");
                do
                {

                    string Choise1 = Console.ReadLine();



                    while (!int.TryParse(Choise1, out SSelect))
                    {

                        Console.WriteLine("You should enter digit!");

                        Choise1 = Console.ReadLine();
                    }





                    switch (SSelect)
                    {
                        case 0:
                            continue;


                        case 1:

                            Console.WriteLine("1. Add new sales");
                            Console.WriteLine("==============================================================================");
                            AddNewSales();
                            break;
                        case 2:

                            Console.WriteLine("2. Return any product on sales");
                            Console.WriteLine("==============================================================================");
                            RemoveSoldProduct();
                            break;

                        case 3:

                            Console.WriteLine("3.Remove sales ");
                            Console.WriteLine("==============================================================================");
                            RemoveSold();
                            break;

                        case 4:

                            Console.WriteLine("4.Show all sales(number,amount,product quantity,date)");
                            Console.WriteLine("===========================================================================");
                            ShowAllSales();
                            break;

                        case 5:
                            Console.WriteLine("5. Get sales by date range ");
                            Console.WriteLine("===========================================================================");
                            GetSalesByDateRange();
                            break;

                        case 6:

                            Console.WriteLine("6. Get sales by amount range");
                            Console.WriteLine("==============================================================================");
                            GetSalesByAmmountRange();
                            break;

                        case 7:
                            Console.WriteLine("7. Show sales within the given date");
                            Console.WriteLine("===========================================================================");
                            GetSalesByDate();

                            break;

                        case 8:
                            Console.WriteLine("8. Show sale details by according to the given number");
                            Console.WriteLine("==============================================================================");
                            GetSalesByNumber();
                            break;


                        default:

                            Console.WriteLine("-------------------------------------------");
                            Console.WriteLine("You made wrong choise,you should choose 1-8");
                            Console.WriteLine("-------------------------------------------");
                            break;





                    }


                } while (SSelect != 0);

            }      

            static void AddNewSales()
            {



                Console.WriteLine("Enter the code of the product");

                string code = Console.ReadLine();
                SalesItem salesItem = new SalesItem();
                Console.WriteLine("Enter the count of the product of sold");
                int count;
                string input = Console.ReadLine();

                while (!int.TryParse(input, out count))
                {
                    Console.WriteLine("You should enter a digit");

                    input = Console.ReadLine();
                }



                _marketableServise.AddNewSale(code, count);





                Console.WriteLine("--------------- New sales is added ----------------");





            }       // delay

            static void RemoveSoldProduct()

            {

                Console.WriteLine("------------satisin legv olunmasi----------------");

                Console.WriteLine("Legv etmek ucun mehsulun kodunu daxil edin");

                string nameinput = Console.ReadLine();

                Console.WriteLine("Legv etmek ucun mehsulun sayini daxil edin");

                string countIn = Console.ReadLine();

                int count;

                while (!int.TryParse(countIn, out count))
                {
                    Console.WriteLine("reqem daxil edin");

                    countIn = Console.ReadLine();
                }





                _marketableServise.RemoveSold(nameinput, count);





            }

            static void RemoveSold()
            {

                  Console.WriteLine("Enter sale number");


                  string number = Console.ReadLine();

                  Console.WriteLine("Enter sale count");
                
                  string countInput = Console.ReadLine();

                  int count;

                  while (!int.TryParse(countInput, out count))
            {
                  Console.WriteLine("Your should enter a digit!");

                  countInput = Console.ReadLine();
            }


           


                _marketableServise.RemoveSold(number, count);
            }
        // Summary:
        // Method created for show all sales
        static void ShowAllSales()
            {

                Console.WriteLine("-------------- CURRENT SALES --------------");


                var table = new ConsoleTable("#", "Number", "Amount", "Quantity", "data");

                int i = 1;



                foreach (var item in _marketableServise.Sales)
                {

                    Sales sales = new Sales();

                    List<SalesItem> salesItem = new List<SalesItem>();





                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale, item.SalesItem.Count, item.DateOfSold.ToString("dd.MM.yyyy"));
                    i++;

                }
                table.Write();

                _marketableServise.ShowAllSale();

            }
        // Summary:
        // Method created for searching among sales by date
        // Exception:
        // Method has NULL exception
        // Method has format exception
        static void GetSalesByDateRange()

            {

                Console.WriteLine("-------------- Show sales by date range --------------");


                Console.WriteLine("Enter start date");

            DateTime start;

            string fake = Console.ReadLine();

            while (!DateTime.TryParse(fake,out start))
            {
                Console.WriteLine("Please,enter correct format of date time");
                
                fake = Console.ReadLine();
            }

                Console.WriteLine("Enter end date");

            DateTime end;
           
            string fake1 = Console.ReadLine();

            while (!DateTime.TryParse(fake1, out end))
            {
                Console.WriteLine("Please,enter correct format of date time");

                fake1 = Console.ReadLine();
            }


            var list = _marketableServise.GetSaleByDateRange(start, end);
                int i = 1;
                foreach (var item in list)
                {


                    var table = new ConsoleTable("#", "Number", "amount", "quantity", "date");



                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale.ToString("#.##"), item.SalesItem.Count, item.DateOfSold.ToString("dd.MM.yyyy"));
                    i++;
                    table.Write();
                }
 
            }
        // Summary:
        // Method created for searching among sales by amount
        // Exception:
        // Method has NULL exception
        // Method has difference disordinnary value exception
        static void GetSalesByAmmountRange()
            {

                Console.WriteLine("-------------- Show sales by amount range --------------");


                Console.WriteLine("Enter minimal value");

                string minAmount = (Console.ReadLine());

                double min;

                while (!double.TryParse(minAmount, out min))
                {

                    Console.WriteLine("You should enter a digit!");

                    minAmount = Console.ReadLine();
                }

                Console.WriteLine("Enter maximal value ");

                string maxAmmout = (Console.ReadLine());

                double max;

                while (!double.TryParse(maxAmmout, out max))
                {
                    Console.WriteLine("You should enter a digit!");

                    maxAmmout = (Console.ReadLine());
                }
                var list = _marketableServise.GetSaleByAmountRange(min, max);
                int i = 1;
                foreach (var item in list)
                {


                    var table = new ConsoleTable("#", "Number", "amount", "quantity", "date");



                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale, item.SalesItem.Count, item.DateOfSold);
                    i++;
                    table.Write();
                }
            if (min > max) throw new Exception("minimal value can not be more than maximal value");
                   }
        // Summary:
        // Method created for searching among sales by select date
        // Exception:
        // Method has NULL exception
        // Method has format exception
        // Method has not found exception
        static void GetSalesByDate()
            {

                Console.WriteLine(" Enter start date");

                string DateInput = Console.ReadLine();

                DateTime date;

                while (!DateTime.TryParse(DateInput, out date))
                {
                    Console.WriteLine("Please, enter correct format of date time!");

                    DateInput = Console.ReadLine();
                }

                List<Sales> list = _marketableServise.GetSaleByDate(date);

                int i = 1;

                foreach (var item in list)
                {

                    var table = new ConsoleTable("#", "Number", "amount", "quantity", "date");

                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale, item.SalesItem.Count, item.DateOfSold.ToString("dd.MM.yyyy"));
                    i++;
                    table.Write();
                
                     if (date == null) throw new ArgumentNullException("Has not some sales");
            }
           }



            static void GetSalesByNumber()
            {

                Console.WriteLine("satis nomresini daxil edin");

                string no = Console.ReadLine();


                List<Sales> list = _marketableServise.GetSaleByNumber(no);

                int i = 1;

                foreach (var item in list)
                {



                    var table = new ConsoleTable("#", "Number", "amount", "quantity", "date");



                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale, item.SalesItem.Count, item.DateOfSold.ToString("dd.MM.yyyy"));
                    i++;
                    table.Write();
                }


            }




        }
    


    }





























        


    





