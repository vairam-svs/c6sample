using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c6Sample
{
    public class Person
    {
        /// <summary>
        /// Auto-property initializers
        /// </summary>
        public int Id { get; set; } = -1;
        /// <summary>
        /// Read-only auto-properties
        /// </summary>
        public string Guid { get; } = (new Guid()).ToString();
        /// <summary>
        /// Ctor assignment to getter-only autoprops
        /// see assignment inside the constructor for a getter only property
        /// </summary>
        public decimal Salary { get; }

        public Person()
        {
            //Ctor assignment to getter-only autoprops
            Salary = 756;
        }
    }
}
