using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //4 tane parametre alan döngüdür (1; 2; 3; 4).
            //1.Değişken Türü
            //2.Değişken Adı
            //3.In
            //4.Liste, Koleksiyon, Dizi

            /*
            string[] cities = { "Milano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova", "", "", "" };
            foreach (string x in cities)
            {
                Console.WriteLine(x);
            }
            */

            /*
            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            /*
            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            */

            /*
            int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            Console.WriteLine(total);   
            */

            //Foreach döngüsü sadece dizilerle çalışmaz listelerle de çalışır.
            /*
            List<int> numbers = new List<int>()
            {
                1,2,3,4,5,8
            };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            */

            /*
            string word = "Merhaba";
            foreach (char c in word)
            {
                Console.WriteLine(c);
            }
            */

            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            /*
            Console.WriteLine("*** C# Eğitim Kampı Sınav Uygulaması ***");
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma.
            Console.WriteLine();
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler.
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            Console.WriteLine();
            for (int i = 0; i < studentCount; i++)
            { 
                Console.Write($"{i + 1}. Öğrencinin İsmini Giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;

                //Her öğrenci için 3 sınav notu girişi.
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} Adlı Öğrencinin {j + 1}. Sınav Notunu Giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value; //Notlar toplanır.
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav ortalamaları.
            for(int i = 0;i < studentCount;i++)
            {
                Console.WriteLine("--------------------------------------------------");         
                Console.WriteLine($"{studentNames[i]} Adlı Öğrencinin Ortalaması: {studentExamAvg[i]}");
                
                //Öğrencilerin ortalaması ve geçip kalma durumu.
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} Adlı Öğrenci Dersi Kaldı!");
                }

            }
            Console.WriteLine("--------------------------------------------------");
            */

            #endregion

            Console.ReadLine();
        }
    }
}
