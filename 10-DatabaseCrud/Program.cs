using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create - Read - Update - Delete      
            //Console.WriteLine("*** Menü Sipariş İşlem Paneli ***");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine();
            
            #region Kategori Ekleme İşlemi

            /*
            Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            string categoryName = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source = GURKANSKZL; Initial Catalog = MYEgitimKampi; Integrated Security = True");
            connection.Open();
            SqlCommand command = new SqlCommand("Insert Into TblCategory(CategoryName) Values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", categoryName); //Sıralamalar birbiri ile eşleşmeli.
            command.ExecuteNonQuery();

            connection.Close();
            Console.Write("Kategori Başarıyla Eklendi!");           
            */

            #endregion

            #region Ürün Ekleme İşlemi

            /*
            string productName;
            decimal productPrice;
            //bool productStatus;
            Console.Write("Ürün Adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = GURKANSKZL; Initial Catalog = MYEgitimKampi; Integrated Security = True");
            connection.Open();
            SqlCommand command = new SqlCommand("Insert Into TblProduct(ProductName, ProductPrice, ProductStatus) Values (@productName, @productPrice, @productStatus)", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", true);

            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün Eklendi.");
            */

            #endregion

            #region Ürün Listeleme İşlemi

            /*
            SqlConnection connection = new SqlConnection("Data Source = GURKANSKZL; Initial Catalog = MYEgitimKampi; Integrated Security = True");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command); //Köprü Görevi Olarak Kullanılır.
            DataTable dataTable = new DataTable(); //Bellekte tablonun tutulmasını sağlar.
            adapter.Fill(dataTable);

            foreach (DataRow row in dataTable.Rows)
            { 
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + " ");
                }
                Console.WriteLine();
            }
            connection.Close();
            */

            #endregion

            #region Ürün Silme İşlemi

            /*
            Console.Write("Silinicek Ürün ID: ");
            int productId = int.Parse(Console.ReadLine());
            SqlConnection connection = new SqlConnection("Data Source = GURKANSKZL; Initial Catalog = MYEgitimKampi; Integrated Security = True");
            connection.Open();

            SqlCommand command = new SqlCommand("DELETE FROM TblProduct WHERE ProductID = @productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();

            connection.Close();
            Console.WriteLine("Silme İşlemi Yapıldı!");
            */

            #endregion

            #region Ürün Güncelleme İşlemi

            /*
            Console.Write("Güncellenecek Ürün ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = GURKANSKZL; Initial Catalog = MYEgitimKampi; Integrated Security = True");
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductID = @productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.ExecuteNonQuery();

            connection.Close();

            Console.WriteLine("Güncelleme Başarılı!");
            */

            #endregion

            Console.Read();
        }
    }
}
