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
            //string variable to store the error message
            string Error = "";
            //temp variable to store the compensation value
            Decimal CompensationTemp;
            //if the name of the personal injury is more than 50 characters
            if (typeOfInjury.Length == 0)
            {
                //return the error
                Error = "The type of injury must not be blank :";
            }
            if (typeOfInjury.Length > 50)
            {
                //return an error message
                Error = "The type of injury must not exceed 50 characters :";
            }
            if (severity.Length == 0)
            {
                Error = Error + "The severity must not be blank :";
            }
            if (severity.Length > 50)
            {
                Error = Error + "The severity must not exceed 50 characters :";
            }
            try
            {
                CompensationTemp = Convert.ToDecimal(compensation);
                if (CompensationTemp < 0.01M)
                {
                    //record an error
                    Error = Error + "The compensation amount cannot be negative or less than £0.01 : ";
                }
                if (CompensationTemp > 100000M)
                {
                    //record an error
                    Error = Error + "The compensation amount cannot be more than £100,000 : ";
                }
                
            }
            catch
            {
                //record the error 
                Error = Error + "The value entered is not in the correct format : ";
            }

            return Error;
        }

        
    }
}