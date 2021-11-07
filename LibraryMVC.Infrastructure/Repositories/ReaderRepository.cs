using LibraryMVC.Domain.Interface;
using LibraryMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Infrastructure.Repositories
{
    public class ReaderRepository : IReaderRepository
    {

        private readonly Context _context;

        public ReaderRepository(Context context)
        {
            _context = context;
        }

        public int AddReader(Reader reader)
        {
            _context.Readers.Add(reader);
            _context.SaveChanges();
            return reader.Id;
        }

        public IQueryable<Reader> GetAllActiveReaders()
        {
            return _context.Readers.Where(p => p.IsActive);
        }

        public Reader GetReader(int readerId)
        {
            return _context.Readers.FirstOrDefault(p => p.Id == readerId);
        }
    }
}
