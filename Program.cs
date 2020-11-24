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

                            break;

                        case 4:

                            Console.WriteLine("4. Bütün məhsullari göstər");
                            ShowAllProducts();
                            break;

                        case 5:
                            Console.WriteLine("5. Kateqoriyasına görə məhsulları göstər ");

                            break;

                        case 6:

                            Console.WriteLine("6. Qiymət aralığına görə məhsullari göster");
                    
                            break;

                        case 7:
                            Console.WriteLine("7. Məhsullar arasında ada görə axtarış et");
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

                
                Console.WriteLine("Mehsulun kategoriyasini yazin");

                Console.WriteLine("İçkilər");
                Console.WriteLine("Ərzaq");
                Console.WriteLine("Şirniyyat");
                
                string inputName = Console.ReadLine();

            if(inputName== "İçkilər")
            {
                products.ProductCategory = (ProductCategory)Enum.Parse(typeof(ProductCategory) ,"İçkilər");
                Console.WriteLine("-------------- Yeni mehsul əlavə edildi --------------");

            }
                else if (inputName == "Ərzaq")
            {

              
                Console.WriteLine("-------------- Yeni mehsul əlavə edildi --------------");
            }
            else if (inputName == "Şirniyyat")
            {

              
           
          
            
                        Console.WriteLine("-------------- Yeni mehsul əlavə edildi --------------");
 }
          
            
            
            else
            {
                Console.WriteLine("Kateqoriyani sehv yazdiniz ve mehsul kateqoriyasiz elave olundu");
              
               }  
              
               
                _marketableServise.AddNewProducts(products);

            }


        static void EditCurrentProduct()
        {
            Products products = new Products();
           
            Console.WriteLine("mehsuliu kodunu daxil edin");
            
            string code = Console.ReadLine();
            
            if (products.ProductCode != null) {
            
            foreach (var item in products.ProductCode)
            {
                if (products.ProductCode==code)
                {
                    Console.WriteLine(products.ProductName);
                }
            }

 }
        }



        static void RemoveProduct()
        {

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







        }



        static void GetProductsByPriceRange()
        {

        }




        static void SearchProductByName()
        {

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
                                break;

                            case 3:

                                Console.WriteLine("3. Satışın silinməsi ");

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
                    if (nameinput==products1.ProductName)
                    {
                         
                    }
                    else { 
                        Console.WriteLine("bu adla mehsul yoxdur");
                    }
                }
       

       

                static void RemoveSold()
                {

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

                    #region Start Date

                    Console.WriteLine("Başlanğıc tarixi daxil edin (gun.ay.il):");

                    string startDateInput = Console.ReadLine();

                    DateTime startDate;

                    while (!DateTime.TryParse(startDateInput, out startDate))
                    {
                        Console.WriteLine("Tarixi daxil etməlisiniz!");

                        startDateInput = Console.ReadLine();
                    }
                    #endregion;

                    #region End Date

                    Console.WriteLine("Bitiş tarixi daxil edin (gun.ay.il):");

                    string endDateInput = Console.ReadLine();

                    DateTime endDate;

                    while (!DateTime.TryParse(endDateInput, out endDate))
                    {
                        Console.WriteLine("Tarixi daxil etməlisiniz!");

                        endDateInput = Console.ReadLine();

                        #endregion

                        double result = _marketableServise.GetSaleByDateRange(startDate, endDate);

                        if (result != 0)
                        {
                            Console.WriteLine("-------------- {0} - {1} aralığına görə satış toplamı {2} azndir --------------", startDate.ToString("dd.MM.yyyy"), endDate.ToString("dd.MM.yyyy"), result.ToString("#.##"));
                        }
                        else
                        {
                            Console.WriteLine("-------------- {0} - {1} aralığına görə satış yoxdur --------------", startDate.ToString("dd.MM.yyyy"), endDate.ToString("dd.MM.yyyy"));
                        }
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
           
            Console.WriteLine("satis nomresini daxil edin");
           
            string no = Console.ReadLine();

            if (no==sale.NumberOfSale)
            {

            }

            }






































        }


    }





