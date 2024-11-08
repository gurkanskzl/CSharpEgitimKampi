using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ado.net

            /*
            Console.WriteLine("*** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi ***");
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine();
            Console.Write("lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");  
            tableNumber = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            SqlConnection connection = new SqlConnection("Data Source = GURKANSKZL; Initial Catalog = MYEgitimKampi; Integrated Security = True");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            */

            #endregion

            Console.Read();           
        }
    }
}
