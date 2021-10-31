using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Model
{
    public class Writer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BookWriter> BookWriters { get; set; }
    }
}
