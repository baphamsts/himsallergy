using System;
using System.Collections.Generic;
using System.Linq;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Domain.Entities;

namespace AllergyHistory.Contract.Converters
{
    internal class AllergenInputConverter : IAllergenInputConverter
    {
        public AllergenSeverity Convert(AllergenSeverityViewModel allergenSeverityViewModel)
        {
            try
            {
                AllergenSeverity allergenSeverity = null;

                if (allergenSeverityViewModel != null)
                {
                    //allergenSeverity = new AllergenSeverity();
                    //allergenSeverity.Id = allergenSeverityViewModel.Id;
                    //allergenSeverity.FirstName = allergenSeverityViewModel.FirstName;
                    //allergenSeverity.LastName = allergenSeverityViewModel.LastName;
                    //allergenSeverity.AccessToken = allergenSeverityViewModel.AccessToken;
                    //allergenSeverity.Role = allergenSeverityViewModel.Role;
                    //allergenSeverity.CreatedAt = allergenSeverityViewModel.CreatedAt;
                    //allergenSeverity.CreatedBy = allergenSeverityViewModel.CreatedBy;
                    //allergenSeverity.UpdatedAt = allergenSeverityViewModel.UpdatedAt;
                    //allergenSeverity.UpdatedBy = allergenSeverityViewModel.UpdatedBy;
                    //allergenSeverity.DocumentVersion = allergenSeverityViewModel.DocumentVersion;
                }

                return allergenSeverity;
            }
            catch (Exception exception)
            {
                throw new Exception("Convert allergenSeverityViewModel > allergenSeverity failed!", exception);
            }
        }

        public AllergenSeverityViewModel Convert(AllergenSeverity allergenSeverity)
        {
            try
            {
                AllergenSeverityViewModel allergenSeverityViewModel = null;

                if (allergenSeverity != null)
                {
                    //allergenSeverityViewModel = new AllergenSeverityViewModel();
                    //allergenSeverityViewModel.Id = allergenSeverity.Id;
                    //allergenSeverityViewModel.FirstName = allergenSeverity.FirstName;
                    //allergenSeverityViewModel.LastName = allergenSeverity.LastName;
                    //allergenSeverityViewModel.AccessToken = allergenSeverity.AccessToken;
                    //allergenSeverityViewModel.Role = allergenSeverity.Role;
                    //allergenSeverityViewModel.CreatedAt = allergenSeverity.CreatedAt;
                    //allergenSeverityViewModel.CreatedBy = allergenSeverity.CreatedBy;
                    //allergenSeverityViewModel.UpdatedAt = allergenSeverity.UpdatedAt;
                    //allergenSeverityViewModel.UpdatedBy = allergenSeverity.UpdatedBy;
                    //allergenSeverityViewModel.DocumentVersion = allergenSeverity.DocumentVersion;
                }

                return allergenSeverityViewModel;
            }
            catch (Exception exception)
            {
                throw new Exception("Convert allergenSeverity > allergenSeverityViewModel failed!", exception);
            }
        }

        public List<AllergenSeverityViewModel> Convert(IEnumerable<AllergenSeverity> users)
        {
            List<AllergenSeverityViewModel> userViewModels = new List<AllergenSeverityViewModel>();

            if (users != null)
            {
                users
                    .ToList()
                    .ForEach(c => userViewModels.Add(Convert(c)));
            }

            return userViewModels;
        }

        public List<AllergenSeverity> Convert(List<AllergenSeverityViewModel> userViewModels)
        {
            List<AllergenSeverity> users = new List<AllergenSeverity>();

            if (userViewModels != null)
            {
                userViewModels.ForEach(c => users.Add(Convert(c)));
            }

            return users;
        }

        public AllergenSeverity Patch(AllergenSeverityViewModel allergenSeverityViewModel, AllergenSeverity allergenSeverity)
        {
            if (allergenSeverity != null)
            {
                //PatchHelper.Patch(allergenSeverityViewModel, allergenSeverity);

                return allergenSeverity;
            }

            return null;
        }
    }
}
