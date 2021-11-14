using AutoMapper;
using LibraryMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.ViewModels.Book
{
    public class WriterForListVm : IMapFrom<LibraryMVC.Domain.Model.Writer>
    {
        public int Id { get; set; }
        public string Writer { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<LibraryMVC.Domain.Model.Writer, WriterForListVm>();
        }
    }
}
