using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Model
{
    public class BookWriter
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int WriterId { get; set; }
        public Writer Writer { get; set; }


    }
}
