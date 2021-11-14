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

        public void UpdateReader(Reader reader)
        {
            _context.Attach(reader);
            _context.Entry(reader).Property("Name").IsModified = true;
            _context.Entry(reader).Property("Street").IsModified = true;
            _context.Entry(reader).Property("BuildingNumber").IsModified = true;
            _context.Entry(reader).Property("ZipCode").IsModified = true;
            _context.Entry(reader).Property("City").IsModified = true;
            _context.Entry(reader).Property("PhoneNumber").IsModified = true;
            _context.Entry(reader).Property("EmailAdress").IsModified = true;
            _context.Entry(reader).Property("IsActive").IsModified = true;
            _context.SaveChanges();
        }
    }
}
