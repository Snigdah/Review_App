using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonProject.Data;
using PokemonProject.Dto;
using PokemonProject.Interfaces;
using PokemonProject.Models;

namespace PokemonProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public CountryController(ICountryRepository countryRepository, IMapper mapper, DataContext context)
        {
            _countryRepository = countryRepository;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet("{s}/{s1}")]
        [ProducesResponseType(200, Type = typeof(Country))]
        public int GetIdsssssss( string s, string s1)
        {
            var c = _countryRepository.getiddd(s, s1);
            

            return c;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Country>))]
        public IActionResult GetCountries()
        {
           // var countries = _mapper.Map<List<CountryDto>>(_countryRepository.GetCountries());

            var countries = _countryRepository.GetCountries();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(countries);
        }

        [HttpGet("{countryId}")]
        [ProducesResponseType(200, Type = typeof(Country))]
        [ProducesResponseType(400)]
        public IActionResult GetCountry(int countryId)
        {
            if (!_countryRepository.CountryExists(countryId))
                return NotFound();

            // var country = _mapper.Map<CountryDto>(_countryRepository.GetCountry(countryId));

            var country = _countryRepository.GetCountry(countryId);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(country);
        }

        [HttpGet("/owners/{ownerId}")]
        [ProducesResponseType(400)]
        [ProducesResponseType(200, Type = typeof(Country))]
        public IActionResult GetCountryOfAnOwner(int ownerId)
        {
            var country = _mapper.Map<CountryDto>(_countryRepository.GetCountryByOwner(ownerId));

            if (!ModelState.IsValid)
                return BadRequest();

            return Ok(country);
        }

    }
}
