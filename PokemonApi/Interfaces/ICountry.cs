namespace PokemonReviewApp.Interfaces
{
    using PokemonReviewApp.Models;
    using System.Collections.Generic;
    public interface ICountryRepository
    {
        List<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        List<Owner> GetCountryFromOwners(int countryId);
        bool CountryExists(int Id);
        bool CreateCountry(Country country);
        bool UpdateCountry(Country country);
        bool DeleteCountry(Country country);
    }
}