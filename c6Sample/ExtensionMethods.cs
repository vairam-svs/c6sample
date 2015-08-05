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
        public static void WriteData(this Person p)
        {
            WriteLine(p.Id);
            WriteLine(p.Guid);
            WriteLine(p.Salary);
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
