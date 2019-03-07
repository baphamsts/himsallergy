using AllergyHistory.Domain.Entities;
using System;
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

            var fakeDomainEntity = new AllergenHistory();
            fakeDomainEntity.Id = 1;
            fakeDomainEntity.PatientId = 1;
            fakeDomainEntity.PatientName = "Test Name ";
            fakeDomainEntity.CISId = "0742031237";
            fakeDomainEntity.DOB = DateTime.Now;
            fakeDomainEntity.Gender = "Male";
            fakeDomainEntity.Provider = "Redcedar";
            fakeDomainEntity.Population = "Adult";
            fakeDomainEntity.AxisI = "F25.0";
            fakeDomainEntity.AxisIDesc = "Disoder";
            fakeDomainEntity.ClientAllergyId = 1;
            fakeDomainEntity.Allergen = "Reveal Blood";
            fakeDomainEntity.deleted = false;
            fakeDomainEntity.Notes = "Test notes";
            fakeDomainEntity.CreateUser = "User 1";
            fakeDomainEntity.CreateDate = DateTime.Now;
            fakeDomainEntity.UpdateUser = "User 2";
            fakeDomainEntity.UpdateDate = DateTime.Now;
            fakeDomainEntity.Deleted = false;
            fakeDomainEntity.AllergenId = 1;
            fakeDomainEntity.AllergenType = 1;
            fakeDomainEntity.ReactionId = 1;
            fakeDomainEntity.SeverityId = 1;
            fakeDomainEntity.ReactionDesc = "Diarrhea";
            fakeDomainEntity.SeverityDesc = "Life Threatening";
            fakeDomainEntity.Type = "Medication";
            fakeDomainEntity.DrugName = "Vitro Strip";
            fakeDomainEntity.CreateDateWithTime = DateTime.Now;
            fakeDomainEntity.UpdateDateWithTime = DateTime.Now;


            /*
 * <row ClientId="29355" 
 * ClientName="DOBIESZ,ALITA" 
 * CISId="0742031237" 
 * DOB="08/03/2001" 
 * Gender="Male" 
 * Provider="Redcedar" 
 * Population="Children" 
 * AxisI="F25.0" 
 * AxisIDesc="Schizoaffective disorder,bipolar type" 
 * ClientAllergyId="13399" 
 * Allergen="Reveal Blood Glucose Test In Vitro Strip" 
 * deleted="0" 
 * Notes="Just don't let him use these, OK??? (edit 2)" 
 * CreateUser="squinn" 
 * CreateDate="02/08/2018" 
 * UpdateUser="rkey" 
 * UpdateDate="02/22/2018" 
 * Deleted="0" 
 * AllergenId="31993" 
 * AllergenType="612" 
 * ReactionId="616" 
 * SeverityId="633" 
 * ReactionDesc="Diarrhea" 
 * SeverityDesc="Life Threatening" 
 * Type="Medication" 
 * DrugName="Reveal Blood Glucose Test In Vitro Strip" 
 * CreateDateWithTime="2018-02-08T13:06:45.763" 
 * UpdateDateWithTime="2018-02-22T09:09:14.690" />
 */


            for (int i = 0; i < 10; i++)
            {
                // Dummy some differ data to observe
                var temp = new AllergenHistory();
               
                temp.Type = i % 2 == 0 ? "Medication" : "Allegen";
                temp.Allergen = "Amoxicillin";


                for (int j = 0; j < 10; j++)
                {
                    data.Add(temp);
                }
            }

            return data;
        }
    }
}
