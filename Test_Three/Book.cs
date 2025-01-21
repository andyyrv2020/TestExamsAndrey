using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Three
{
    public class Book
    {
        private string title;
        private string author;
        private int pages;

        public string Title
        {
            get { return title; }
            private set { title = value; }
        }
        public string Author
        {
            get { return author; }
            private set { author = value; }
        }
        public int Pages
        {
            get { return pages; }
            private set { pages = value; }
        }
    }
}
