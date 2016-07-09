using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSys
{
    public class Utils
    {
        public static DateTime GetDateTimeParsed(string datetimeString)
        {
            if (!datetimeString.Contains(":"))
            {
                datetimeString += " 00:00:01";
            }
            string format = "dd/MM/yyyy HH:mm:ss";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime result;
            try
            {
                result = DateTime.ParseExact(datetimeString, format, provider);
            }
            catch (FormatException)
            {
                result = DateTime.MaxValue;
            }
            return result;
        }

        public static bool ValidateNewUserAndMembership(string name, string surname, string code, string numericPeriod, int membershipType)
        {
            if (string.IsNullOrEmpty(code))
            {
                return false;
            }
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (string.IsNullOrEmpty(surname))
            {
                return false;
            }
            if (numericPeriod == "0")
            {
                return false;
            }
            if (membershipType < 0)
            {
                return false;
            }
            return true;
        }
    }
}
