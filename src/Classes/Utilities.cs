using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP3.Classes
{
    class Utilities
    {
        public bool IsValidDateTime(DateTime dateTime)
        {
            return dateTime.Year >= 1970;
        }

        public bool IsValidDateTime(string dateTime)
        {
            try
            {
                return IsValidDateTime(Convert.ToDateTime(dateTime));
            } catch (FormatException)
            {
                return false;
            }
        }

        public bool IsDateTimeIntervalValid(DateTime startDate, DateTime endDate)
        {
            return startDate.CompareTo(endDate) < 0;
        }

        public string GetFormatedDateTime(DateTime dateTime)
        {
            return IsValidDateTime(dateTime) 
                ? dateTime.ToString("dd/MM/yyyy")
                : "N/D";
        }
    }
}
