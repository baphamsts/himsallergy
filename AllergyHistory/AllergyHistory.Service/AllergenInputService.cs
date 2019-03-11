﻿using AllergyHistory.Contract.Converters;
using AllergyHistory.Contract.DTOs;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.DAL.Repositories;
using AllergyHistory.Domain.Entities;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
    /// <summary>
    /// This service to laod all some dropdown input fake data
    /// Actually each service should be separately based on entity or repository
    /// But for demo just gather all in one.
    /// </summary>
    public class AllergenInputService : IAllergenInputService
    {
        private readonly IRepository<AllergenSeverity> allergenSeverityRepository;
        private readonly IRepository<AllergenType> allergenTypeRepository;
        private readonly IRepository<AllergenReaction> allergenReactionRepository;
        private readonly IRepository<Allergen> allergenRepository;
        private readonly IRepository<Drug> drugRepository;
        private readonly IAllergenInputConverter conveter;

        public AllergenInputService(
            IRepository<AllergenSeverity> allergenSeverityRepository,
            IRepository<AllergenType> allergenTypeRepository,
            IRepository<AllergenReaction> allergenReactionRepository,
            IRepository<Allergen> allergenRepository,
            IRepository<Drug> drugRepository,
            IAllergenInputConverter conveter)
        {
            this.allergenSeverityRepository = allergenSeverityRepository;
            this.allergenTypeRepository = allergenTypeRepository;
            this.allergenReactionRepository = allergenReactionRepository;
            this.allergenRepository = allergenRepository;
            this.drugRepository = drugRepository;
            this.conveter = conveter;
        }

        public IEnumerable<AllergenSeverityViewModel> GetAllAllergenSeverity()
        {
            var domainEntityData = allergenSeverityRepository.GetAll();

            var viewModelData = conveter.Convert(domainEntityData);

            return viewModelData;
        }

        public IEnumerable<AllergenTypeViewModel> GetAllAllergenType()
        {
            var domainEntityData = allergenTypeRepository.GetAll();

            var viewModelData = conveter.Convert(domainEntityData);

            return viewModelData;
        }
        public IEnumerable<AllergenViewModel> GetAllAllergen()
        {
            var domainEntityData = allergenRepository.GetAll();

            var viewModelData = conveter.Convert(domainEntityData);

            return viewModelData;
        }
        public IEnumerable<AllergenReactionViewModel> GetAllAllergenReaction()
        {
            var domainEntityData = allergenReactionRepository.GetAll();

            var viewModelData = conveter.Convert(domainEntityData);

            return viewModelData; ;
        }
        public IEnumerable<MedicationViewModel> GetAllMedication()
        {
            var domainEntityData = drugRepository.GetAll();

            var viewModelData = conveter.Convert(domainEntityData);

            return viewModelData;
        }

        public string GetAllAllergenSeverityXml()
        {
            return allergenSeverityRepository.GetAllXml();
        }

        public string GetAllAllergenTypeXml()
        {
            return allergenTypeRepository.GetAllXml();
            
        }
        public string GetAllAllergenXml()
        {
            return allergenRepository.GetAllXml();
        }
        public string GetAllAllergenReactionXml()
        {
            return allergenReactionRepository.GetAllXml();
        }
        public string GetAllMedicationXml()
        {
            return drugRepository.GetAllXml();
        }
    }
}
