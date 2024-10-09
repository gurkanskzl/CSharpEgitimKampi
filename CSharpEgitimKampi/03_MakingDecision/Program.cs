using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            /*
            Console.Write("Lütfen Şifreyi Giriniz: ");
            string password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Şifre Doğru!");
            }
            else
            {
                Console.WriteLine("Şifre Yanlış!");
            }
            */

            /*
            string capital, country;
            Console.Write("Başkent Giriniz: ");
            capital = Console.ReadLine();   
            Console.Write("Ülkeyi Giriniz: ");
            country = Console.ReadLine(); 
            if (capital == "Ankara" & country == "Türkiye") //Küçük-Büyük harf duyarlı. Çıktı ekranında farklı yazılırsa hata verir.
            {
                Console.Write("Veriler Doğrulandı!");
            }
            else
            {
                Console.Write("Hatalı Bilgi!"); 
            }
            */

            /*
            int number;
            Console.Write("Sayıyı Giriniz: ");
            number = int.Parse(Console.ReadLine()); //Klavyeden okunan değeri dönüştürür.
            if (number == 5) 
            {
                Console.WriteLine("Sayı Doğru!");
            }
            else
            {
                Console.WriteLine("Sayı Hatalı!");
            }
            */

            /*
            int exam1, exam2, exam3, average;
            string result = "Hata!"; //Eğer if koşullarının değerleri arasında sonuç çıkmazsa hata verir.
            Console.Write("Sınav1: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("Sınav2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Sınav3: ");
            exam3 = int.Parse(Console.ReadLine());

            average = ((exam1 + exam2 + exam3) / 3);
            Console.WriteLine("Sınavların Ortalaması: " + average);

            if (average > 0 & average <= 50)
            {
                result = "Sonuç Kötü!";
            }
            if (average > 50 & average <= 70)
            {
                result = "Sonuç Orta!";
            }
            if (average > 70 & average <= 84)
            {
                result = "Sonuç İyi!";
            }
            if (average > 84)
            {
                result = "Sonuç Çok İyi!";
            }       
            Console.WriteLine(result);
            */

            /*
            string city;
            Console.Write("Lütfen Şehir İsmi Giriniz: ");
            city = Console.ReadLine();

            if (city == "Adana" | city == "Ankara" | city == "Bursa")
            {
                Console.WriteLine("Şehir Mevcut!");
            }
            else
            {
                Console.WriteLine("Şehir Mevcut Değil!");
            }
            */

            /*
            Console.Write("Lütfen Kullanıcı Adınız Giriniz: ");
            string userName = Console.ReadLine();
            if (userName != "Admin")
            {
                Console.WriteLine("Kullanıcı Adı Kabul Edilemez!");
            }
            else
            {
                Console.WriteLine("Kabul Edildi!");
            }
            */

            #endregion

            #region Mod İşlemleri

            /*
            int number;
            number = 26;
            int result = number % 5; //Mod yüzde işareti ile gösterilir.
            Console.Write(result);
            */

            /*
            Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            int number2 = int.Parse(Console.ReadLine());

            int result = number1 % number2;
            Console.Write("1.Sayının 2.Sayıya Bölümünden Kalan: " + result);
            */

            /*
            Console.Write("Lütfen Sayıyı Giriniz: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0 )
            {
                Console.Write("Sayı Çifttir!");
            }
            else
            {
                Console.Write("Sayı Tektir!");
            }
            */

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            /*
            char team;
            Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            team = char.Parse(Console.ReadLine());
            if (team == 'g' | team == 'G')
            {
                Console.Write("Galatasaray");
            }
            if (team == 'f' | team == 'F')
            {
                Console.Write("Fenerbahçe");
            }
            if (team == 'b' | team == 'B')
            {
                Console.Write("Beşiktaş");
            }
            */

            #endregion

            #region Örnek Proje Uygulaması

            /*
            Console.WriteLine("*** C# Eğitim Kampı Restoran ***");
            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine("1-Ana Yemekler");
            Console.WriteLine("2-Çorbalar");
            Console.WriteLine("3-Pizzalar");
            Console.WriteLine("4-İçecekler");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("--------------");
            Console.WriteLine();

            string menuItem;
            Console.Write("Detayını Görmek İstediğiniz Menü Seçiniz: ");
            menuItem = Console.ReadLine();
            if (menuItem == "1")
            {
                Console.WriteLine();
                Console.WriteLine("-----Ana Yemekler-----");
                Console.WriteLine("1-Kori Soslu Tavuk");
                Console.WriteLine("2-Kızartma Tabağı");
                Console.WriteLine("3-Fasulye Pilav");
                Console.WriteLine("4-Fırın Somon");
                Console.WriteLine("5-Patlıcan Musakka");
                Console.WriteLine();
            }

            if (menuItem == "2")
            {
                Console.WriteLine();
                Console.WriteLine("-----Çorbalar-----");
                Console.WriteLine("1-Mercimek");
                Console.WriteLine("2-Ezogelin");
                Console.WriteLine("3-Yayla");
                Console.WriteLine();
            }

            if (menuItem == "3")
            {
                Console.WriteLine();
                Console.WriteLine("-----Pizzalar-----");
                Console.WriteLine("1-Akdeniz Pizza");
                Console.WriteLine("2-Margarita");
                Console.WriteLine("3-Tavuklu Pizza");
                Console.WriteLine();
            }

            if (menuItem == "4")
            {
                Console.WriteLine();
                Console.WriteLine("-----İçecekler-----");
                Console.WriteLine("1-Kola");
                Console.WriteLine("2-Ayran");
                Console.WriteLine("3-Su");
                Console.WriteLine();
            }

            if (menuItem == "5")
            {
                Console.WriteLine();
                Console.WriteLine("-----Tatlılar-----");
                Console.WriteLine("1-Treliçe");
                Console.WriteLine("2-Kazandibi");
                Console.WriteLine("3-Sütlaç");
                Console.WriteLine();
            }
            */

            #endregion

            #region Switch Case

            /*
            Console.Write("Lütfen Ay Girişi Yapınız: ");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1: Console.Write("Ocak"); break;
                case 2: Console.Write("Şubat"); break;
                case 3: Console.Write("Mart"); break;
                case 4: Console.Write("Nisan"); break;
                case 5: Console.Write("Mayıs"); break;
                case 6: Console.Write("Haziran"); break;
                case 7: Console.Write("Temmuz"); break;
                case 8: Console.Write("Ağustos"); break;
                case 9: Console.Write("Eylül"); break;
                case 10: Console.Write("Ekim"); break;
                case 11: Console.Write("Kasım"); break;
                case 12: Console.Write("Aralık"); break;
                default: Console.Write("Hatalı Veri Girişi!"); break;         
            }
            */

            #endregion

            #region Switch Case Hesap Makinesi

            /*
            int number1, number2, result;
            char symbol;
            Console.Write("1.Sayıyı Giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı Giriniz: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz: +, -, *, /"); 
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.Write(result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.Write(result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.Write(result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.Write(result);
                    break;
                default: Console.Write("Hatalı Veri Girişi!"); break;
            }
            */

            #endregion

            Console.ReadLine();
        }
    }
}
