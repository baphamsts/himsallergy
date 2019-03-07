using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllergyHistory.Contract.DTOs
{
    public class AllergenHistoryViewModel
    {
        public string Patient { get; set; }
        public string Type { get; set; }
        public string Allergen { get; set; }
        public string Reaction{ get; set; }
        public string Serverty { get; set; }
        public string Notes { get; set; }
        public string CreateInfo { get; set; }
        public string UpdateInfo { get; set; }
    }
}

