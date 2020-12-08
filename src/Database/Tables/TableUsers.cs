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
                    user.SetPassword(sqlDataReader.GetString(2));
                    user.SetName(sqlDataReader.GetString(3));
                    user.SetCPF(sqlDataReader.GetInt64(4));
                    users.Add(user);
                }

                sqlDataReader.Close();
            }

            sqlCommand.Dispose();
            dataTable.Dispose();
            return users;
        }
        
        public void CreateUser(User user)
        {
            string command = "INSERT INTO USERS(name, username, password, cpf) " +
                "VALUES('" + user.GetName() + "', '" + user.GetUsername() + "', '" + user.GetPassword() + "', " + user.GetCPF() + ")";
            GenerateSqlCommand(command).ExecuteNonQuery();
        }

        public void UpdateUser(int uid, User user)
        {
            string command = "UPDATE USERS SET " +
                "name='" + user.GetName() + "', " +
                "username='" + user.GetUsername() + "', " +
                "password='" + user.GetPassword() + "', " +
                "cpf=" + user.GetCPF() + " " +
                "WHERE uid=" + uid.ToString();

            GenerateSqlCommand(command).ExecuteNonQuery();
        }

        public void DeleteUser(User user)
        {
            string command = "DELETE FROM users WHERE uid=" + user.GetUid();
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
