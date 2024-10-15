using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Alt Alta 10 Tane Yıldız Oluşturma

            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("*");
            }
            */

            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma

            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("*");
            }
            */

            #endregion

            #region Alt Alta 10 Tane Yıldız Oluşturma. Her Satırda 10 Tane Yıldız Olsun

            /*
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("**********");
            }
            */

            #endregion

            #region Dik Üçgen

            /*
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
            */

            #endregion

            #region Ters Dik Üçgen

            /*
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            #endregion

            #region Dik ve Ters Dik Üçgen Birlikte

            /*
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int k = 4; k >= 1; k--)
            {
                for (int m = 1; m <= k; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            */

            #endregion

            #region Baklava Dilimi

            /*
            //Üst Kısım
            int n = 5; //Kaç satırdan oluşacak, yani üst kısımda 5 satır olacak.
            for (int i = 1; i <= n; i++) //1'den 5'e kadar (yani n'e kadar) döngü devam eder.
            {
                for (int j = n - 1; j > 0; j--) //Sol Taraftan Boşluk Bırakır.
                {
                    Console.Write(" "); //Boşluk basar.
                }
                for (int k = 1; k <= 2 * i - 1; k++) //Yıldızları basar. Formül: 2 * i - 1, her satırda basılacak yıldız sayısını verir.
                {
                    Console.Write("*"); //Yıldız basar.
                }
                Console.WriteLine(); //Satır sonuna gelindiğinde bir alt satıra geçer.
            }

            //Alt Kısım
            for (int i = n - 1; i >= 1; i--) //Alt kısmı çizmek için döngü başlar. Burada 4'ten 1'e kadar gider (n - 1).
            {
                for(int j = n - 1; j > 0; j--) //Üsttekiyle aynı mantıkta sol tarafta boşluk bırakır. Burada boşluk sayısı artar.
                {
                    Console.Write(" "); //Boşluk basar.
                }
                for (int k = 1; k <= 2 * i - 1; k++) //Yıldızları basar. Üst kısımdaki gibi 2 * i - 1 formülü yıldız sayısını belirler.
                {
                    Console.Write("*"); //Yıldız basar.
                }
                Console.WriteLine(); //Satır sonuna gelindiğinde bir alt satıra geçer.
            }
            */

            #endregion

            #region Piramit

            /*
            int n = 5; //Üçgenin yüksekliği. 'n' değeri üçgenin kaç satır olacağını belirler (burada 5 satır).
            for (int i = 1; i <= n; i++) //Dış döngü: Satırları kontrol eder. İlk satırdan (i=1) son satıra (i=n) kadar döner.
            {
                //Boşluklar
                for (int j = n - i; j > 0; j--) //İç döngü 1: Satır başına kaç boşluk bırakılacağını kontrol eder.
    {
                {
                    Console.Write(" "); //Boşlukları ekrana yazdırır. Üçgen şeklinin düzgün olmasını sağlar.
                }
                //Yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++) //İç döngü 2: Yıldızların sayısını kontrol eder. Her satırda yazılan yıldız sayısı 2*i-1 formülü ile belirlenir.
                {
                    Console.Write("*"); //Yıldızları ekrana yazdırır.
                }
                Console.WriteLine(); //Bir satırdaki tüm boşluklar ve yıldızlar yazıldıktan sonra bir alt satıra geçer.
            }   
            */

            #endregion

            #region Ters Piramit

            /*
            int n = 5; //Üçgenin yüksekliği. 'n' değeri üçgenin kaç satır olacağını belirler (burada 5 satır).
            for (int i = n; i >= 1; i--) //Dış döngü: Satırları kontrol eder. 'i' değeri n'den 1'e kadar (azalan şekilde) döner.
            {
                //Boşluklar
                for (int j = n - i; j > 0; j--) //İç döngü 1: Satır başına kaç boşluk bırakılacağını kontrol eder.
                {
                    Console.Write(" "); //Boşlukları ekrana yazdırır. Üçgen şeklinin düzgün olmasını sağlar.
                }
                //Yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++) //İç döngü 2: Yıldızların sayısını kontrol eder. Her satırda yazılan yıldız sayısı 2*i-1 formülü ile belirlenir.
                {
                    Console.Write("*"); //Yıldızları ekrana yazdırır.
                }
                Console.WriteLine(); //Bir satırdaki tüm boşluklar ve yıldızlar yazıldıktan sonra bir alt satıra geçer.
            }
            */

            #endregion

            Console.Read();
        }
    }
}
