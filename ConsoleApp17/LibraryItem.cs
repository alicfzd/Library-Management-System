using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public abstract class LibraryItem
    {
        public string Title { get; }
        public int? PublicationYear { get; }

        protected LibraryItem(string title, int? publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public abstract void DisplayInfo();
    }

}
