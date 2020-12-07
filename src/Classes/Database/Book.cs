using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoLP3.Classes.Database;

namespace TrabalhoLP3.Classes.Database
{
    class Book : DatabaseRegister
    {
        private string name;
        private string descripton;
        private Author author;
        private int pages;
        private Genre genre;
        private DateTime releaseDate;
        private double price;

        public Book() { }

        public Book(int uid) : base(uid) { }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetDescription()
        {
            return descripton;
        }

        public void SetDescripton(string descripton)
        {
            this.descripton = descripton;
        }

        public Author GetAuthor()
        {
            return author;
        }

        public void SetAuthor(Author author)
        {
            this.author = author;
        }

        public int GetPages()
        {
            return pages;
        }

        public void SetPages(int pages)
        {
            this.pages = pages;
        }

        public Genre GetGenre()
        {
            return genre;
        }

        public void SetGenre(Genre genre)
        {
            this.genre = genre;
        }

        public DateTime GetReleaseDate()
        {
            return releaseDate;
        }

        public void SetReleaseDate(DateTime releaseDate)
        {
            this.releaseDate = releaseDate;
        }

        public double GetPrice()
        {
            return price;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }
    }
}
