using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //For(x;y;z)
            //x: Başlangıç
            //y: Bitiş
            //z: artış-azalış

            /*
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine("C# Eğitim Kampı");
            }
            */

            /*
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            for (int i = 3; i <= 50; i += 3) //i'nin üzerine 3 ekleyerek git.
            {
                Console.WriteLine(i);
            }
            */

            /*
            Console.WriteLine("Lütfen Ekrana Yazılmasını İstediğiniz Adedi Giriniz: ");
            int finishValue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= finishValue; i++) 
            { 
                Console.WriteLine("Yaşasın İstanbul"); //Ekrandan girdiğimiz aded kadar yazdırır.
            }
            */

            #endregion

            #region For Döngüsü ile Karar Yapıları

            /*
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0) //100' e kadar olan 5'e tam bölünebilen sayılar.
                {
                    Console.WriteLine(i);
                }
            }
            */

            /*
            int totalValue = 0;
            for (int i = 1; i <= 10; i++)
            { 
                totalValue += i;
            }
            Console.WriteLine(totalValue);
            */

            /*
            int totalValue = 0;
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0) // Çift sayı kontrolü
                {
                    totalValue += i;
                    Console.WriteLine(i); // Çift sayıyı yazdır
                    Console.WriteLine("Toplam Değer: " + totalValue); // Güncel toplam değeri yazdır
                }
            }
            */

            /*
            int count = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 7 == 0)
                {
                    count++; //50' e kadar olan 7' e bölünebilen sayıların adedi.
                }

            }
            Console.WriteLine(count);
            */

            /*
            int bacterium = 1;
            for (int i = 1; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            }
            */

            #endregion

            #region While Döngüsü

            /*
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine("Merhaba Döngüler");
                i++;
            }
            */

            /*
            int i = 1;
            while (i <= 10)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            */

            /*
            int i = 1;
            int sum = 0;

            while (i <= 10)
            {
                sum += i;
                i++;
            }
            Console.WriteLine(sum);
            */

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456

            /*
            Console.Write("Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10; //Kalan 6
            tens = (number % 100) / 10; //456' ı 100' e böl. kalan 56 olur. Onlar basamağını bulmak için 56' ı 10' a böleriz.
            hundreds = number / 100; //4.56 --> 4

            Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            sum = ones + tens + hundreds;
            Console.WriteLine(sum);
            */

            #endregion

            Console.Read();
        }
    }
}
