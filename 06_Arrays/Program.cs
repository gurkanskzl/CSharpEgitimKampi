using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //2.4.6.8
            //Sarı, Kırmızı, Mavi, Turuncu, Beyaz.
            //Ankara, Adana, İstanbul, Bursa.
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Eleman Sayısı].

            /*
            string[] colors = new string[5];
            colors[0] = "Sarı";
            colors[1] = "Kırmızı";
            colors[2] = "Mavi";
            colors[3] = "Turuncu";
            colors[4] = "Beyaz";
            Console.WriteLine(colors[0] + " " + colors[1] + " " + colors[2] + " " + colors[3] + " " + colors[4]);  
            */

            /*
            string[] cities = new string[5];
            cities[0] = "Milano";
            cities[1] = "Budapeşte";
            cities[2] = "Kahire";
            cities[3] = "Lyon";
            cities[4] = "Üsküp";
            Console.WriteLine(cities[4]);
            */

            /*
            int[] numbers = new int[10];
            numbers[0] = 50;
            numbers[1] = 48;
            numbers[2] = 698;
            numbers[3] = 24;
            numbers[7] = 748;
            Console.WriteLine(numbers[7]);
            //Console.WriteLine(numbers[5]); //Dizinin boyutunda olup dizinin içinde değer ataması yapılmazsa 0 çıktısı verir.
            */

            /*
            //Index sırası         0       1       2         3        4 
            string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };
            Console.WriteLine(cities[2]);
            */

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            /*
            string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }
            */

            /*
            int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0) //3' bölünebilen sayıları sıralar.
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            */

            /*
            char[] sembols = { 'a', 'b', 'c', 'd', '*', '/', '-', '+' }; //Char tanımlanırken tek tırnak kullanılır.
            for (int i = 0; i < sembols.Length; i++)
            {
                Console.WriteLine(sembols[i]);
            }
            */

            /*
            int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            int maxNumber = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > maxNumber)
                {
                    maxNumber = myArray[i];
                }
            }
            Console.WriteLine(maxNumber);
            */

            /*
            string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };
            Console.WriteLine(persons.Length); //Kaç değer olduğunu gösterir.
            */

            /*
            int[] numbers = { 93, 85, 52, 41, 67, 10, 22, 35 };
            Array.Sort(numbers); //Sayıları küçükten büyüğe sıralar.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine();
            int[] numbers2 = { 93, 85, 52, 41, 67, 10, 22, 35 };
            Array.Reverse(numbers); //Sayıları büyükten küçüğe sıralar.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
;           }
            */

            #endregion

            #region Dizi Metodlar

            /*
            //Index sırası           0      1         2         3        4        5
            string[] customers = { "Ali", "Buse", "Ayşegül", "Merve", "Çınar", "Kaya" };
            int index = Array.IndexOf(customers, "Merve"); //Kaçıncı indexte olduğunu bulur.
            Console.WriteLine(index);
            */

            /*
            int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());
            */

            #endregion

            #region Kullanıcıdan Değer Alma

            /*
            string[] cities = new string[5];
            for (int i = 0; i < cities.Length; i++)
            {
                Console.Write($"lütfen {i + 1}. Şehri Giriniz: "); //Interpolated string (dize içi yerleştirme) ifadesidir. İçine yazılan dize içinde {} süslü parantezler kullanarak değişkenleri veya ifadeleri yerleştirebiliriz.
                cities[i] = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();
            for (int i = 0; i < cities.Length; i++)
            {
                Console.WriteLine(cities[i]);
            }
            */

            /*
            int[] numbers = { 10, 20, 30, 40, 50 };
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];  
            }
            Console.WriteLine(sum);
            */

            /*
            int[] numbers = { 91, 82, 73, 64, 55, 46, 37, 28, 19, 0 };
            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            */

            #endregion

            Console.Read();
        }
    }
}