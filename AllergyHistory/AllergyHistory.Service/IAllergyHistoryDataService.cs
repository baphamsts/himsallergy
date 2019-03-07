using AllergyHistory.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllergyHistory.Services
{
    public interface IAllergyHistoryDataService
    {
        IEnumerable<AllergyHistoryDataTableViewModel> GetAllDataWithClientQuery(string query);
    }
}
