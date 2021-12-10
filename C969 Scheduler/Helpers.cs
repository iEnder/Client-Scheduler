using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C969_Scheduler
{
    public static class Helpers
    {
        public static string SanitizeForSql(string text)
        {
            return text.Replace("'", "''");
        }

        public static void WriteLog(string text)
        {
            string path = "log.txt";
            if(File.Exists(path))
            {
                File.AppendAllText(path, Environment.NewLine + text);
            } else
            {
                File.WriteAllText(path, text);
            }
        }

        // LAMBDA - simplify function expression
        public static Func<DateTime, DateTime> ToLocal = (date) => TimeZone.CurrentTimeZone.ToLocalTime(date);

        // LAMBDA - simplify function expression
        public static Func<DateTime, DateTime> ToUtc = (date) => TimeZone.CurrentTimeZone.ToUniversalTime(date);
    }
}
