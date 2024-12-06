using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillerødSejlKlub.Data
{
    public static class BoatMaintenanceLog
    {
        private static List<string> log = new List<string>();

        public static void Save(string message)
        {
            log.Add(message);
        }

        public static void PrintLog()
        {
            Console.WriteLine("Maintenance Log");
            Console.WriteLine("----------------------------------------");

            foreach (string s in log)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }
    }
}
