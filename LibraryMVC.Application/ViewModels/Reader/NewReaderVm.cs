using AutoMapper;
using FluentValidation;
using LibraryMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMVC.Application.ViewModels.Reader
{
    public class NewReaderVm : IMapFrom<LibraryMVC.Domain.Model.Reader>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PESEL { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewReaderVm, LibraryMVC.Domain.Model.Reader>();
        }
    }

    public class NewReaderValidation : AbstractValidator<NewReaderVm>
        {
        public NewReaderValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.PESEL).Length(11);
            RuleFor(x => x.Name).MaximumLength(20);
        }
    }
}
