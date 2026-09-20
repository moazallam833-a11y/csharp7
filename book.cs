using System;
using System.Collections.Generic;
using System.Text;

namespace csharp7
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    class Book
    {
        public Genre Genre { get; set; }
    }
}
 
