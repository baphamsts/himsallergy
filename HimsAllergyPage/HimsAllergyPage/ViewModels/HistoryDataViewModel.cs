using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HimsAllergyPage.ViewModels
{
    public class HistoryDataViewModel
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string CISId { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Provider { get; set; }
        public string Population { get; set; }
        public string AxisI { get; set; }
        public string ClientAllergyId { get; set; }
        public string Allergen { get; set; }
        public string deleted { get; set; }
        public string Notes { get; set; }
        public string CreateUser { get; set; }
        public string CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public string UpdateDate { get; set; }
        public string Deleted { get; set; }
        public string AllergenId { get; set; }
        public string AllergenType { get; set; }
        public string ReactionId { get; set; }
        public string SeverityId { get; set; }
        public string ReactionDesc { get; set; }
        public string SeverityDesc { get; set; }
        public string Type { get; set; }
        public string DrugName { get; set; }
        public string CreateDateWithTime { get; set; }
        public string UpdateDateWithTime { get; set; }
    }
}

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
 * ReactionDesc="
 * Diarrhea" S
 * everityDesc="Life Threatening" 
 * Type="Medication" 
 * DrugName="Reveal Blood Glucose Test In Vitro Strip" 
 * CreateDateWithTime="2018-02-08T13:06:45.763" 
 * UpdateDateWithTime="2018-02-22T09:09:14.690" />
 */
