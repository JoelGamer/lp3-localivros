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
    class TableClients : Connection
    {
        public List<Client> GetAll()
        {
            List<Client> clients = new List<Client>();
            string command = "SELECT * FROM CLIENTS";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Client client = new Client(sqlDataReader.GetInt32(0));
                    client.SetName(sqlDataReader.GetString(1));
                    client.SetCNPJ(sqlDataReader.GetInt64(2));
                    client.SetAddress(sqlDataReader.GetString(3));
                    client.SetAddressNumber(sqlDataReader.GetString(4));
                    clients.Add(client);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return clients;
        }

        public void CreateClient(Client client)
        {
            string command = "INSERT INTO CLIENTS(name, cnpj, address, address_number) " +
                "VALUES(@name, @cnpj, @address, @address_number)";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@name", client.GetName());
            sqlCommand.Parameters.AddWithValue("@cnpj", client.GetCNPJ());
            sqlCommand.Parameters.AddWithValue("@address", client.GetAddress());
            sqlCommand.Parameters.AddWithValue("@address_number", client.GetAddressNumber());

            sqlCommand.ExecuteNonQuery();
        }

        public void UpdateClient(int uid, Client client)
        {
            string command = "UPDATE CLIENTS SET " +
                "name = @name, cnpj = @cnpj, address = @address, address_number = @address_number " +
                "WHERE uid = @uid";
            SqlCommand sqlCommand = GenerateSqlCommand(command);

            sqlCommand.Parameters.AddWithValue("@uid", uid);
            sqlCommand.Parameters.AddWithValue("@name", client.GetName());
            sqlCommand.Parameters.AddWithValue("@cnpj", client.GetCNPJ());
            sqlCommand.Parameters.AddWithValue("@address", client.GetAddress());
            sqlCommand.Parameters.AddWithValue("@address_number", client.GetAddressNumber());

            sqlCommand.ExecuteNonQuery();
        }

        public void DeleteClient(Client client)
        {
            string command = "DELETE FROM CLIENTS WHERE uid=" + client.GetUid();
            GenerateSqlCommand(command).ExecuteNonQuery();
        }
    }
}
