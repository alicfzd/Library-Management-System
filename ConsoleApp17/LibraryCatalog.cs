using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{

    public class LibraryCatalog
    {
        private LibraryItem[] _items = new LibraryItem[10]; 
        private int _currentIndex = 0;

        public void AddItem(LibraryItem item)
        {
            if (_currentIndex >= _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2); 
            }
            _items[_currentIndex++] = item; 
        }

        public LibraryItem GetItem(int id)
        {
            if (id < 0 || id >= _currentIndex)
            {
                return null;
            }
            return _items[id]; 
        }
    }
}

