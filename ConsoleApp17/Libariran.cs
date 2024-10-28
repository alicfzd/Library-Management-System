using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Librarian : Person
    {
        public DateTime HireDate { get; }

        public Librarian(int id, string name, DateTime hireDate) : base(id, name)
        {
            HireDate = hireDate;
        }
    }
}
