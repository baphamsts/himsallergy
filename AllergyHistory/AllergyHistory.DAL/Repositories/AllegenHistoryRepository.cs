using AllergyHistory.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllegenHistoryRepository : IRepository<AllergenHistory>
    {
        readonly AllergyHistoryContext dbContext;

        public AllegenHistoryRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }

        public IEnumerable<AllergenHistory> GetAll()
        {
            var fakeData = generateFakeData();
            return fakeData;

            //return dbContext.AllegenHistories.ToList();
        }

        public IQueryable<AllergenHistory> GetAll_Q()
        {
            //return dbContext.AllegenHistories.AsQueryable();
            return null;

        }

        public AllergenHistory Get(long id)
        {
            //return dbContext.AllegenHistories
            //      .FirstOrDefault(e => e.AllegenHistoryId == id);

            return null;

        }

        public void Add(AllergenHistory entity)
        {
            //dbContext.AllegenHistories.Add(entity);
            //dbContext.SaveChanges();
        }

        public void Update(AllergenHistory allegenHistory, AllergenHistory entity)
        {
            //dbContext.SaveChanges();
        }

        public void Delete(AllergenHistory allergenHistory)
        {
           
        }


        /// <summary>
        /// This generate fake Domain data, considering that in this do main Enties, we call client is patient.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AllergenHistory>  generateFakeData()
        {
            /// Fake data here, may be it will collect the data from

            var data = new List<AllergenHistory>();

            var domainDummyData = new AllergenHistory();

            //domainDummyData.
            //originFakeData.ClientName = "Patient Name";
            //domainDummyData.Type = "Medication";
            //domainDummyData.Allergen = "Amoxicillin";
            //domainDummyData.Reaction = "Anaphylaxis";
            //domainDummyData.Serverty = "Life Threatening";
            //domainDummyData.Notes = "Test 123";
            //domainDummyData.CreateInfo = "Created on 12/17/2018 by Stner";
            //domainDummyData.UpdateInfo = "updated on 2/18/2019 by Rgarcia";

            for (int i = 0; i < 10; i++)
            {
                //// Dummy some differ data to observe
                //var temp = new AllergenHistoryViewModel();
                //temp.Patient = domainDummyData.Patient + (i + 1).ToString();
                //temp.Type = i % 2 == 0 ? "Medication" : "Allegen";
                //temp.Allergen = "Amoxicillin";
                //temp.Reaction = "Anaphylaxis";
                //temp.Serverty = "Life Threatening";
                //temp.Notes = "Test";
                //temp.CreateInfo = "Created on 12/17/2018 by X";
                //temp.UpdateInfo = "updated on 2/18/2019 by Y";
                //for (int j = 0; j < 10; j++)
                //{
                //    data.Add(temp);
                //}
            }

            return data;
        }
    }
}
