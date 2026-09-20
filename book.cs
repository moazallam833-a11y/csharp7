using System;
using System.Collections.Generic;
using System.Text;

namespace csharp7
{
    enum Genre
    {
        Fiction = 0,
        NonFiction=1,
        Science=2
    }
    class Book
    {
        public Genre Genre { get; set; }
    }
}
 
