using AllergyHistory.Contract.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AllergyHistory.Models
{
    public class AllergenPageModel
    {

        public IEnumerable<AllergenTypeViewModel> AllergyTypeSeclectList { get; set; }
        public IEnumerable<AllergenReactionViewModel> AllergenReactionSeclectList { get; set; }
        public IEnumerable<AllergenSeverityViewModel> AllergenSeverityList { get; set; }
        public IEnumerable<AllergenViewModel> AllergenSeclectList { get; set; }
        public IEnumerable<MedicationViewModel> MedicationSeclectList { get; set; }


        public AllergenPageModel()
        {
            //this.AllergenReactionSeclectList = getAllergenSeclectList();
        }


        //private async Task<IEnumerable<AllergenViewModel>> getAllergenSeclectList()
        //{

        //    string apiUrl = "http://localhost:51189/api/";

        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(apiUrl);
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.GetAsync(apiUrl);
        //        if (response.IsSuccessStatusCode)
        //        {
        //            return response.Content;
        //        }


        //    }
        //}
        

    }
}
