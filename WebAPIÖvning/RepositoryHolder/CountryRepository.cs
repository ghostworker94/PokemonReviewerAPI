namespace PokemonReviewApp.RepositoryHolder
{
    using Microsoft.EntityFrameworkCore;
    using PokemonReviewApp.Data;
    using PokemonReviewApp.Interfaces;
    using PokemonReviewApp.Models;
    using global::AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;

    public class CountryRepository : ICountryRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;
        public CountryRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool CountryExists(int id)
        {
            return _context.Countries.Any(c => c.Id == id);
        }

        public bool CreateCountry(Country country)
        {

            _context.Add(country);
            return Save();
        }

        public bool DeleteCountry(Country country)
        {
            _context.Remove(country);
            return Save();
        }

        public List<Country> GetCountries()
        {
            return _context.Countries.ToList();
        }

        public Country GetCountry(int id)
        {
            return _context.Countries.Where(p => p.Id == id).FirstOrDefault();
        }

        public Country GetCountryByOwner(int ownerId)
        {
            return _context.Owners.Where(p => p.Id == ownerId).Select(c => c.Country).FirstOrDefault();
        }

        public List<Owner> GetCountryFromOwners(int countryId)
        {
            return _context.Owners.Where(p => p.Country.Id == countryId).ToList();
        }

        public bool UpdateCountry(Country country)
        {
            _context.Update(country);
            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}