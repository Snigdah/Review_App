using AutoMapper;
using PokemonProject.Data;
using PokemonProject.Interfaces;
using PokemonProject.Models;

namespace PokemonProject.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;


        public CountryRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool CountryExists(int id)
        {
            return _context.Countries.Any(c => c.Id == id);
        }

        public ICollection<Country> GetCountries()
        {
            var p = _context.Countries.ToList();
            
            return p;
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.Where(c => c.Id == id).FirstOrDefault();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).Select(c => c.Country).FirstOrDefault();
        }

        public int getiddd(string s1, string s2)
        {
           if(s1 == "max")
            {
                return s2.Count();
            }

            return 0;
        }

        public ICollection<Owner> GetOwnersFromACountry(int countryId)
        {
            return _context.Owners.Where(c => c.Country.Id == countryId).ToList();
        }
    }
}
