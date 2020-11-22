using System;
using System.Text;
using MyFirstProject.Infrastructure.Enum;
using MyFirstProject.Infrastructure.Model;
using MyFirstProject.Infrastructure.Service;
using ConsoleTables;


namespace MyFirstProject
{
    class Program
    {
        private static MarketableServise _marketableServise =  new MarketableServise();

       
        static void Main(string[] args)
        {
            
              
        Console.OutputEncoding = Encoding.UTF8;

            #region Menu

               
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

   }                      } while (select != 3) ;


            #endregion

            #region FirstCase
            Console.WriteLine("==============================================================================");

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
                    #endregion

            #region switch FirstCase

                    

                    switch (SecondSelect)
                    {
                        case 0:
                            continue;


                        case 1:

                            Console.WriteLine("1. Yeni satış əlavə et");
                            Console.WriteLine("============================================================");
                            

                            break;
                        case 2:

                            Console.WriteLine("2. Satışdakı hansısa məhsulun geri qaytarılması(satışdan çıxarılması)");
                            break;

                        case 3:

                            Console.WriteLine("3. Satışın silinməsi ");

                            break;

                        case 4:

                            Console.WriteLine("4. Bütün satışların ekrana cıxarılması (nömrəsi,məbləgi,mehsul sayı,tarixi)");
                            break;

                        case 5:
                            Console.WriteLine("5. Verilən tarix aralığına görə satısların göstərilməsi ");

                            break;

                        case 6:

                            Console.WriteLine("6. Verilən məbləğ aralıgına görə satışların göstərilməsi");
                            break;

                        case 7:
                            Console.WriteLine("7. Verilmiş bir tarixdə olan satışların göstərilməsi");
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


                } while (SecondSelect != 0);
            }
            #endregion

            #region FirstCaseMethod

            
            static void AddNewProduct(Products product)
            {


            }
            

            static void EditCurrentProduct()
            {
               
            }

            static void RemoveProduct(string productCode)
            {
                
            }


            static void ShowAllProducts()
            {
                
            }
            static void ShowProductsByCategory(ProductCategory productCategory)
            {
                
            }



            static void GetProductsByPriceRange(double minPrice, double maxPrice)
            {
              
            }

            static void SearchProductByName(string productName)
            {

            }


            #endregion

            #region SecondCase

            
            static void SecondCase()
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
                    #endregion

            #region switch SecondCase

                    
                    switch (SecondSelect)
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

                            break;

                        case 6:

                            Console.WriteLine("6. Verilən məbləğ aralıgına görə satışların göstərilməsi");
                            break;

                        case 7:
                            Console.WriteLine("7. Verilmiş bir tarixdə olan satışların göstərilməsi");
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


                } while (SecondSelect != 0);

                

            }
            #endregion
          
            #region SecondCase Method

            
            static void AddNewSales()
            {
                Console.WriteLine("Yeni satış əlavə et");
                Sales sale = new Sales();

                Products products = new Products();

                Console.WriteLine("Mehsulun adini daxil edin");
                
                products.ProductName = Console.ReadLine();

                Console.WriteLine("Mehsulun qiymetini daxil edin");

                products.ProductPrice =Convert.ToInt32( Console.ReadLine());

                Console.WriteLine("Mehsulun nomresini qeyd edin");

                products.ProductCode = Console.ReadLine();

                Console.WriteLine("Mehsulun sayini daxil edin");
                products.Quantity = Convert.ToInt32(Console.ReadLine());

            }

            static void RemoveSoldProduct(string productName, int productQuantity)
            {
                
            }
            static void RemoveSold(int numberOfsale)
            {
                
            }
            static void ShowAllSales()
            {
                Console.WriteLine("-------------- CURRENT SALES --------------");

                var table = new ConsoleTable("#","Number of Sale" ,"Amount", "Date");
                
            int i = 1;
                foreach (var item in _marketableServise.Sales)
                {
                    

                        table.AddRow(i, item.NumberOfSale, item.AmmountOfSale,  item.DateOfSold.ToString("dd.MM.yyyy"));
                    i++;
               
}
                table.Write(); 
                
            }
            static void GetSalesByDateRange(DateTime startDate, DateTime endDate)
            {
                
            }
            
            static void GetSalesByAmmountRange(double minAmmout, double maxAmmout)
            {
                
            }

            static void GetSalesByDate(DateTime date)
            {
                
            }

           
            static void GetSalesByNumber(int numberOfsale)
            {
               
            }

            #endregion




































        }
    }
    }



