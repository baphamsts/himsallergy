using AllergyHistory.Contract.DTOs;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
    public interface IAllergyHistoryDataService
    {
        IEnumerable<AllergenHistoryViewModel> GetAll();
    }
}
