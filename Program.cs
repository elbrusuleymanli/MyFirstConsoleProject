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


        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;




            int select;

            do
            {

                Console.WriteLine("==========SATIŞ VƏ MƏHSULLARIN İDARƏ EDİLMƏSİ==========");
                Console.WriteLine("                                                       ");
                Console.WriteLine("==========================MENU=========================");
                Console.WriteLine("1. Məhsullar üzərində əməliyyat aparmaq");
                Console.WriteLine("2. Satışlar üzərində əməliyyat aparmaq");
                Console.WriteLine("3. Sistemdən çıxmaq");

                Console.WriteLine("========================================================");
                Console.WriteLine("Seçiminizi edin :");

                string choose = Console.ReadLine();


                while (!int.TryParse(choose, out select))
                {

                    Console.WriteLine("Rəqəm daxil etməlisiniz!");

                    choose = Console.ReadLine();

                }

                switch (select)
                {
                    case 1:


                        Console.WriteLine("0. Yenidən MENU-ya qayıymaq");
                        Console.WriteLine("1. Yeni məhsul elave et");
                        Console.WriteLine("2. Məhsul üzərində düzəliş et");
                        Console.WriteLine("3. Məhsulu sil");
                        Console.WriteLine("4. Bütün məhsullari göstər");
                        Console.WriteLine("5. Kateqoriyasına görə məhsulları göstər ");
                        Console.WriteLine("6. Qiymət aralığına görə məhsullari göster");
                        Console.WriteLine("7. Məhsullar arasında ada görə axtarış et");
                        FirstCase();


                        break;

                    case 2:
                        Console.WriteLine("0. Yenidən MENU-ya qayıymaq");
                        Console.WriteLine("1. Yeni satış əlavə etmək");
                        Console.WriteLine("2. Satışdakı hansısa məhsulun geri qaytarılması(satışdan cıxarılması)");
                        Console.WriteLine("3. Satışın silinməsi");
                        Console.WriteLine("4. Bütün satışlarn ekrana çıxarılması(nömrəsi,məbləği,məhsul sayı,tarixi)");
                        Console.WriteLine("5. Verilən tarix aralığına görə satışların göstərilməsi");
                        Console.WriteLine("6. Verilən məbləğ aralığına görə satışların göstərilməsi");
                        Console.WriteLine("7. Verilmiş bir tarixdə olan satışların göstərilməsi");
                        Console.WriteLine("8. Verilmiş nömrəyə əsasən həmin nömrəli satişın məlumatlarının göstərilməsi");
                        SecondCase();
                        break;

                    case 3:
                        Console.WriteLine("=============SİSTEMDƏN İSTİFADƏ ETDİYİNİZ ÜÇÜN TƏŞƏKKÜR EDİRİK=============");
                        break;

                    default:

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yanlış seçim etdiniz,1-3 arası seçim edə bilərsiniz");
                        Console.WriteLine("--------------------------------");
                        break;

                }
            } while (select != 3);




            Console.WriteLine("==============================================================================");
        }
        
            static void FirstCase()
            {

                int SecondSelect;
                
                Console.WriteLine("Hansı əməliyyatı etmək istədiyinizi seşin");
               
                do
                {



                    string Choose1 = Console.ReadLine();



                    while (!int.TryParse(Choose1, out SecondSelect))
                    {

                        Console.WriteLine("Rəqəm daxil etməlisiniz!");

                        Choose1 = Console.ReadLine();
                    }
                 

       



                    switch (SecondSelect)
                    {
                        case 0:
                            continue;


                        case 1:

                            Console.WriteLine("1. Yeni mehsulu əlavə et");
                            Console.WriteLine("============================================================");
                            AddNewProduct();

                            break;
                        case 2:

                            Console.WriteLine("2. Məhsul üzərində düzəliş et)");
                        Console.WriteLine("============================================================");
                        EditCurrentProduct();
                            break;

                        case 3:

                            Console.WriteLine("3. Məhsulu sil ");
                        RemoveProductByCode();
                            break;

                        case 4:

                            Console.WriteLine("4. Bütün məhsullari göstər");
                            ShowAllProducts();
                            break;

                        case 5:
                            Console.WriteLine("5. Kateqoriyasına görə məhsulları göstər ");
                        ShowProductsByCategory();
                            break;

                        case 6:

                            Console.WriteLine("6. Qiymət aralığına görə məhsullari göster");
                            GetProductsByPriceRange();
                            break;

                        case 7:
                            Console.WriteLine("7. Məhsullar arasında ada görə axtarış et");
                        SearchProductByName();
                            break;

                       default:

                            Console.WriteLine("--------------------------------");
                            Console.WriteLine("Siz yanlış seçim etdiniz,1-7 arası seçim edə bilərsiniz");
                            Console.WriteLine("--------------------------------");
                            break;


                    }


                } while (SecondSelect != 0);
            }
     

        

            static void AddNewProduct()
            {

                MarketableServise marketableServise = new MarketableServise();

                Sales sale = new Sales();

                Products products = new Products();

                Console.WriteLine("Mehsulun adini daxil edin:");

                string name = Console.ReadLine();

                products.ProductName = name;


                Console.WriteLine("Satış məbləğini daxil edin:");

                string priceInput = Console.ReadLine();

                double price;

                while (!double.TryParse(priceInput, out price))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");

                    priceInput = Console.ReadLine();
                }

                products.ProductPrice = price;



                Console.WriteLine("Mehsulun nomresini qeyd edin");

                products.ProductCode = Console.ReadLine();



                Console.WriteLine("Mehsulun sayini daxil edin");

                string quantityInput = Console.ReadLine();


                int quantity;

                while (!int.TryParse(quantityInput, out quantity))
                {
                    Console.WriteLine("Rəqəm daxil etməlisiniz!");

                    quantityInput = Console.ReadLine();

                }
                products.Quantity = quantity;

                ProductCategory category;
               
                Console.WriteLine("Mehsulun kategoriyasini secin");

                Console.WriteLine("1. İçkilər");
                Console.WriteLine("2. Ərzaq");
                Console.WriteLine("3. Şirniyyat");

                category = (ProductCategory)int.Parse(Console.ReadLine());
               
            
                switch(category)
            {
                
                case (ProductCategory)1:
                  products.ProductCategory = ProductCategory.İçkilər;
                    break;

                case (ProductCategory)2:
                    products.ProductCategory = ProductCategory.Ərzaq;
                    break;

                case (ProductCategory)3:
                    products.ProductCategory = ProductCategory.Şirniyyat;
                    break;


            }
               
                _marketableServise.AddNewProducts(products);

            Console.WriteLine("mehsul elave edildi");

            }


        static void EditCurrentProduct()
        {
            Products products = new Products();

            Sales sale = new Sales();
           
            SalesItem salesItem = new SalesItem();
            
            List<Products>products1 = new List<Products>();
            
            Console.WriteLine("axtarish ucun mehsulun kodunu daxil edin");
            
            string code = Console.ReadLine();
            
                if (products1.Exists(p => p.ProductCode == code))
                {
                    Console.WriteLine("mehsulun yeni qiymetini daxil edin");
                   
                    double price = double.Parse(Console.ReadLine());

                products.ProductPrice = price;

                sale.AmmountOfSale = +products.ProductPrice;

                Console.WriteLine("mehsulun yeni adini daxil edin");

                string name = Console.ReadLine();

                products.ProductName = name;

                Console.WriteLine("mehsulun yeni kateqoriyasini secin edin");
               
                Console.WriteLine("1. İçkilər");
                Console.WriteLine("2. Ərzaq");
                Console.WriteLine("3. Şirniyyat");

                ProductCategory category = (ProductCategory)int.Parse(Console.ReadLine());
                if (category==ProductCategory.İçkilər)
                {
                    category = ProductCategory.İçkilər;
                }
                 else if  (category==ProductCategory.Ərzaq) {
                    category = ProductCategory.Ərzaq;

                }
                else if (category == ProductCategory.Şirniyyat)
                {
                    category = ProductCategory.Şirniyyat;

                }
                else
                {
                    Console.WriteLine("sehv kateqoriya secdiniz");
                }
                Console.WriteLine("mehsulun yeni sayini  daxil edin");
               
                int count = int.Parse(Console.ReadLine());

                products.Quantity = count;
                salesItem.QuantityItemsOfSold = +products.Quantity;

                Console.WriteLine("mehsulun yeni kodunu daxil edin");

                string cod = Console.ReadLine();

                products.ProductCode = cod;
                Console.WriteLine("mehsul elave olundu");
            }
            else
            {

                Console.WriteLine("daxil etdiyiniz kodla mehsul yoxdur");
            }


            _marketableServise.FindProductForChangeByCode(products);

        }
            
           
            
        static void RemoveProductByCode()
        {
            Products prod = new Products();
           
            List<Products> prodRemove = new List<Products>();


            Console.WriteLine("silinecek mehsulun kodunu daxil edin");
           
            string code = Console.ReadLine();

            prodRemove.FindAll(p => p.ProductCode == code).Remove(prod);
        }





        static void ShowAllProducts()
                {
                    Console.WriteLine("-------------- CURRENT PRODUCTS --------------");

                    Products products = new Products();

                    Sales sale = new Sales();


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



        static void ShowProductsByCategory()
        {
            Products products = new Products();
            ProductCategory category;

            Console.WriteLine("istediyiniz mehsula gore kateqoriyani secin");

            Console.WriteLine("1. İçkilər");
            Console.WriteLine("2. Ərzaq");
            Console.WriteLine("3. Şirniyyat");

            category = (ProductCategory)int.Parse(Console.ReadLine());

            if (category==(ProductCategory)1)
            {
                Console.WriteLine(products.ProductName + "" + products.ProductCode + "" + products.ProductPrice + "" + products.Quantity + "" + products.ProductCategory);
            }
            else if (category==(ProductCategory)2)
            {
                Console.WriteLine(products.ProductName + "" + products.ProductCode + "" + products.ProductPrice + "" + products.Quantity + "" + products.ProductCategory);
            }

            else if (category == (ProductCategory)3)
            {
                Console.WriteLine(products.ProductName + "" + products.ProductCode + "" + products.ProductPrice + "" + products.Quantity + "" + products.ProductCategory);
            }


            //switch (category)
            //{

            //    case (ProductCategory)1:

            //        Console.WriteLine(products.ProductName + "" + products.ProductCode + "" + products.ProductPrice + "" + products.Quantity + "" + products.ProductCategory);
            //        break;

            //    case (ProductCategory)2:
            //        Console.WriteLine(products.ProductName + "" + products.ProductCode + "" + products.ProductPrice + "" + products.Quantity + "" + products.ProductCategory); break;

            //    case (ProductCategory)3:
            //        Console.WriteLine(products.ProductName + "" + products.ProductCode + "" + products.ProductPrice + "" + products.Quantity + "" + products.ProductCategory); break;

            //    default:
            //        Console.WriteLine("duz kateqoriya secmediniz");
            //        break;
            //}


            _marketableServise.ShowProductsByCategory(category);

        }



        static void GetProductsByPriceRange()
        {
            Products products = new Products();
            
            List<Products> price = new List<Products>();
            
            Console.WriteLine("gostermek istediyiniz mehsullarin araliq qiymetlerini daxil edin");

            Console.WriteLine("minimum meblegi daxil edin");
            double  Minprice = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine("maximum meblegi daxil edin");
            double Maxprice = Convert.ToDouble(Console.ReadLine());

            foreach (var item in price)
            {
                if (item.ProductPrice>=Minprice&&item.ProductPrice<=Maxprice)
                {
                    Console.WriteLine(item.ProductCode + " "+ item.ProductName+" "+ item.ProductCategory+" "+item.ProductPrice+" "+item.Quantity);
                }
                else
                {

                    Console.WriteLine("bu qiymet araliginda mehsul yoxdur");
                }
                   
            }
            _marketableServise.GetProductByPriceRange(Minprice,Maxprice);
        } 




        static void SearchProductByName()
        {

            Products products1 = new Products();
            List<Products> products = new List<Products>();
           
            Console.WriteLine("mehsulun adini daxil edin");

            string name = Console.ReadLine();

            products.FindAll(p => p.ProductName == name);
            Console.WriteLine(products1.ProductName+""+products1.ProductCategory+""+products1.ProductCode+""+products1.ProductPrice+""+products1.Quantity);

           _marketableServise.SearchProductByName(name);

            products.FindAll(p => p.ProductName != name);

            Console.WriteLine("bele adla mehsul movcud deyil ");
        }





        static void SecondCase()
                {
                    int SSelect;

                    Console.WriteLine("Hansı əməliyyatı etmək istədiyinizi seşin");
                    do
                    {

                        string Choise1 = Console.ReadLine();



                        while (!int.TryParse(Choise1, out SSelect))
                        {

                            Console.WriteLine("Rəqəm daxil etməlisiniz!");

                            Choise1 = Console.ReadLine();
                        }
                     

           


                        switch (SSelect)
                        {
                            case 0:
                                continue;


                            case 1:

                                Console.WriteLine("1. Yeni satış əlavə et");
                                AddNewSales();
                                break;
                            case 2:

                                Console.WriteLine("2. Satışdakı hansısa məhsulun geri qaytarılması(satışdan çıxarılması)");
                        RemoveSoldProduct();
                        break;

                            case 3:

                                Console.WriteLine("3. Satışın silinməsi ");
                        RemoveSold();
                                break;

                            case 4:

                                Console.WriteLine("4. Bütün satışların ekrana cıxarılması (nömrəsi,məbləgi,mehsul sayı,tarixi)");
                                Console.WriteLine("===========================================================================");
                                ShowAllSales();
                                break;

                            case 5:
                                Console.WriteLine("5. Verilən tarix aralığına görə satısların göstərilməsi ");
                                Console.WriteLine("===========================================================================");
                                GetSalesByDateRange();
                                break;

                            case 6:

                                Console.WriteLine("6. Verilən məbləğ aralıgına görə satışların göstərilməsi");
                        GetSalesByAmmountRange();
                        break;

                            case 7:
                                Console.WriteLine("7. Verilmiş bir tarixdə olan satışların göstərilməsi");
                                Console.WriteLine("===========================================================================");
                                GetSalesByDate();


                                break;

                            case 8:
                                Console.WriteLine("8. Verilmiş nömrəyə əsasən həmin nömrəli satışın məlumatlarının göstərilməsi");
                        GetSalesByNumber();
                        break;


                            default:

                                Console.WriteLine("--------------------------------");
                                Console.WriteLine("Siz yanlış seçim etdiniz,1-8 arası seçim edə bilərsiniz");
                                Console.WriteLine("--------------------------------");
                                break;


                        


                        }
                 
            
            } while (SSelect != 0);

                }

               
            

     


                static void AddNewSales()
                {

                    MarketableServise marketableServise = new MarketableServise();

                    Sales sale = new Sales();

                    Products products = new Products();

                    Console.WriteLine("Satış məbləğini daxil edin:");

                    string amountInput = Console.ReadLine();

                    double amount;

                    while (!double.TryParse(amountInput, out amount))
                    {
                        Console.WriteLine("Rəqəm daxil etməlisiniz!");

                        amountInput = Console.ReadLine();
                    }

                    sale.AmmountOfSale = amount;
                   

                
                    Console.WriteLine("Satışın nomresini qeyd edin");

                    sale.NumberOfSale = Console.ReadLine();
                  

                   
                    Console.WriteLine(" Satilmiw Mehsulun sayini daxil edin");

                    SalesItem salesItem = new SalesItem();

                    salesItem.QuantityItemsOfSold = Convert.ToInt32(Console.ReadLine());
                  
                    Console.WriteLine("Satış tarixi daxil edin (gun.ay.il):");

                    string dateInput = Console.ReadLine();

                    DateTime date;

                    while (!DateTime.TryParse(dateInput, out date))
                    {
                        Console.WriteLine("Tarixi daxil etməlisiniz!");

                        dateInput = Console.ReadLine();
                    }


                    sale.DateOfSold = date;
           

                 _marketableServise.AddNewSale(sale);
            
                    Console.WriteLine("-------------- Yeni satış əlavə edildi --------------");
                   
                }
            

      

                
                static void RemoveSoldProduct()

                {
                    SalesItem salesItem = new SalesItem();

                    List<Products> item = new List<Products>();


                    Products products1 = new Products();

                    Console.WriteLine("------------satisin legv olunmasi----------------");
                   
                    Console.WriteLine("Legv etmek ucun mehsulun adini daxil edin");
                    
                   string nameinput = Console.ReadLine();
                   
                   Console.WriteLine("Legv etmek ucun mehsulun sayini daxil edin");

                    string countIn = Console.ReadLine();

                    int count;

                    while(!int.TryParse(countIn,out count))
                    {
                        Console.WriteLine("reqem daxil edin");

                        countIn = Console.ReadLine();
                    }

            item.FindAll(i => i.ProductName == nameinput && i.Quantity == count);
            
            
            _marketableServise.RemoveSaleProduct(count - 1);
            
            
            
            
            
                }
       

       

                static void RemoveSold()
                {

            Console.WriteLine("satisin nomresini daxil edin");
            
           
            string number = Console.ReadLine();
           
            int index;


            while (!int.TryParse(number, out index))
            {
                Console.WriteLine("reqem daxil etmelisiniz");

                number = Console.ReadLine();
            }
            try
            {
                _marketableServise.RemoveSale(index - 1);
            
            Console.WriteLine("satis silindi");
            }
            
            catch (Exception)
            {

                Console.WriteLine("bele bir nomreli satis yoxdur "); 
            }  

            
           
           


        }   
            

          
               
                static void ShowAllSales()
                {
                    Sales sale = new Sales();
                    Products products = new Products();
                    SalesItem salesItem = new SalesItem();
           
                    sale.AmmountOfSale = products.ProductPrice * products.Quantity;
                  
                    salesItem.QuantityItemsOfSold = products.Quantity;

                    Console.WriteLine("-------------- CURRENT SALES --------------");
            
                var table = new ConsoleTable("#", "Number of Sale", "Amount", "Quantity", "Date");

                    int i = 1;
           

                foreach (var item in _marketableServise.Sales)
                {

                    table.AddRow(i, item.NumberOfSale, item.AmmountOfSale, item.saleQuantity, item.DateOfSold.ToString("dd.MM.yyyy"));
                    i++;

                }
                table.Write();

                _marketableServise.ShowAllSale();
            
                
      

}
          
        
        
             static void GetSalesByDateRange()

                {

                    Console.WriteLine("-------------- Tarix aralığında satışların toplamını --------------");

                    

                    Console.WriteLine(" tarixi daxil edin (gun.ay.il):");

                    string DateInput = Console.ReadLine();

                    DateTime Date;

                    while (!DateTime.TryParse(DateInput, out Date))
                    {
                        Console.WriteLine("Tarixi daxil etməlisiniz!");

                       DateInput = Console.ReadLine();
                    }
                   

                        double result = _marketableServise.GetSaleByDate(Date);

                        if (result != 0)
                        {
                            Console.WriteLine("-------------- {0} - {1} aralığına görə satış toplamı {2} azndir --------------", Date.ToString("dd.MM.yyyy"),  result.ToString("#.##"));
                        }
                        else
                        {
                            Console.WriteLine("-------------- {0} - {1} aralığına görə satış yoxdur --------------", Date.ToString("dd.MM.yyyy"));
                        }
                    }
                

        

        

            static void GetSalesByAmmountRange()
            {

                Console.WriteLine("-------------- Tarix aralığında satışların toplamını --------------");


                Console.WriteLine("Minimal məbləği daxil edin");

                string minAmount = (Console.ReadLine());

                double min;

                while (!double.TryParse(minAmount, out min))
                {

                    Console.WriteLine("Meblegi daxil etməlisiniz!");

                    minAmount = Console.ReadLine();
                }

                Console.WriteLine("Maximal meblegi daxil edin ");

                string maxAmmout = (Console.ReadLine());

                double max;

                while (!double.TryParse(maxAmmout, out max))
                {
                    Console.WriteLine("Meblegi daxil etməlisiniz!");

                    maxAmmout = (Console.ReadLine());
                }

            
              double result = _marketableServise.GetSaleByAmountRange(min,max);



          
                if (result != 0)
                {
                    Console.WriteLine("-------------- {0} - {1} aralığına görə satış  {2} azndir --------------", min, max,result.ToString("#.##") );
                }
                else
                {
                    Console.WriteLine("-------------- {0} - {1} aralığına görə satış yoxdur --------------", min, max);
                }
         
            }
   
        
    

            static void GetSalesByDate()
            {
                Console.WriteLine("-------------- Tarixə görə satışı göstər --------------");

                Console.WriteLine("tarixi daxil edin (gun.ay.il):");

                string DateInput = Console.ReadLine();

                DateTime Date;

                while (!DateTime.TryParse(DateInput, out Date))
                {
                    Console.WriteLine("Tarixi daxil etməlisiniz!");

                    DateInput = Console.ReadLine();
                }

                double result = _marketableServise.GetSaleByDate(Date);

                if (result != 0)
                {
                    Console.WriteLine("-------------- {0} tarixə görə satış toplamı {1} azndir --------------", Date.ToString("dd.MM.yyyy"), result.ToString("#.##"));
                }
                else
                {
                    Console.WriteLine("-------------- {0} tarixə  görə satış yoxdur --------------", Date.ToString("dd.MM.yyyy"));
                }

            }
           

       

           static void GetSalesByNumber()
            {
            Sales sale = new Sales();

            List<Sales> sales = new List<Sales>();
           
            Console.WriteLine("satis nomresini daxil edin");
           
            string no = Console.ReadLine();
 
            sales.FindAll(s => s.NumberOfSale == no);
           
            Console.WriteLine(sale.AmmountOfSale);
            
            _marketableServise.GetSaleByNumber(no);
            }






































        }


    }





