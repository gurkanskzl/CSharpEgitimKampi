using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları (Ekran)

            /*
            Console.WriteLine("Merhaba Dünya"); //Ekrana yazdırır. İmleci alt satıra indirir. 
            Console.Write("Selam"); //Write ifadesi sonraki adımda imleci yazının yanında bekletir.

            Console.WriteLine("*** Yemek Kategorileri ***");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("*** Yemek Kategorileri ***");
            */

            #endregion

            #region Değişkenler (String)

            /*
            string name; //Değişken_türü;
            name = "Gürkan"; //Değişken_adı;
            Console.WriteLine(name); //Name değerinin karşılığını gösterir.

            string customerName; //İsimlendirme standartı 'CamelCase' dir.İlk kelimenin ilk harfi küçük sonraki kelimenin ilk harfi büyük olur. Değişkenler adlandırılırken araya boşluk bırakılmaz.Alt kırmızı çizili olursa hata, yeşil ise uyarı verir.
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Gürkan";
            customerSurname = "Sakızlı";
            customerPhone = "+90 545 253 20 73";
            customerEmail = "gurkann.sakizli@gmail.com";
            district = "Pendik";
            city = "İstanbul";
            Console.WriteLine("*** Rezervasyon Kartı ***");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
            customerName = "İlker";
            customerSurname = "Şenel";
            customerPhone = "+90 123 45 67 89";
            customerEmail = "ilkersenel@gmail.com";
            district = "Bayrampaşa";
            city = "İstanbul";
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("------------------------------------------------");     
            */

            #endregion

            #region Değişkenler (Int)

            //int number = 32;
            //Console.WriteLine(number);

            /*
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*** Restoran Menü Fiyatı ***");
            Console.WriteLine();
            Console.WriteLine("---Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("---Kola: " + cokePrice + " TL ");
            Console.WriteLine("---Su: " + waterPrice + " TL ");
            Console.WriteLine("---Kızartma: " + friesPrice + " TL ");
            Console.WriteLine("---Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("---Limonata: " + lemonadePrice + " TL ");
            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 0;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;

            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL ");   
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL ");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL ");  
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL ");   
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL ");   
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL ");
            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL ");
            */

            #endregion

            Console.Read(); //Ekranın beklemesi için yazılır. Enter' a basılınca kapanır.
        }
    }
}


//Yazdırma komutları.
