using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TrabalhoLP3.Classes;

namespace TrabalhoLP3.Database.Tables
{
    class TableUsers : Connection
    {
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            string command = "SELECT * FROM USERS";

            SqlCommand sqlCommand = GenerateSqlCommand(command);
            DataTable dataTable = GenerateDataTable(command);

            if (dataTable.Rows.Count > 0)
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    User user = new User(sqlDataReader.GetInt32(0));
                    user.SetUsername(sqlDataReader.GetString(1));
                    user.SetName(sqlDataReader.GetString(3));
                    user.SetCPF(sqlDataReader.GetInt32(4));
                    users.Add(user);
                }
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return users;
        }
        
        public void CreateUser(User user, string password)
        {
            string command = "INSERT INTO USERS(name, username, password, cpf) " +
                "VALUES('" + user.GetName() + "', '" + user.GetUsername() + "', '" + password + "', " + user.GetCPF() + ")";
            GenerateSqlCommand(command).ExecuteNonQuery();
        }

        public bool IsValidLogin(string username, string password)
        {
            string command = "SELECT * FROM USERS WHERE username='" + username +  "' AND password='" + password +"';";

            DataTable dataTable = GenerateDataTable(command);

            if(dataTable.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
