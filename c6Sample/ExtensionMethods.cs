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
        /// nameof-operator 
        /// nameof-operator and string interpolation: a type-safe way of coding expressions inside formatting 
        /// </summary>
        /// <param name="p"></param>
        public static void WriteData(this Person p)
        {
            //String interpolation
            //http://stackoverflow.com/questions/301809/workarounds-for-nameof-operator-in-c-typesafe-databinding
            WriteLine($"{nameof(Person)}.{nameof(Person.Id)} is {p.Id}");
            WriteLine($"{nameof(Person)}.{nameof(Person.Guid)} is {p.Guid}");
            WriteLine($"{nameof(Person)}.{nameof(Person.Name)}: {p.Name}'s salary is {p.Salary}");
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
