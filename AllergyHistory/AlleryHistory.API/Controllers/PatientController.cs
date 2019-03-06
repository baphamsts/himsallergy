using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AllergyHistory.DAL.Repositories;
using AllergyHistory.Domain.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace AlleryHistory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors]
    public class PatientController : ControllerBase
    {
        private readonly IRepository<Patient> patientRepository;

        public PatientController(IRepository<Patient> patientRepository)
        {
            this.patientRepository = patientRepository;
        }

        // GET: api/Patient
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Patient> Patients = patientRepository.GetAll();
            return Ok(Patients);
        }

        // GET: api/Patient/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(long id)
        {
            Patient Patient = patientRepository.Get(id);

            if (Patient == null)
            {
                return NotFound("The Patient record couldn't be found.");
            }

            return Ok(Patient);
        }

        // POST: api/Patient
        [HttpPost]
        public IActionResult Post([FromBody] Patient Patient)
        {
            if (Patient == null)
            {
                return BadRequest("Patient is null.");
            }

            patientRepository.Add(Patient);
            return CreatedAtRoute(
                  "Get",
                  new { Id = Patient.PatientId },
                  Patient);
        }

        // PUT: api/Patient/5
        [HttpPut("{id}")]
        public IActionResult Put(long id, [FromBody] Patient Patient)
        {
            if (Patient == null)
            {
                return BadRequest("Patient is null.");
            }

            Patient PatientToUpdate = patientRepository.Get(id);
            if (PatientToUpdate == null)
            {
                return NotFound("The Patient record couldn't be found.");
            }

            patientRepository.Update(PatientToUpdate, Patient);
            return NoContent();
        }

        // DELETE: api/Patient/5
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            Patient Patient = patientRepository.Get(id);
            if (Patient == null)
            {
                return NotFound("The Patient record couldn't be found.");
            }

            patientRepository.Delete(Patient);
            return NoContent();
        }

        [HttpPost("loadData")]
        public IActionResult LoadData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data  
                var customerData = patientRepository.GetAll_Q();

                //Sorting  
                //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                //{
                //    customerData = customerData.OrderBy<Patient>(sortColumn + " " + sortColumnDirection);
                //}
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.PatientName == searchValue);
                }

                //total number of rows count   
                recordsTotal = customerData.Count();
                //Paging   
                var data = customerData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data  
                return new JsonResult(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
