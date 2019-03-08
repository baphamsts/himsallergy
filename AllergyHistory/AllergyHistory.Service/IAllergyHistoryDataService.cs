﻿using AllergyHistory.Contract.DTOs;
using AllergyHistory.Contract.ViewModels;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
    public interface IAllergyHistoryDataService
    {
        IEnumerable<AllergenHistoryViewModel> GetAll();
    }
}
