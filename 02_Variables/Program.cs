using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Değişkenler (Double)

            //double number;
            //number = 1.70; //Noktalı sayılar ekranda virgül görünür.
            //Console.WriteLine(number);

            /*
            Console.WriteLine("*** Fiyat Listesi ***");
            Console.WriteLine();
            double applePrice, orangePrice, strawberryPrice, potatoPrice, domatoPrice;

            applePrice = 19.99;
            orangePrice = 29.95;
            strawberryPrice = 39.99;
            potatoPrice = 19.95;
            domatoPrice = 29.99;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("--- Elma Birim Fiyatı: " + applePrice + " ₺ ");
            Console.WriteLine("--- Portakal Birim Fiyatı: " + orangePrice + " ₺ ");
            Console.WriteLine("--- Çilek Birim Fiyatı: " + strawberryPrice + " ₺ ");
            Console.WriteLine("--- Patates Birim Fiyatı: " +  potatoPrice + " ₺ ");
            Console.WriteLine("--- Domates Birim Fiyatı: " + domatoPrice + " ₺ ");
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, domatoGram;

            appleGram = 1.25;
            orangeGram = 2.35;
            strawberryGram = 0.75;
            potatoGram = 4.15;
            domatoGram = 5.25;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawBerryTotalPrice = strawberryPrice * strawberryGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double domatoTotalPrice = domatoPrice * domatoGram;

            Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + " ₺ ");
            Console.WriteLine("Alınan Ürün: Portakal - " + " Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " ₺ ");
            Console.WriteLine("Alınan Ürün: Çilek - " + " Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawBerryTotalPrice + " ₺ ");
            Console.WriteLine("Alınan Ürün: Patates - " + " Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " ₺ ");
            Console.WriteLine("Alınan Ürün: Domates - " + " Birim Fiyat: " + domatoPrice + " - Gramaj: " + domatoGram + " - Toplam Tutar: " + domatoTotalPrice + " ₺ ");

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawBerryTotalPrice + potatoTotalPrice + domatoTotalPrice;

            Console.WriteLine();

            Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " ₺ ");
            */

            #endregion

            #region Değişkenler (Char)

            //Char değişkenlere atama yapılırken 'tek' tırnak kullanılır.

            /*
            char symbol;
            symbol = 'A';
            Console.WriteLine(symbol);
           */

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            /*
            Console.WriteLine("*** Gürkan Hava Yolları Yolcu Bilgisi ***");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Yolcu Adı: "); //Yolcu adını yanına yazdırır.
            passengerName = Console.ReadLine(); //Klavyeden girilini gösterir.
            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();
            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();
            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();
            Console.Write("Yolcu TC Kimlik No: ");
            passengerIdentityNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " " + "- Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);
            */

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //ABC32D bu ifadediki sayıları sayısal değer olarak algılamaz.Karakter olarak görür.

            /*
            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;
            Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            shoesCount = int.Parse(Console.ReadLine()); //Başlangıçta bütün veri girişlerini string olarak algılar, int giriş yapıldığı için dönüşüm yapılması (parse metodu kullanılır) gerek.
            Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesPrice * shoesCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;
            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);
            */

            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //Eğer kod sayfasından ondalık sayı yazarken (nokta), console ekranından yazarken (virgül) yazılır.

            /*
            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Sınav Ortalamanız: " + result);
            */

            #endregion

            #region Klavyeden Karakter Girişleri
    
            /*
            char gender;
            Console.Write("Lütfen Cinsiyet Giriniz: ");
            gender = char.Parse(Console.ReadLine()); //İki karakter girilirse hata verir.

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            */

            #endregion

            Console.Read();
        }
    }
}
