using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP3.Classes.Database
{
    class Genre : DatabaseRegister
    {
        private string name;

        public Genre() { }

        public Genre(int uid) : base(uid) { }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
    }
}
