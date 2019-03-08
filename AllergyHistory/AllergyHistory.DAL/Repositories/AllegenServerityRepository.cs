using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllegenServerityRepository : IRepository<AllergenSeverity>
    {
        readonly AllergyHistoryContext dbContext;

        public AllegenServerityRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }

        public IEnumerable<AllergenSeverity> GetAll()
        {
            var fakeData = generateFakeData();
            return fakeData;

            //return dbContext.AllegenHistories.ToList();
        }

        public IQueryable<AllergenSeverity> GetAll_Q()
        {
            //return dbContext.AllegenHistories.AsQueryable();
            return null;

        }

        public AllergenSeverity Get(long id)
        {
            //return dbContext.AllegenHistories
            //      .FirstOrDefault(e => e.AllegenHistoryId == id);

            return null;

        }

        public void Add(AllergenSeverity entity)
        {
            //dbContext.AllegenHistories.Add(entity);
            //dbContext.SaveChanges();
        }

        public void Update(AllergenSeverity allegenHistory, AllergenSeverity entity)
        {
            //dbContext.SaveChanges();
        }

        public void Delete(AllergenSeverity allergenHistory)
        {
           
        }


        /// <summary>
        /// This generate fake Domain data, considering that in this do main Enties, we call client is patient.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AllergenSeverity>  generateFakeData()
        {
            var data = new List<AllergenSeverity>();

            var fakeDomainEntity = new AllergenSeverity();
            fakeDomainEntity.Id  = 1;
            fakeDomainEntity.Desc = "Desc c";
            fakeDomainEntity.Value = 1;
            fakeDomainEntity.TypeId = 1;

            for (int i = 0; i < 10; i++)
            {
                // Dummy some differ data to observe
                var temp = new AllergenSeverity();
                temp.Id = fakeDomainEntity.Id;
                temp.Desc = fakeDomainEntity.Desc;
                temp.Value = fakeDomainEntity.Value; ;
                temp.TypeId = fakeDomainEntity.TypeId;

                for (int j = 0; j < 10; j++)
                {
                    data.Add(temp);
                }
            }

            return data;
        }
    }
}
