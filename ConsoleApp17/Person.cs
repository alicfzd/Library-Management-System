using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public abstract class Person
    {
        public int Id { get; }
        public string Name { get; }

        protected Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}

