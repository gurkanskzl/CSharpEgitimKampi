using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar

            //()
            //Geriye değer döndürmeyen metotlar.
            //Customer --> listele, ekle, sil, güncelle.
            //Void

            /*
            void CustomerList()
            {
                Console.WriteLine("Gürkan Sakızlı");
                Console.WriteLine("İlker Şenel");
                Console.WriteLine("Berkan Başak");
                Console.WriteLine("Koray Bensiz");
            }
            //Ekrana çağırır.
            CustomerList();
            CustomerList(); 
            CustomerList();
            CustomerList();
            */

            /*
            void Sum()
            {
                int x = 1; int y = 2; int z = x + y;
                Console.WriteLine(z);
            }
            Sum();
            */

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            /*
            void WriteMethod(string customeName)
            {
                Console.WriteLine(customeName);
            }
            WriteMethod("Gürkan Sakızlı");
            */

            /*
            void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri: " + name + " " + surName);
            }
            CustomerCard("Gürkan" , "İlker");
            CustomerCard("Berkan" , "Koray");
            */

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            /*
            void Sum(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine(result);
            }
            Sum(4, 5, 6);
            */

            #endregion

            #region Geriye Değer Döndüren Metotlar

            /*
            //Karşılığı yok.
            string CustomerName()
            {
                return "Buse Yıldız";
            }
            CustomerName();
            */

            /*
            string StudentCard()
            {
                string name = "Ali";
                string surname = "Kaya";
                return name + " " + surname;
            }
            Console.WriteLine(StudentCard());   
            */

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            /*
            string CountryCard(string countryName, string capital, string flagColor) 
            {
                string cardInfo = "Ülke: " + countryName + " - Başkent:  " + capital + " - Bayrak Rengi: " + flagColor;
                return cardInfo;
            }
            string x, y, z;
            Console.Write("Ülke Adını Giriniz: ");
            x = Console.ReadLine();

            Console.Write("Başkenti Giriniz: ");
            y = Console.ReadLine();

            Console.Write("Bayrak Rengini Giriniz: ");
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));

            Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı - Beyaz"));
            */

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            /*
            int Sum(int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }
            Console.WriteLine(Sum(45, 98));
            Console.WriteLine(Sum(36, 25));
            Console.WriteLine(Sum(44, 36));
            Console.WriteLine(Sum(14, 20));
            */

            #endregion

            #region Örnek Uygulama

            /*
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli Öğrenci Sınavı Geçti." + "Ortalama: " + result;
                }
                else
                {
                    return student + " İsimli Öğrenci Sınavı Geçemedi." + "Ortalama: " + result;
                }      
            }
            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            */

            #endregion

            Console.Read();
        }
    }
}
