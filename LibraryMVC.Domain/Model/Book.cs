using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string DateOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public int ISBN { get; set; }
        public int TypeId { get; set; }

        public virtual Type Type { get; set; }

        public ICollection<BookTag> BookTags { get; set; }
        public ICollection<BookWriter> BookWriters { get; set; }
    }
}
