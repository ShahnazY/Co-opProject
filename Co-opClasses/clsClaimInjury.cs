using System;

namespace Co_opClasses
{
    public class clsClaimInjury
    {
        public int ClaimID { get; set; }
        public int InjuryID { get; set; }

        public string Valid(string someClaimInjury)
        {
            //if the name of the personal injury is not blank
            if (someClaimInjury != "")
            {
                //return a blank string
                return "";
            }
            else
            {
                //otherwise return an error message
                return "The Claim Injury must not be blank";
            }
        }
    }
}