using System.Security.Cryptography;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen değerler arasında rastgele sayı üreten  ve bu değerleri 10 elemanlı bir diziye atayan SayiUret() isimli bir metot yazın.
            //Bu dizinin elemanlarını yazan DiziYazdır() isimli bir metot daha yazarak elemanları listeleyin.
            //Daha sonra bu dizi içerisinde EnBuyukDeger() adında bir metot ile dizinin en büyük değerini bulan,
            //en küçük değerinin bulan EnKucukDeger() adından başka bir metot daha yazınız.
            //EnBuyukDeger ve EnKucukDeger metotlarında dönen değerleri ekranda gösteren programı yazınız
            //kullanıcının bütün hataları kontrol altına alınmalı
            Console.WriteLine("bir sayı girin:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("bir sayı daha girin:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[10];
            int[] yenidizi = new int[8];
            while (true)
            {
                
                if (sayi2 - sayi1 >= 9)
                {
                    

                    SayiUret(ref sayi1, ref sayi2, ref dizi);

                    Console.WriteLine("******SAYILAR*********");
                    DiziYazdır(ref dizi);
                    int max = 0;
                    int min = 0;
                    EnBuyukDeger(ref dizi, ref max);
                    EnKucukDeger(ref dizi, ref min);
                    Console.WriteLine("******DÖNDÜRÜLEN SAYILAR**********");
                    DegerDondurme(ref dizi, ref yenidizi, ref min, ref max);
                    break;
                    
                  
                }
                else
                {
                    Console.WriteLine("ikinci girilen sayı 1. girilen sayıdan 10 ya da daha fazla olmak zorunda");
                }
            }
           





        }
        static void SayiUret(ref int sayi1, ref int sayi2,ref int [] dizi)
        {
            Random r = new Random();
            int sayi = 0;
            for (int i = 0; i < 10; i++)
            {
                sayi = r.Next(sayi1, sayi2);
                dizi[i] = sayi;
            }

           
               
            
            
            
            
        }
        static void DiziYazdır( ref  int[] dizi)
        {

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
        static void EnBuyukDeger(ref int[] dizi, ref int enBuyuk)
        {


            enBuyuk = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyuk)
                {
                    enBuyuk = dizi[i];
                }
            }

            Console.WriteLine("Dizideki en büyük değer: " + enBuyuk);
        }
        static void EnKucukDeger(ref int[] dizi, ref int enKucuk)
        {


            enKucuk = dizi[0];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < enKucuk)
                {
                    enKucuk = dizi[i];
                }
            }

            Console.WriteLine("Dizideki en küçük değer: " + enKucuk);
        }
        static void DegerDondurme(ref int[] dizi,ref int [] yenidizi,ref int min,ref int max)
        {
            Random r = new Random();
            int sayi = 0;
            for (int i = 0; i < yenidizi.Length; i++)
            {
                sayi = r.Next(min + 1, max);
                yenidizi[i] = sayi;
                    
                
            }
           
            foreach (var item in yenidizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
