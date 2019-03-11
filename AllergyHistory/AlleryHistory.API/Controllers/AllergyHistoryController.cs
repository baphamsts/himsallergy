using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllergyHistory.Contract.DTOs;
using AllergyHistory.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AlleryHistory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class AllergyHistoryController : ControllerBase
    {
        private readonly IAllergyHistoryDataService allergyHistoryDataService;

        public AllergyHistoryController(IAllergyHistoryDataService allergyHistoryDataService)
        {
            this.allergyHistoryDataService = allergyHistoryDataService;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            //var data = allergyHistoryDataService.GetAllAllergenHistory();

            var data = allergyHistoryDataService.GetAllAllergenHistoryXml();
            return Ok(data);
        }

    }
}
