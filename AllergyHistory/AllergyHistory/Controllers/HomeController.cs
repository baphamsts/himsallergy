﻿using AllergyHistory.Models;
using AllergyHistory.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Linq;

namespace AllergyHistory.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllergyHistoryDataService allergyHistoryDataService;

        public HomeController(IAllergyHistoryDataService allergyHistoryDataService)
        {
            this.allergyHistoryDataService = allergyHistoryDataService;
        }
        public IActionResult Index()
        {
            //var model = new AllergenPageModel();
            return View();
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
