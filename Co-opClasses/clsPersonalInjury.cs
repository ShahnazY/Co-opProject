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

        public string Valid(string typeOfInjury, string severity, string compensation)
        {
            String Error = "";
            //Decimal PriceTemp;
            if (typeOfInjury.Length == 0)
            {
                Error = Error + "The type of injury cannot be blank : ";
            }
            if (typeOfInjury.Length > 50)
            {
                Error = Error + "The type of injury cannot exceed 50 characters : ";
            }
            if (severity.Length == 0)
            {
                Error = "The Severity cannot be blank";
            }
            if (severity.Length > 50)
            {
                Error = "The Severity must not exceed 50 character : ";
            }
            
            return Error;
        }

        /*public string Valid(string somePersonalInjury, string someSeverity)
        {
            
            string Error = "";
            
            return Error;
        }

        public string Valid(Decimal someCompensation)
        {
            string Error = "";
            
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