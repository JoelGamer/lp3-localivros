using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP3.Classes.Database
{
    class Purchase : DatabaseRegister
    {
        private Book book;
        private Provider provider;
        private int quantity;

        public Purchase() { }

        public Purchase(int uid) : base(uid) { }

        public Book GetBook()
        {
            return book;
        }

        public void SetBook(Book book)
        {
            this.book = book;
        }

        public Provider GetProvider()
        {
            return provider;
        }

        public void SetProvider(Provider provider)
        {
            this.provider = provider;
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
