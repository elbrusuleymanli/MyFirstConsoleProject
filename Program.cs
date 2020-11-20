using System;
using System.Text;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
              
            Console.OutputEncoding = Encoding.UTF8;

            int select;
            int begin;
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

                        Console.WriteLine("1. Yeni satış əlavə etmək");
                        Console.WriteLine("2 Satışdakı hansısa məhsulun geri qaytarılması(satışdan cıxarılması)");
                        Console.WriteLine("3 Satışın silinməsi");
                        Console.WriteLine("4 Bütün satışlarn ekrana çıxarılması(nömrəsi,məbləği,məhsul sayı,tarixi)");
                        Console.WriteLine("5 Verilən tarix aralığına görə satışların göstərilməsi");
                        Console.WriteLine("6 Verilən məbləğ aralığına görə satışların göstərilməsi");
                        Console.WriteLine("7 Verilmiş bir tarixdə olan satışların göstərilməsi");
                        Console.WriteLine("8 Verilmiş nömrəyə əsasən həmin nömrəli satişın məlumatlarının göstərilməsi");
                        SecondCase();
                        break;

                    default:

                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Siz yanlış seçim etdiniz,1-3 arası seçim edə bilərsiniz");
                        Console.WriteLine("--------------------------------");
                        break;

                }        } while (select != 3) ;

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

                    switch (SecondSelect)
                    {
                        case 0:
                            continue;


                        case 1:

                            Console.WriteLine("1. Yeni satış əlavə et");
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

                    switch (SecondSelect)
                    {
                        case 0:
                            continue;


                        case 1:

                            Console.WriteLine("1. Yeni satış əlavə et");
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






        } }
    }



