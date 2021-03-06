using System;
using System.Globalization;

namespace ExtensionsMethods.Extensions
{
    static class DateTimeExtensions
    {
        /*
         * Um metodo que subtrai a data de agora 
         * pela data passada como parametro no atributo DateTime
         */
        public static string ElapsedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}
