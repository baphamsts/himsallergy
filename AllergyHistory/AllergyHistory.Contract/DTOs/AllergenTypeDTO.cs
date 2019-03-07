using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AllergyHistory.Contract.DTOs
{
    /// <summary>
    /// Maybe in the domain it call Code
    /// </summary>
    public class AllergenTypeDTO
    {
        public int CodeId { get; set; }
        public string CodeDesc { get; set; }
        public string CodeText { get; set; }
        public int CodeValue { get; set; }
        public int TypeId { get; set; }
    }
}
