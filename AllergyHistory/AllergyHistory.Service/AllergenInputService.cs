using AllergyHistory.Contract.DTOs;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.DAL.Repositories;
using AllergyHistory.Domain.Entities;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
    public class AllergenInputService : IAllergenInputService
    {
        private readonly IRepository<AllergenSeverity> repository;

        public AllergenInputService(IRepository<AllergenSeverity> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<AllergenSeverityViewModel> GetAll()
        {
            var domainEntityData = repository.GetAll();
            return new List<AllergenSeverityViewModel>();
        }
    }
}
