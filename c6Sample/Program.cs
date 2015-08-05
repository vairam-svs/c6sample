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
            Person p = new Person();
            WriteLine(p.Id);
            WriteLine(p.Guid);
            WriteLine(p.Salary);
            Read();
        }
    }
}
