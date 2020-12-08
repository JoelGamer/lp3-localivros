using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TrabalhoLP3.Classes.Database;

namespace TrabalhoLP3.Database.Tables
{
    class TablePurchases : Connection
    {
        public List<Purchase> GetAll()
        {
            List<Purchase> purchases = new List<Purchase>();
            string command = "SELECT * FROM PURCHASES";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Purchase purchase = new Purchase(sqlDataReader.GetInt32(0));
                    purchase.SetBook(new TableBooks().GetBook(sqlDataReader.GetInt32(1)));
                    purchase.SetProvider(new TableProviders().GetProvider(sqlDataReader.GetInt32(2)));
                    purchase.SetQuantity(sqlDataReader.GetInt32(3));
                    purchases.Add(purchase);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return purchases;
        }

        public Purchase GetPurchase(int uid)
        {
            Purchase purchase = new Purchase(uid);
            string command = "SELECT * FROM PURCHASES WHERE uid=" + purchase.GetUid().ToString();

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    purchase.SetBook(new TableBooks().GetBook(sqlDataReader.GetInt32(1)));
                    purchase.SetProvider(new TableProviders().GetProvider(sqlDataReader.GetInt32(2)));
                    purchase.SetQuantity(sqlDataReader.GetInt32(3));
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return purchase;
        }

        public void CreateProvider(Purchase purchase)
        {
            string command = "INSERT INTO PURCHASES(book_uid, provider_uid, quantity) " +
                "VALUES(@book_uid, @provider_uid, @quantity)";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@book_uid", purchase.GetBook().GetUid());
            sqlCommand.Parameters.AddWithValue("@provider_uid", purchase.GetProvider().GetUid());
            sqlCommand.Parameters.AddWithValue("@quantity", purchase.GetQuantity());

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateProvider(int uid, Purchase purchase)
        {
            string command = "UPDATE PURCHASES SET " +
                "book_uid = @book_uid, provider_uid = @provider_uid, quantity = @quantity " +
                "WHERE uid = @uid";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@uid", uid);
            sqlCommand.Parameters.AddWithValue("@book_uid", purchase.GetBook().GetUid());
            sqlCommand.Parameters.AddWithValue("@provider_uid", purchase.GetProvider().GetUid());
            sqlCommand.Parameters.AddWithValue("@quantity", purchase.GetQuantity());

            sqlCommand.ExecuteNonQuery();
        }

        public void DeletePurchase(Purchase purchase)
        {
            string command = "DELETE FROM PURCHASES WHERE uid=" + purchase.GetUid();
            GenerateSqlCommand(command).ExecuteNonQuery();
        }
    }
}
