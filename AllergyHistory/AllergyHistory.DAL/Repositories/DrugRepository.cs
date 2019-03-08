using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class DrugRepository : IRepository<Drug>
    {
        readonly AllergyHistoryContext dbContext;

        public DrugRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }

        public IEnumerable<Drug> GetAll()
        {
            var fakeData = GenerateFakeData();
            return fakeData;

            //return dbContext.AllegenHistories.ToList();
        }

        public IQueryable<Drug> GetAll_Q()
        {
            //return dbContext.AllegenHistories.AsQueryable();
            return null;

        }

        public Drug Get(long id)
        {
            //return dbContext.AllegenHistories
            //      .FirstOrDefault(e => e.AllegenHistoryId == id);

            return null;

        }

        public void Add(Drug entity)
        {
            //dbContext.AllegenHistories.Add(entity);
            //dbContext.SaveChanges();
        }

        public void Update(Drug allegenHistory, Drug entity)
        {
            //dbContext.SaveChanges();
        }

        public void Delete(Drug allergenHistory)
        {
           
        }


        /// <summary>
        /// This generate fake Domain data, considering that in this do main Enties, we call client is patient.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Drug>  GenerateFakeData()
        {
            var data = new List<Drug> {
                new Drug
                {
                    Id = 1,
                    DrugName = "ABILIFY",
                    LexiDrugId = "d04186"
                },

                new Drug
                {
                    Id = 2,
                    DrugName = "AMLODIPINE",
                    LexiDrugId = "d04186"
                },

                new Drug
                {
                    Id = 3,
                    DrugName = "ACETAMINOPHEN",
                    LexiDrugId = "d03428"
                },

                new Drug
                {
                    Id = 4,
                    DrugName = "ALBUTEROL",
                    LexiDrugId = "d04186"
                },

                new Drug
                {
                    Id = 5,
                    DrugName = "ACETAMINOPHEN",
                    LexiDrugId = "d00049"
                },
            };

            return data;
        }
    }
}
