using AutoMapper;
using AutoMapper.QueryableExtensions;
using LibraryMVC.Application.Interfaces;
using LibraryMVC.Application.ViewModels.Reader;
using LibraryMVC.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.Services
{
    public class ReaderService : IReaderService
    {

        private readonly IReaderRepository _readerRepo;
        private readonly IMapper _mapper;

        public ReaderService(IReaderRepository readerRepo, IMapper mapper)
        {
            _readerRepo = readerRepo;
            _mapper = mapper;
        }
        public int AddReader(NewReaderVm reader)
        {
            throw new NotImplementedException();
        }

        public ListReaderForListVm GetAllReadersForList(int pageSize, int pageNo, string searchString)
        {
            var readers = _readerRepo.GetAllActiveReaders().Where(p => p.Name.StartsWith(searchString))
                .ProjectTo<ReaderForListVm>(_mapper.ConfigurationProvider).ToList(); //ProjectTo w przypadku kolekcji

            var readerToShow = readers.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();

            var readerList = new ListReaderForListVm()
            {
                PageSize = pageSize,
                CurrentPage = pageNo,
                SearchString = searchString,
                Readers = readerToShow,
                Count = readers.Count
            };

            return readerList;

            //ListReaderForListVm result = new ListReaderForListVm();
            //result.Readers = new List<ReaderForListVm>();
            //foreach(var reader in readers)
            //{
            //    var readVm = new ReaderForListVm()
            //    {
            //        Id = reader.Id,
            //        Name = reader.Name,
            //        PESEL = reader.PESEL
            //    };
            //    result.Readers.Add(readVm);
            //}

            //result.Count = result.Readers.Count;
            //return result;
        }

        public ReaderDetailsVm GetReaderDetails(int readerId)
        {
            var reader = _readerRepo.GetReader(readerId);

            var readerVm = _mapper.Map<ReaderDetailsVm>(reader); // Map w przypadku pojedyńczych elementów

            //var readerVm = new ReaderDetailsVm();
            //readerVm.Id = reader.Id;
            //readerVm.Name = reader.Name;
            //readerVm.PESEL = reader.PESEL;
            //readerVm.PhoneNumber = reader.PhoneNumber;
            //readerVm.EmailAdress = reader.EmailAdress;
            //readerVm.Street = reader.Street;
            //readerVm.BuildingNumber = reader.BuildingNumber;
            //readerVm.ZipCode = reader.ZipCode;
            //readerVm.City = reader.City;

            return readerVm;
        }
    }
}
