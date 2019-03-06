using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HimsAllergyPage.Models
{
    public class AllergenSeverity
    {
        public int CodeId { get; set; }
        public string CodeDesc { get; set; }
        public int CodeValue { get; set; }
        public int TypeId { get; set; }
    }
}
