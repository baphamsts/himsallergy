using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlleryHistory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergenController : ControllerBase
    {
        // GET api/allergen/reactions
        [HttpGet("reactions")]
        public ActionResult<IEnumerable<string>> GetAllegenReactions()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/allergen/severties
        [HttpGet("severties")]
        public ActionResult<IEnumerable<string>> GetAllegenSeverties()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/allergen/medications
        [HttpGet("medications")]
        public ActionResult<IEnumerable<string>> GetMedications()
        {
            return new string[] { "value1", "value2" };
        }



        // GET api/allergen/types
        [HttpGet("types")]
        public ActionResult<IEnumerable<string>> GetAllegenTypes()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
