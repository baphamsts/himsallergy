namespace AllergyHistory.Contract.DTOs
{
    /// <summary>
    /// Medication map to drug table
    /// </summary>
    public class MedicationDTO
    {
        public int DrugId { get; set; }
        public string DrugName { get; set; }
        public string LexiDrugId { get; set; }
    }
}
