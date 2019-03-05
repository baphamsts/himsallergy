using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HimsAllergyPage.Models
{
    public class Patient
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string CISId { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Provider { get; set; }
        public string Population { get; set; }
        public string AxisI { get; set; }
        public string ClientAllergyId { get; set; }
        public string Allergen { get; set; }
        public string deleted { get; set; }
    }
}
