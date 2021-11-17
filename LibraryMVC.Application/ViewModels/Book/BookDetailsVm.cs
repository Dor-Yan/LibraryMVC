using AutoMapper;
using LibraryMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.ViewModels.Book
{
    public class BookDetailsVm : IMapFrom<LibraryMVC.Domain.Model.Book>
    {
        public int Id { get; set; }
        public TypeForListVm Type { get; set; }
        public string Title { get; set; }
        public List<WriterForListVm> Writers { get; set; }
        public string Publisher { get; set; }
        public string DateOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public string ISBN { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<LibraryMVC.Domain.Model.Book, BookDetailsVm>();
                
        }

    }
}
