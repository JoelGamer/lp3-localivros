using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP3.Classes.Database
{
    class Sale : DatabaseRegister
    {
        private Book book;
        private Client client;
        private int quantity;

        public Sale() { }

        public Sale(int uid) : base(uid) { }

        public Book GetBook()
        {
            return book;
        }

        public void SetBook(Book book)
        {
            this.book = book;
        }

        public Client GetClient()
        {
            return client;
        }

        public void SetClient(Client client)
        {
            this.client = client;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
    }
}
