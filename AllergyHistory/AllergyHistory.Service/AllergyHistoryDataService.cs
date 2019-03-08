using AllergyHistory.Contract.ViewModels;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
    /// <summary>
    /// A simple service layer to structure solution more extensiblity and scalability, for bigger application in the future if needed
    /// We can approach this Requirement more easier by build a micro service, but we intend to show the idea.
    /// </summary>
    public class AllergyHistoryDataService : IAllergyHistoryDataService
    {
        public AllergyHistoryDataService()
        {
           
        }

        /// <summary>
        /// Get ALl History Data, maybe it can collect form multiple repositories, but right here for example we just get from only one.
        /// After get Data, the data from specific domain will be converted to the other domain with the contract between them.
        /// This idea from DDD approach, we can handle this more simple but, just to show off that we understand the different terminologies between domains.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<AllergenHistoryViewModel> GetAll()
        {
            /// Fake data here
            /// 
            
            var data = new List<AllergenHistoryViewModel>();

            var originFakeData = new AllergenHistoryViewModel();
            originFakeData.Patient = "Patient";
            originFakeData.Type = "Medication";
            originFakeData.Allergen = "Amoxicillin";
            originFakeData.Reaction = "Anaphylaxis";
            originFakeData.Serverty = "Life Threatening";
            originFakeData.Notes = "Test 123";
            originFakeData.CreateInfo = "Created on 12/17/2018 by Stner";
            originFakeData.UpdateInfo = "updated on 2/18/2019 by Rgarcia";

            for(int i = 0; i < 10; i++)
            {
                // Dummy some differ data to observe
                var temp = new AllergenHistoryViewModel();
                temp.Patient = originFakeData.Patient + (i+1).ToString();
                temp.Type = i % 2 == 0 ? "Medication" : "Allegen";
                temp.Allergen = "Amoxicillin";
                temp.Reaction = "Anaphylaxis";
                temp.Serverty = "Life Threatening";
                temp.Notes = "Test";
                temp.CreateInfo = "Created on 12/17/2018 by X";
                temp.UpdateInfo = "updated on 2/18/2019 by Y";
                for (int j = 0; j < 10; j++)
                {
                    data.Add(temp);
                }
            }

            return data;
        }
    }
}
