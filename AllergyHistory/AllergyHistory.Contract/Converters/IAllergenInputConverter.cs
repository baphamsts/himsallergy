using System;
using System.Collections.Generic;
using System.Linq;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Domain.Entities;

namespace AllergyHistory.Contract.Converters
{
    public interface IAllergenInputConverter
    {
        /// <summary>
        /// Convert AllergenSeverityViewModel to AllergenSeverity
        /// </summary>
        /// <param name="allergenSeverityViewModel">The AllergenSeverityViewModel</param>
        /// <returns>The AllergenSeverity</returns>
        AllergenSeverity Convert(AllergenSeverityViewModel allergenSeverityViewModel);

        /// <summary>
        /// Convert AllergenSeverity to AllergenSeverityViewModel
        /// </summary>
        /// <param name="allergenSeverity">The AllergenSeverity</param>
        /// <returns>The AllergenSeverityViewModel</returns>
        AllergenSeverityViewModel Convert(AllergenSeverity allergenSeverity);

        /// <summary>
        /// Convert List of versions to List of UserViewModels
        /// </summary>
        /// <param name="users">The list of versions</param>
        /// <returns>The list of UserViewModels</returns>
        List<AllergenSeverityViewModel> Convert(IEnumerable<AllergenSeverity> users);

        /// <summary>
        /// Convert List of UserViewModels to List of Users
        /// </summary>
        /// <param name="userViewModels">The list of UserViewModels</param>
        /// <returns>The list of Users</returns>
        List<AllergenSeverity> Convert(List<AllergenSeverityViewModel> userViewModels);

        /// <summary>
        /// Convert AllergenSeverityViewModel to AllergenSeverity
        /// </summary>
        /// <param name="allergenSeverityViewModel">The AllergenSeverityViewModel</param>
        /// <returns>The AllergenSeverity</returns>
        AllergenSeverity Patch(AllergenSeverityViewModel allergenSeverityViewModel, AllergenSeverity allergenSeverity);
    }
}
