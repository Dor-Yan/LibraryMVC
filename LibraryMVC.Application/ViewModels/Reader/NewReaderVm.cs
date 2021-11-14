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
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewReaderVm, LibraryMVC.Domain.Model.Reader>().ReverseMap();
        }
    }

    public class NewReaderValidation : AbstractValidator<NewReaderVm>
        {
        public NewReaderValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.PESEL).Length(11).NotEmpty();
            RuleFor(x => x.Name).MaximumLength(20).NotEmpty();
            RuleFor(x => x.PhoneNumber).NotEmpty();
            RuleFor(x => x.EmailAdress).EmailAddress().NotEmpty();
            RuleFor(x => x.BuildingNumber).NotEmpty();
            RuleFor(x => x.City).NotEmpty();
        }
    }
}
