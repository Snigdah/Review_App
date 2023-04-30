using AutoMapper;
using PokemonProject.Dto;
using PokemonProject.Models;

namespace PokemonProject.Helper
{
    public class MappingProfiles : Profile 
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<CountryDto, Country>();
        }
    }
}
