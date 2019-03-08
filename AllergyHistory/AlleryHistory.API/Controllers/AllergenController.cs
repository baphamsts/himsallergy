using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlleryHistory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergenController : ControllerBase
    {
        private readonly IAllergenInputService allergenInputService;

        public AllergenController(IAllergenInputService allergenInputService)
        {
            this.allergenInputService = allergenInputService;
        }

        // GET api/allergen/reactions
        [HttpGet("reactions")]
        public ActionResult<IEnumerable<string>> GetAllegenReactions()
        {
            var data = allergenInputService.GetAllAllergenReaction();
            return Ok(data);
        }

        // GET api/allergen/severties
        [HttpGet("severties")]
        public ActionResult<IEnumerable<AllergenSeverityViewModel>> GetAllegenSeverties()
        {
            var data = allergenInputService.GetAllAllergenSeverity();
            return Ok(data);
        }


        // GET api/allergen/medications
        [HttpGet("medications")]
        public ActionResult<IEnumerable<string>> GetMedications()
        {
            var data = allergenInputService.GetAllMedication();
            return Ok(data);
        }



        // GET api/allergen/types
        [HttpGet("types")]
        public ActionResult<IEnumerable<string>> GetAllegenTypes()
        {
            var data = allergenInputService.GetAllAllergenType();
            return Ok(data);
        }

        // GET api/allergen/allergens
        [HttpGet("allergens")]
        public ActionResult<IEnumerable<string>> GetAllegens()
        {
            var data = allergenInputService.GetAllAllergen();
            return Ok(data);
        }
    }
}
