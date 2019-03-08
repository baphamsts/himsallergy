using AllergyHistory.Contract.ViewModels;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
    public interface IAllergenInputService
    {
        IEnumerable<AllergenSeverityViewModel> GetAllAllergenSeverity();
        IEnumerable<AllergenTypeViewModel> GetAllAllergenType();
        IEnumerable<AllergenViewModel> GetAllAllergen();
        IEnumerable<AllergenReactionViewModel> GetAllAllergenReaction();
        IEnumerable<MedicationViewModel> GetAllMedication();

    }
}
