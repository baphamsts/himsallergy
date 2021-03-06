﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AlleryHistory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class AllergenController : ControllerBase
    {
        private readonly IAllergenInputService allergenInputService;

        public AllergenController(IAllergenInputService allergenInputService)
        {
            this.allergenInputService = allergenInputService;
        }

        // GET api/allergen/reactions
        [HttpGet("reactions")]
        public ActionResult<IEnumerable<AllergenReactionViewModel>> GetAllegenReactions()
        {
            //var data = allergenInputService.GetAllAllergenReaction();
            var data = allergenInputService.GetAllAllergenReactionXml();
            return Ok(data);
        }

        // GET api/allergen/severties
        [HttpGet("severities")]
        public ActionResult<IEnumerable<AllergenSeverityViewModel>> GetAllegenSeverties()
        {
            //var data = allergenInputService.GetAllAllergenSeverity();
            var data = allergenInputService.GetAllAllergenSeverityXml();
            return Ok(data);
        }


        // GET api/allergen/medications
        [HttpGet("medications")]
        public ActionResult<IEnumerable<MedicationViewModel>> GetMedications()
        {
            //var data = allergenInputService.GetAllMedication();
            var data = allergenInputService.GetAllMedicationXml();
            return Ok(data);
        }



        // GET api/allergen/types
        [HttpGet("types")]
        public ActionResult<IEnumerable<AllergenTypeViewModel>> GetAllegenTypes()
        {
            //var data = allergenInputService.GetAllAllergenType();
            var data = allergenInputService.GetAllAllergenTypeXml();
            return Ok(data);
        }

        // GET api/allergen/allergens
        [HttpGet("allergens")]
        public ActionResult<IEnumerable<AllergenViewModel>> GetAllegens()
        {
            //var data = allergenInputService.GetAllAllergen();
            var data = allergenInputService.GetAllAllergenXml();
            return Ok(data);
        }
    }
}
