using AutoMapper;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Web.Models;

namespace CopaFilmes.Web.Mappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Filme, FilmeViewModel>();
        }
    }
}