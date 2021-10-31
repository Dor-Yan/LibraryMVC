using AutoMapper;
using LibraryMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.ViewModels.Reader
{
    public class ReaderForListVm : IMapFrom<LibraryMVC.Domain.Model.Reader>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PESEL { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<LibraryMVC.Domain.Model.Reader, ReaderForListVm>();
        }
    }
}
