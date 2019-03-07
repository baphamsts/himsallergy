using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllergyHistory.Domain.Entities
{
    /// <summary>
    /// Maybe in the domain it call Code
    /// </summary>
    public class AllergenType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int CodeId { get; set; }
        public string CodeDesc { get; set; }
        public string CodeText { get; set; }
        public int CodeValue { get; set; }
        public int TypeId { get; set; }
    }
}
