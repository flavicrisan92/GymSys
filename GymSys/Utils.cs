using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSys
{
    public class Utils
    {
        static LocalDBEntities db = new LocalDBEntities();
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

        public static string GetOnlyDate(DateTime datetimeString)
        {
            string format = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime result;
            try
            {
                result = DateTime.ParseExact(datetimeString.ToString(CultureInfo.InvariantCulture), format, provider);
            }
            catch (FormatException)
            {
                result = DateTime.Parse(datetimeString.ToString(CultureInfo.InvariantCulture));
            }
            return result.ToString(CultureInfo.InvariantCulture);
        }

        public static bool ValidateNewUserAndMembership(int id, string name, string surname, string code, string numericPeriod, int membershipType, Actions.Operations operation)
        {
            if (string.IsNullOrEmpty(code))
            {
                ShowRequiredMessage();
                return false;
            }
            if (operation != Actions.Operations.AddSubscription && db.Members.Any(m => m.Code == code && m.Id != id))
            {
                MessageBox.Show("Acest cod este atasat altui abonat!");
                return false;
            }
            if (string.IsNullOrEmpty(name))
            {
                ShowRequiredMessage();
                return false;
            }
            if (string.IsNullOrEmpty(surname))
            {
                ShowRequiredMessage();
                return false;
            }
            if (numericPeriod == "0")
            {
                ShowRequiredMessage();
                return false;
            }
            if (membershipType < 0)
            {
                ShowRequiredMessage();
                return false;
            }
            return true;
        }

        private static void ShowRequiredMessage()
        {
          
                MessageBox.Show("Campurile marcate cu * sunt obligatorii!");
            
        }
    }
}
