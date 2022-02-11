using System;

namespace Co_opClasses
{
    public class clsPersonalInjury
    {
        public int PersonalInjuryID { get; set; }
        public string TypeOfInjury { get; set; }
        public string Severity { get; set; }
        public decimal Compensation { get; set; }

        public string Valid(string somePersonalInjury, string someSeverity)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the personal injury is more than 50 characters
            if (somePersonalInjury.Length > 50)
            {
                //return a blank string
                Error = "The Personal Injury cannot have more than 50 characters";
            }
            if (somePersonalInjury.Length == 0)
            {
                //return an error message
                Error = "The Personal Injury must not be blank";
            }

            return Error;
        }

        public string Valid(string someSeverity)
        {
            string Error = "";
            if (someSeverity.Length > 50)
            {
                Error = "The Severity cannot have more than 50 characters";
            }
            if (someSeverity.Length == 0)
            {
                Error = "The Severity must not be blank";
            }
            return Error;
        }

        public string Valid(Decimal someCompensation)
        {
            string Error = "";
            Decimal PriceTemp;
            {
                PriceTemp = Convert.ToDecimal(someCompensation);
                if (PriceTemp < 0.01M)
                {
                    Error = "Compensation cannot be negative or 0";
                }
                if (PriceTemp > 30000.00M)
                {
                    Error = "Compensation cannot be more than £30,000";
                }
            }
            return Error;
        }
    }
}