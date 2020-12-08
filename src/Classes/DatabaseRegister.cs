using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP3.Classes
{
    class DatabaseRegister
    {
        private readonly int uid;

        public DatabaseRegister() { }

        public DatabaseRegister(int uid)
        {
            this.uid = uid;
        }

        public int GetUid()
        {
            return uid;
        }
    }
}
