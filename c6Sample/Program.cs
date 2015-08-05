using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Static imports see below writeline and read methods without class prefix.
using static System.Console;
namespace c6Sample
{
    /// <summary>
    /// https://github.com/dotnet/roslyn/wiki/Languages-features-in-C%23-6-and-VB-14
    /// http://davefancher.com/2015/07/17/my-5-favorite-c-6-0-features/
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Joe");
            p.WriteData();
            Person p1 = null;
            //Null-conditional operators 
            //especially helpful when tagging an extension method that you would call
            //helpful when you are patching a large code base and not sure if the variable is having null or not.
            //or say if you are working with deserialized object in a api where an object property is declared nullable
            //and would have to perform null checks and then call the method on that class.
            bool isMaxSalary = p1?.IsMaxSalaryRise() ?? false;
            WriteLine(isMaxSalary + "is false");
            p1?.WriteData();//p1.WriteData() will result in null object reference
            Read();
        }

    }
}
