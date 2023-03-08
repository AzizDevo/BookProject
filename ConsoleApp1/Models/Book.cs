using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Book
    {
        public string Name { get; set; }
        public int PageCount { get; set; }

        public Book(string name, int pageCount)
        {
            Name = name;
            PageCount = pageCount;
        }
    }
}
