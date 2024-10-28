using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Book : LibraryItem
    {
        public BookGenre Genre { get; }
        public LibraryLocation LibraryLocation { get; }

        public Book(string title, int? publicationYear, BookGenre genre, LibraryLocation location)
            : base(title, publicationYear)
        {
            Genre = genre;
            LibraryLocation = location;
 
       }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title}, Genre: {Genre}, Year: {PublicationYear}, Location: Aisle {LibraryLocation.Aisle}, Shelf {LibraryLocation.Shelf}");
        }
    }
}
