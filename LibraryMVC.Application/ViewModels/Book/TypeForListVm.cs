using AutoMapper;
using LibraryMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.ViewModels.Book
{
    public class TypeForListVm : IMapFrom<LibraryMVC.Domain.Model.Type>
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<LibraryMVC.Domain.Model.Type, TypeForListVm>();
                
        }
    }
}
