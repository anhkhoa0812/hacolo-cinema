using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Validation
    {
        private const string DIGIT_EXPRESSION = @"^\d+$";
        private const string DECIMAL_EXPRESSION = @"^-?\d*(\.\d+)?$";
        private const string EMAIL_EXPRESSION = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
        public static bool IsMail(string email)
        {
            if (email.Length > 254)
            {
                return false;
            }
            if (email.StartsWith(".") || email.EndsWith("."))
            {
                return false;
            }
            string pattern = @"^[^\.][\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public static bool IsNumberic(string value)
        {
            bool isNumberic = Regex.IsMatch(value, DIGIT_EXPRESSION);
            return isNumberic;
        }
        public static bool IsDecimal(string value)
        {
            bool isDecimal = Regex.IsMatch(value, DECIMAL_EXPRESSION);
            return isDecimal;
        }
        public static bool CheckStartEndDate(DateTime startDate, DateTime endDate)
        {
            return startDate <= endDate;
        }
        public static bool IsByte(string value)
        {
            byte result;
            bool isByte = Byte.TryParse(value, out result);
            return isByte;
        }
    }
}
