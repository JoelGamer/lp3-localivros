using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP3.Classes.Database
{
    class Client : DatabaseRegister
    {
        private string name;
        private long cnpj;
        private string address;
        private string addressNumber;

        public Client() { }

        public Client(int uid) : base(uid) { }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public long GetCNPJ()
        {
            return cnpj;
        }

        public void SetCNPJ(long cnpj)
        {
            this.cnpj = cnpj;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetAddressNumber()
        {
            return addressNumber;
        }

        public void SetAddressNumber(string addressNumber)
        {
            this.addressNumber = addressNumber;
        }
    }
}
