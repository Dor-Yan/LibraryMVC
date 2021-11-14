using AutoMapper;
using LibraryMVC.Application.Mapping;
using LibraryMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.ViewModels.Book
{ 
    public class BookForListVm : IMapFrom<LibraryMVC.Domain.Model.Book>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<LibraryMVC.Domain.Model.Book, BookForListVm>();
        }

    }
}
