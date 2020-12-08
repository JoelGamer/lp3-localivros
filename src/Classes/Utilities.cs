using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string GetStringifiedMaskedTextBox(MaskedTextBox maskedTextBox)
        {
            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string stringifiedText = maskedTextBox.Text;
            maskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return stringifiedText;
        }

        public string ConvertToCurrency(double value)
        {
            return value.ToString("C");
        }

        public string ConvertToCurrency(string value)
        {
            return ConvertToCurrency(Convert.ToDouble(value));
        }
    }
}
