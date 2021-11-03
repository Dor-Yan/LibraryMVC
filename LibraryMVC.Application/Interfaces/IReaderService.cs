using LibraryMVC.Application.ViewModels.Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Interfaces
{
    public interface IReaderService
    {
        ListReaderForListVm GetAllReadersForList(int pageSize, int pageNo, string searchString);

        int AddReader(NewReaderVm reader);

        ReaderDetailsVm GetReaderDetails(int readerId);
    }
}
