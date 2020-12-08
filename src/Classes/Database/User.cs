using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP3.Classes.Database
{
    class User : DatabaseRegister
    {
        private string name;
        private string username;
        private string password;
        private long cpf;

        public User() { }

        public User(int uid) : base(uid) { }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name) 
        {
            this.name = name;    
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public long GetCPF()
        {
            return cpf;
        }

        public void SetCPF(long cpf)
        {
            this.cpf = cpf;
        }
    }
}
