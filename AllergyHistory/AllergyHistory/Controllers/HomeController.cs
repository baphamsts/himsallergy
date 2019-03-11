using AllergyHistory.Contract.DTOs;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Helpers;
using AllergyHistory.Models;
using AllergyHistory.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AllergyHistory.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllergyHistoryDataService allergyHistoryDataService;

        public HomeController(IAllergyHistoryDataService allergyHistoryDataService)
        {
            this.allergyHistoryDataService = allergyHistoryDataService;
        }
        public async Task<IActionResult> Index()
        {
            var model = new AllergyPageViewModel();
            model.AllergenTypeSelectList = await BuildAllergenTypeSelectList();
            model.AllergenReactionSelectList = await BuildAllergenReactionSelectList();
            model.AllergenSeveritySelectList = await BuildAllergenSeveritySelectList();
            model.AllergenSelectList = await BuildAllergenSelectList();
            model.MedicationSelectList = await BuildMedicationSelectList();

            return View(model);
        }

        private async Task<List<SelectListItem>> BuildAllergenTypeSelectList()
        {
            var AllergenTypeSelectItems = new List<SelectListItem>();

            string apiUrl = "http://localhost:51189/api/Allergen/types";

            var allergenTypeList = await GetXmlDataListViaAPI<AllergenTypeList>(apiUrl);

            allergenTypeList.AllergenTypes.ForEach(x =>
            {
                AllergenTypeSelectItems.Add(new SelectListItem
                {
                    Value = x.CodeId.ToString(),
                    Text = x.CodeText
                });
            });

            return AllergenTypeSelectItems;
        }

        private async Task<List<SelectListItem>> BuildAllergenReactionSelectList()
        {
            var AllergenReactionSelectItems = new List<SelectListItem>();

            string apiUrl = "http://localhost:51189/api/Allergen/reactions";

            var allergenReactionList = await GetXmlDataListViaAPI<AllergenReactionList>(apiUrl);

            allergenReactionList.AllergenReactions.ForEach(x =>
            {
                AllergenReactionSelectItems.Add(new SelectListItem
                {
                    Value = x.CodeId.ToString(),
                    Text = x.CodeDesc
                });
            });

            return AllergenReactionSelectItems;
        }

        private async Task<List<SelectListItem>> BuildAllergenSeveritySelectList()
        {
            var allergenSeveritySelectItems = new List<SelectListItem>();

            string apiUrl = "http://localhost:51189/api/Allergen/severities";

            var allergenSeverityList = await GetXmlDataListViaAPI<AllergenSeverityList>(apiUrl);

            allergenSeverityList.AllergenSeverities.ForEach(x =>
            {
                allergenSeveritySelectItems.Add(new SelectListItem
                {
                    Value = x.CodeId.ToString(),
                    Text = x.CodeDesc
                });
            });

            return allergenSeveritySelectItems;
        }


        private async Task<List<SelectListItem>> BuildAllergenSelectList()
        {
            var AllergenSelectItems = new List<SelectListItem>();

            string apiUrl = "http://localhost:51189/api/Allergen/allergens";

            var allergenList = await GetXmlDataListViaAPI<AllergenList>(apiUrl);

            allergenList.Allergens.ForEach(x =>
            {
                AllergenSelectItems.Add(new SelectListItem
                {
                    Value = x.CodeId.ToString(),
                    Text = x.CodeText
                });
            });

            return AllergenSelectItems;
        }

        private async Task<List<SelectListItem>> BuildMedicationSelectList()
        {
            var medicationSelectItems = new List<SelectListItem>();

            string apiUrl = "http://localhost:51189/api/Allergen/medications";

            var medicationList = await GetXmlDataListViaAPI<MedicationList>(apiUrl);

            medicationList.Medications.ForEach(x =>
            {
                medicationSelectItems.Add(new SelectListItem
                {
                    Value = x.DrugId.ToString(),
                    Text = x.DrugName
                });
            });

            return medicationSelectItems;
        }



        private async Task<T> GetXmlDataListViaAPI<T>(string apiUrl) where T : class
        {
            T returnListObject = default(T);

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var xmlContent = await response.Content.ReadAsStringAsync();
                    var wellFormatXml = $"<{typeof(T).Name}>{xmlContent}</{typeof(T).Name}> ";

                    returnListObject = XmlHelper.DeserializeXMLStringToObject<T>(wellFormatXml);
                }

            }

            return returnListObject;
        }


        public async Task<IActionResult> LoadDataXml()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var pageLength = Request.Form["length"].FirstOrDefault();
                var searchPatientValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100, all = -1)  
                int pageSize = pageLength != null ? Convert.ToInt32(pageLength) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var allergyHistoryList = await GetXmlDataListViaAPI<AllergenHistoryList>("http://localhost:51189/api/AllergyHistory");

                var allergyHistoryData = allergyHistoryList.AllergenHistories.Select(x => new AllergenHistoryDataTableViewModel
                {
                    //Id = x.ClientId,
                    Patient = x.ClientName,
                    Type = x.Type,
                    Allergen = x.Allergen,
                    Reaction = x.ReactionDesc,
                    Serverty = x.SeverityDesc,
                    Notes = x.Notes,
                    CreateInfo = $"{x.CreateDate} by {x.CreateUser}",
                    UpdateInfo = $"{x.UpdateDate} by {x.UpdateUser}"
                });

                if (!string.IsNullOrEmpty(searchPatientValue))
                {
                    allergyHistoryData = allergyHistoryData.Where(m => m.Patient.Contains(searchPatientValue));
                }

                recordsTotal = allergyHistoryData.Count();

                var data = pageSize == -1 ? allergyHistoryData : allergyHistoryData.Skip(skip).Take(pageSize);
                return new JsonResult(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public IActionResult LoadData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var pageLength = Request.Form["length"].FirstOrDefault();
                var searchPatientValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100, all = -1)  
                int pageSize = pageLength != null ? Convert.ToInt32(pageLength) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                var allergyHistoryData = allergyHistoryDataService.GetAll();


                if (!string.IsNullOrEmpty(searchPatientValue))
                {
                    allergyHistoryData = allergyHistoryData.Where(m => m.Patient.Contains(searchPatientValue));
                }

                recordsTotal = allergyHistoryData.Count();

                var data = pageSize == -1 ? allergyHistoryData : allergyHistoryData.Skip(skip).Take(pageSize);
                return new JsonResult(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
            }
            catch (Exception)
            {
                throw;
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
