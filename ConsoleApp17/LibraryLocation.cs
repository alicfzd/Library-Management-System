using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{

    public struct LibraryLocation
    {
        public int Aisle { get; }
        public int Shelf { get; }

        public LibraryLocation(int aisle, int shelf)
        {
            Aisle = aisle;
            Shelf = shelf;
        }
    }
}
 
