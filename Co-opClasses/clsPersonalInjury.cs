using System;
using ClassLibrary;

namespace Co_opClasses
{
    public class clsPersonalInjury
    {
        private Int32 mPersonalInjuryID;
        private string mTypeOfInjury;
        private string mSeverity;
        private decimal mCompensation;

        public int PersonalInjuryID
        {
            get
            {
                return mPersonalInjuryID;
            }
            set
            {
                mPersonalInjuryID = value;
            }
        }
        public string TypeOfInjury
        {
            get
            {
                return mTypeOfInjury;
            }
            set
            {
                mTypeOfInjury = value;
            }
        }
        public string Severity
        {
            get
            {
                return mSeverity;
            }
            set
            {
                mSeverity = value;
            }
        }
        public decimal Compensation
        {
            get
            {
                return mCompensation;
            }
            set
            {
                mCompensation = value;
            }
        }

        public bool Find(int PersonalInjuryID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the personal injury ID to search for
            DB.AddParameter("@PersonalInjuryID", PersonalInjuryID);
            //execute the stored procedure
            DB.Execute("sproc_tblPersonalInjury_FilterByPersonalInjuryID");
            //if record is found
            if (DB.Count == 1)
            {
                //copy data from database to private data member
                mPersonalInjuryID = Convert.ToInt32(DB.DataTable.Rows[0]["PersonalInjuryID"]);
                mTypeOfInjury = Convert.ToString(DB.DataTable.Rows[0]["TypeOfInjury"]);
                mSeverity = Convert.ToString(DB.DataTable.Rows[0]["Severity"]);
                mCompensation = Convert.ToDecimal(DB.DataTable.Rows[0]["Compensation"]);
                //return true if everything is ok
                return true;
            }
            else
            {
                //if there's problems
                return false;
            }
        }

        /*public string Valid(string somePersonalInjury, string someSeverity)
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
        }*/
    }
}