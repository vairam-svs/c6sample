using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Static imports see below writeline and read methods without class prefix.
using static System.Console;

namespace c6Sample
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// String interpolation
        /// </summary>
        /// <param name="p"></param>
        public static void WriteData(this Person p)
        {
            //String interpolation
            WriteLine($"Person Id is {p.Id}");
            WriteLine($"Person Guid is {p.Guid}");
            WriteLine($"Person Salary is {p.Salary}");
        }

        public static bool IsMaxSalaryRise(this Person p)
        {
            if (p.Salary == 1000)
                return true;
            else
                return false;
        }
    }
}
