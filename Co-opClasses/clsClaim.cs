using System;

namespace Co_opClasses
{
    public class clsClaim
    {
        public int ClaimID { get; set; }
        public string Location { get; set; }
        public string Status { get; set; }
        public DateTime DateOfClaim { get; set; }
        public DateTime DateOfInjury { get; set; }
        public bool EvidenceProvided { get; set; }

        public string Valid(string someLocation, string someStatus)
        {
            //string variable to store the error message
            string Error = "";
            //if the name of the personal injury is more than 50 characters
            if (someLocation.Length > 50)
            {
                //return a blank string
                Error = "The Location cannot have more than 50 characters";
            }
            if (someLocation.Length == 0)
            {
                //return an error message
                Error = "The Location must not be blank";
            }
            if (someStatus.Length > 50)
            {
                //return a blank string
                Error = "The Status cannot have more than 50 characters";
            }
            if (someStatus.Length == 0)
            {
                //return an error message
                Error = "The Status must not be blank";
            }
            return Error;
        }

        public string Valid(string someStatus)
        {
            string Error = "";
            if (someStatus.Length > 50)
            {
                //return a blank string
                Error = "The Status cannot have more than 50 characters";
            }
            if (someStatus.Length == 0)
            {
                //return an error message
                Error = "The Status must not be blank";
            }
            return Error;
        }
    }
}