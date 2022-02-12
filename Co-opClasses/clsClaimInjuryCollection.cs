using System.Collections.Generic;

namespace Co_opClasses
{
    public class clsClaimInjuryCollection
    {
        public clsClaimInjuryCollection()
        {
            //create an instance of the personal injury class to store a type of injury
            clsClaimInjury AClaimInjury = new clsClaimInjury();
            AClaimInjury.ClaimID = 1;
            mAllClaimInjuries.Add(AClaimInjury);
            AClaimInjury = new clsClaimInjury();
            AClaimInjury.ClaimID = 5;
            mAllClaimInjuries.Add(AClaimInjury);
        }
        private List<clsClaimInjury> mAllClaimInjuries = new List<clsClaimInjury>();
        public int Count
        {
            get
            {
                return mAllClaimInjuries.Count;
            }
            set
            {
                 
            }
        }

        public List<clsClaimInjury> AllClaimInjuries
        {
            get
            {
                return mAllClaimInjuries;
            }
            set
            {
                mAllClaimInjuries = value;
            }
        }
    }
}