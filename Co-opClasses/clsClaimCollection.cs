using System.Collections.Generic;

namespace Co_opClasses
{
    public class clsClaimCollection
    {
        public clsClaimCollection()
        {
            //create an instance of the personal injury class to store a type of injury
            clsClaim AClaim = new clsClaim();
            AClaim.Location = "Leicester";
            mAllClaims.Add(AClaim);
            AClaim = new clsClaim();
            AClaim.Location = "Derby";
            mAllClaims.Add(AClaim);
        }
        private List<clsClaim> mAllClaims = new List<clsClaim>();
        public int Count
        {
            get
            {
                return mAllClaims.Count;
            }
            set
            {

            }
        }

        public List<clsClaim> AllClaims
        {
            get
            {
                return mAllClaims;
            }
            set
            {
                mAllClaims = value;
            }
        }
    }
}