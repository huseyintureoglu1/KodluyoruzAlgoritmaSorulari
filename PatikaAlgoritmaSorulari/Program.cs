using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaAlgoritmaSorulari
{
    class Program
    {

        static void Main(string[] args)
        {
            int sayi;
           // int toplam;
            int bolunenSayi;
            ArrayList array = new ArrayList();
            ArrayList array2 = new ArrayList();
            CumleVeKelimeSayisi();
            SondanKelimeler();
            TamBolunenler();
            ÇiftSaylar();
            

            void CumleVeKelimeSayisi()
            {
                Console.WriteLine("Lütfen cümle giriniz...");
                string cumle = Console.ReadLine();
                char[] ayrac = { ' ' };
                string[] kelimeler = cumle.Split(ayrac);
                Console.WriteLine("Kelime sayısı: "+kelimeler.Length.ToString());
                int toplam = 0;
                for (int i = 0; i < kelimeler.Length; i++)
                {
                   
                    toplam=toplam+kelimeler[i].Count();
                }

                Console.WriteLine("harf sayısı: "+toplam);
            }

            void SondanKelimeler()
            {
                Console.WriteLine("Lütfen kaç adet kelime  girmek istediğinizi yazınız.");
                while (true)
                {
                    sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen pozitif bir tam sayi giriniz!!!");
                    }
                }
                for (int i = 0; i < sayi; i++)
                {
                    string kelime = Console.ReadLine();
                    array2.Add(kelime);
                }
                for (int i = sayi-1; i >= 0; i--)
                {
                    Console.Write(array2[i]+" ");
                }
                Console.ReadLine();
            }

            void TamBolunenler()
            {


                Console.WriteLine("Lütfen kaç adet sayı girmek istediğinizi seçiniz.");
                while (true)
                {
                     sayi = Convert.ToInt32(Console.ReadLine());
                    if (sayi>0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen pozitif bir tam sayi giriniz!!!");
                    }
                }

                Console.WriteLine("Lütfen bölünmesini istediğiniz sayıyı giriniz.");

                while (true)
                {
                     bolunenSayi = Convert.ToInt32(Console.ReadLine());
                    if (bolunenSayi>0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Lütfen pozitif bir tam sayı giriniz!!!");
                    }
                }
                for (int i = 0; i < sayi; i++)
                {
                    Console.Write("Sayı Giriniz: "); 
                    int sayilar = Convert.ToInt32(Console.ReadLine());
                    array.Add(sayilar);

                }
                Console.WriteLine("Array list verileri");
                foreach (int item in array)
                {
                    if (item%bolunenSayi==0)
                    {
                        Console.WriteLine("bölünen veri"+item);
                    }
                   
                }

            }



            void ÇiftSaylar()
            {
                List<Sayilar> pozitifSayilar = new List<Sayilar>();
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("Lütfen sayi giriniz:");
                    int sayi1 = Convert.ToInt32(Console.ReadLine());
                    if (sayi1 > 0 && sayi % 2 == 0)
                    {

                        Sayilar sayilar = new Sayilar();
                        sayilar.ÇiftSayilar = sayi;
                        pozitifSayilar.Add(sayilar);
                    }
                    else
                    {
                        Sayilar sayi2 = new Sayilar();
                        sayi2.TekSayilar = sayi;
                        pozitifSayilar.Add(sayi2);
                    }
                }
                foreach (Sayilar item in pozitifSayilar)
                {
                    Console.WriteLine("------------------------");
                    int sayac = 0;

                    Console.WriteLine(item.ÇiftSayilar.ToString());
                    Console.WriteLine(item.TekSayilar.ToString());
                }
                Console.ReadLine();
            }

        }
    }

    }

