using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Christmas();
           

        }

        public static int Christmas()
        {
            DateTime a = DateTime.Now;
            int f = a.Year;
            DateTime b = Convert.ToDateTime("24-12-" + f);
            TimeSpan c = b - a;
            int ab = c.Days;

            return ab;

        }
    }
}
