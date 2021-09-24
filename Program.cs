using System;

namespace _16._09._2021_sayı_tahmın_oyunu
{
  
    
        class Program
        {
            static void Main(string[] args)
            {
                //Program 0-100 arasında bir sayı aklında tutacak ve kullanıcıdan bunu bilmesini isteyecej.her tahminde kullanıcya yukarı aşağı şeklinde ipucu verecek bildiğinde ise kaç denemeden bildiğini söyleyecek . tekrarı için soracak. 

                do
                {
                    int sayac = 0;
                    int tahmin = 0;
                    Random rnd = new Random();
                    int tutulansayi = rnd.Next(101);
                    Console.WriteLine("1 ile 100 arasında bir sayı giriniz. ");

                    do
                    {
                        do
                        {
                            Console.WriteLine("Tahmininiz :  ");
                            try
                            {
                                tahmin = int.Parse(Console.ReadLine());
                                if (tahmin < 1 || tahmin > 100)
                                {
                                    throw new Exception("Lütfen 1-100 arasında deger girin ");
                                }
                                break;
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine(ex.Message);
                                break;
                            }
                        } while (true);
                        sayac++;
                        if (tutulansayi > tahmin)
                        {
                            Console.WriteLine("Daha büyük sayı giriniz");
                        }
                        else if (tutulansayi < tahmin)
                        {
                            Console.WriteLine("Daha Küçük bir sayı giriniz.");
                        }
                        else
                        {
                            Console.WriteLine("Tutuğumuz sayı : {0} \n {1}.denemede bildiniz. Tebrikler aslan.", tutulansayi, sayac);
                            break;
                        }
                    } while (true);
                    Console.WriteLine("Tekrar etmek için e tuşuna bas");
                    string donendeger = Console.ReadLine();
                    if (donendeger.ToLower() != "e")
                    {
                        break;
                    }




                } while (true);

            }
        }
    }






