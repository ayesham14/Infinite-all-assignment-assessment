using cca_last.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace cca_last.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private static List<Country> countries = new List<Country>
             {
                 new Country { ID = 1, CountryName = "Germany", Capital = "Berlin" },
                 new Country { ID = 2, CountryName = "Itily", Capital = "Rome" }
             };

        [HttpGet]
        public ActionResult<IEnumerable<Country>> GetCountries()
        {
            return Ok(countries);
        }

        [HttpGet("{id}")]
        public ActionResult<Country> GetCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        [HttpPost]
        public ActionResult<Country> PostCountry(Country country)
        {
            country.ID = countries.Max(c => c.ID) + 1;
            countries.Add(country);
            return CreatedAtAction(nameof(GetCountry), new { id = country.ID }, country);
        }

        [HttpPut("{id}")]
        public IActionResult PutCountry(int id, Country updatedCountry)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            country.CountryName = updatedCountry.CountryName;
            country.Capital = updatedCountry.Capital;
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCountry(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
            {
                return NotFound();
            }
            countries.Remove(country);
            return NoContent();
        }
    }
}