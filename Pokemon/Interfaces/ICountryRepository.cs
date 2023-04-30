using PokemonProject.Models;

namespace PokemonProject.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId);
        bool CountryExists(int id);
        int getiddd(string s1 , string s2);
    }
}
