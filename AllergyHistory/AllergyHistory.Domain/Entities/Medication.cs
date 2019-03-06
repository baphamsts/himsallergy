namespace HimsAllergyPage.Models
{
    /// <summary>
    /// Medication map to drug table
    /// </summary>
    public class Medication
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public string LexiDrugId { get; set; }
    }
}
