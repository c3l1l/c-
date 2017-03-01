using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n");
            Console.WriteLine(" *****************************************************************");
            Console.WriteLine(" *                                                               *");
            Console.WriteLine(" *                                                               *");
            Console.WriteLine(" *                                                               *");
            Console.WriteLine(" * ---------------------Oyuna Hoşgeldiniz-----------------------*");
            Console.WriteLine(" *                                                               *");
            Console.WriteLine(" * -------------------Batman Supermene Karşı--------------------*");
            Console.WriteLine(" *                                                               *");
            Console.WriteLine(" *                                                               *");
            Console.WriteLine(" *****************************************************************");
            Console.WriteLine();    
            Console.WriteLine(" *******************Başlamak için \"Start\" yaz*******************");
            Console.WriteLine();        //Oyunun giriş Ekranı istediğiniz gibi düzenleyebilirsiniz.
                Console.Write("                            ");//Kullanıcının girdiği Start komutunun satırın ortasında görünmesi için satırın başına boşluk bıraktık.
            string baslat=Console.ReadLine();


            if (baslat == "Start" || baslat == "START" || baslat == "start")
                {
                    Console.WriteLine("Tek Oyuncu için \"Single\"             Çift Oyuncu için \"Multi\" yazınız.");
                    Console.Write("                            "); //Kullanıcının girdiği Single yada Multi değeri satırın ortasıda görünmesi için kullandık.
                    string oyun_secimi=Console.ReadLine();
                    if (oyun_secimi == "Single" || oyun_secimi == "SINGLE" || oyun_secimi == "single")
                    {
                        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("++++++++++++++++++++++++Tek oyuncu seçildi++++++++++++++++++++++");
                        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        Console.WriteLine(" Hey Dostum !!! \n   Sen Supermensin.   \"S\" tuşu ile ateş edebilirsin.");
                        Console.WriteLine();
                        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$  Oyun Başlıyor Hazır Ol !  $$$$$$$$$$$$$$$$$$$$$$$$$$$$.");
                        int batman=100;
                        int supermen=100;
                        Console.WriteLine("\t\t\tSupermen:" + supermen + "--vs--" + "Batman:" + batman);
                        int sayac = 1;
                        while(batman>0 && supermen>0)
                        {
                            Console.WriteLine();
                            Console.Write("Ateş İçin S tuşunu kullanınız. \t\t\tAteş<<S>>");
                            string ates = Console.ReadLine();
                            if (ates == "S"||ates=="s")
                            {
                                Random uret = new Random();
                                int uretbt = uret.Next(1, 40);
                                int uretspr = uret.Next(1, 40);
                                Console.WriteLine("\t..........................."+sayac+".ROUND..........................");//Sayac değişkeni round sayısını belirtmek için burda yazdırılmıştır.
                                batman = batman - uretspr;
                                Console.WriteLine("\t\t\t Supermen " + uretspr + " ==>Batman " + batman);

                                supermen = supermen - uretbt;
                                Console.WriteLine("\t\t\t Supermen " + supermen + " <==Batman " + uretbt);
                                
                                Console.WriteLine();
                                Console.WriteLine("\t\t\tSupermen:" + supermen + "--vs--" + "Batman:" + batman);
                                sayac++;
                            }
                            else { Console.WriteLine("Ateş için sadece S tuşu kullanılmalıdır."); }
                        }
                        if (batman > supermen)
                        {
                            Console.WriteLine("\t\t########################################");
                            Console.WriteLine("\t\t#############Batman Kazandı#############");
                            Console.WriteLine("\t\t########################################");
                        }
                        else if (supermen > batman)
                        {
                            Console.WriteLine("\t\t########################################");
                            Console.WriteLine("\t\t############Supermen Kazandı############");
                            Console.WriteLine("\t\t########################################");
                        }
                        else 
                        {
                            Console.WriteLine("Berabere kaldılar.");
                        }
                    }//MULTIPLAYER OYUNCULAR BURADAN ITIBAREN
                    else if (oyun_secimi == "Multi" || oyun_secimi == "MULTI"||oyun_secimi=="multi")
                    {
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("++++++++++++++++++++++++Çoklu oyuncu seçildi+++++++++++++++++++++++++++++++");
                        Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                        Console.WriteLine("!!! Hey Sen Soldaki !!! \n   Sen Supermensin.   \"S\" tuşu ile ateş edebilirsin.");
                      
                        Console.WriteLine(" \t\t\t\t\t\t\t!!!Hey Sen Sağdaki !!! \n   Sen Batmansin.   \"B\" tuşu ile ateş edebilirsin.");
                        Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");
                        Console.WriteLine();
                        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$  Oyun Başlıyor Hazır Ol !  $$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                        int batman = 100;
                        int supermen = 100;
                        Console.WriteLine("\t\t\tSupermen:" + supermen + "--vs--" + "Batman:" + batman);
                        int sayac = 1;
                        while (batman > 0 && supermen > 0)
                        {
                            Console.WriteLine();
                            Console.Write("Ateş İçin S ve B tuşunu kullanınız. \t\t\tAteş<<S>>");
                            ConsoleKeyInfo ates = new ConsoleKeyInfo(); //Bu fonksiyon ateş etme esnasında S ve B tuşlarında sonra enter tuşuna basma gerekliliğinden kaçış amacıyla kullanılmıştır.
                            ates = Console.ReadKey(true);                            
                            if (ates.Key==ConsoleKey.S)
                            {
                                Random uret = new Random();
                                int uretspr = uret.Next(1, 40);
                                Console.WriteLine("\t..........................." + sayac + ".ROUND..........................");//Sayac değişkeni round sayısını belirtmek için burda yazdırılmıştır.
                                batman = batman - uretspr;
                                Console.WriteLine("\t\t\t Supermen " + uretspr + " ==>Batman " + batman);
                                                              
                                Console.WriteLine();
                                Console.WriteLine("\t\t\tSupermen:" + supermen + "--vs--" + "Batman:" + batman);
                                sayac++;
                            }else if(ates.Key==ConsoleKey.B)
                            {
                                Random uret = new Random();
                                int uretbt = uret.Next(1, 40);
                                 Console.WriteLine("\t..........................." + sayac + ".ROUND..........................");//Sayac değişkeni round sayısını belirtmek için burda yazdırılmıştır.
                                
                                supermen = supermen - uretbt;
                                Console.WriteLine("\t\t\t Supermen " + supermen + " <==Batman " + uretbt);

                                Console.WriteLine();
                                Console.WriteLine("\t\t\tSupermen:" + supermen + "--vs--" + "Batman:" + batman);
                                sayac++;
                            }
                            else { Console.WriteLine("Ateş için sadece S ve B tuşu kullanılmalıdır."); }
                        }
                        if (batman > supermen)
                        {
                            Console.WriteLine("\t\t########################################");
                            Console.WriteLine("\t\t#############Batman Kazandı#############");
                            Console.WriteLine("\t\t########################################");
                        }
                        else if (supermen > batman)
                        {
                            Console.WriteLine("\t\t########################################");
                            Console.WriteLine("\t\t############Supermen Kazandı############");
                            Console.WriteLine("\t\t########################################");
                        }
                        else
                        {
                            Console.WriteLine("Berabere kaldılar.");
                        }
                    }
                    else { Console.WriteLine("Oyunu başlatmak için doğru değer girmelisiniz.Tek Oyuncu için \"Single\",Çift Oyuncu için \"Multi"); }




                    


                }
                else
                {
                    Console.WriteLine("Başlatmak için \"Start\" girmelisiniz.");
                }
        }
    }
}
