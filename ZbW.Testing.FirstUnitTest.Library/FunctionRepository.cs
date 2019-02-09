using System;
using System.Text.RegularExpressions;

namespace ZbW.Testing.FirstUnitTest.Library
{
    public class FunctionRepository
    {
        public bool GreaterThan10(int value)
        {
            var result = value > 10;
            return result;
        }

        public bool IsValidEMailadress(string email)
        {
            var regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$",
                RegexOptions.Compiled);
            return regex.IsMatch(email);
        }

        public bool IsStringLongerThan10(string value)
        {
            var result = value.Length > 10;
            return result;
        }

        public int GetStringLength(string value)
        {
            var result = value.Length;
            return result;
        }

        public bool AreNumbersInString(string value)
        {
            string strNummer = string.Empty;
            foreach (char numChar in value.ToCharArray())
            {
                if (Char.IsNumber(numChar)) strNummer += numChar.ToString();
            }

            if (strNummer.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

//        public string ToUpperString(string value)
//        {
//
//        }

        public bool IsIntValid(string value)
        {
            int value1;
            if (int.TryParse(value, out value1))
            {
                return true;
            }
            else
            {
                return false;
            }
   

        }
    }
}