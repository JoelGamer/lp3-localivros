using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP3.Classes.Database
{
    class Author : DatabaseRegister
    {
        private string name;
        private DateTime birthDate;
        private DateTime deathDate;

        public Author() { }

        public Author(int uid) : base(uid) { }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public DateTime GetBirthDate()
        {
            return birthDate;
        }

        public void SetBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }

        public DateTime GetDeathDate()
        {
            return deathDate;
        }

        public void SetDeathDate(DateTime deathDate)
        {
            this.deathDate = deathDate;
        }
    }
}
