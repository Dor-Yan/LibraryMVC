using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.ViewModels.Book
{
    public class ListWriterForListVm
    {
        public List<WriterForListVm> Writers { get; set; }
        public int Count { get; set; }
    }
}
