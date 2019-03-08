using AllergyHistory.Contract.DTOs;
using AllergyHistory.Contract.ViewModels;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
    public interface IAllergenInputService
    {
        IEnumerable<AllergenSeverityViewModel> GetAll();
    }
}
