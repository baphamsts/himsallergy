using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllergyHistory.Contract.DTOs;
using AllergyHistory.Services;
using Microsoft.AspNetCore.Mvc;

namespace AlleryHistory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllergyHistoryController : ControllerBase
    {
        private readonly IAllergyHistoryDataService allergyHistoryDataService;

        public AllergyHistoryController(IAllergyHistoryDataService allergyHistoryDataService)
        {
            this.allergyHistoryDataService = allergyHistoryDataService;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<AllergenHistoryDTO>> Get()
        {
            var data = allergyHistoryDataService.GetAllAllergenHistory();
            return Ok(data);
        }
    }
}
