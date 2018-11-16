using AutoMapper;
using CopaFilmes.Domain.Entities;
using CopaFilmes.Web.Models;

namespace CopaFilmes.Web.Mappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
       public ViewModelToDomainMappingProfile()
        {
            CreateMap<FilmeViewModel, Filme>();
        }
    }
}