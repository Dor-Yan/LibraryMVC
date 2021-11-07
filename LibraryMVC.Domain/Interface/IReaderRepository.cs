using LibraryMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Domain.Interface
{
    public interface IReaderRepository
    {
        IQueryable<Reader> GetAllActiveReaders();
        Reader GetReader(int readerId);

        int AddReader(Reader reader);
    }
}
