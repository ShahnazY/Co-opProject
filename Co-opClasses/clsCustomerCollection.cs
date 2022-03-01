using System.Collections.Generic;

namespace Co_opClasses
{
    public class clsCustomerCollection
    {
        public clsCustomerCollection()
        {
            //create an instance of the personal injury class to store a type of injury
            clsCustomer ACustomer = new clsCustomer();
            ACustomer.FirstName = "John";
            mAllCustomers.Add(ACustomer);
            ACustomer = new clsCustomer();
            ACustomer.FirstName = "Mark";
            mAllCustomers.Add(ACustomer);
        }
        private List<clsCustomer> mAllCustomers = new List<clsCustomer>();
        public int Count
        {
            get
            {
                return mAllCustomers.Count;
            }
            set
            {

            }
        }

        public List<clsCustomer> AllCustomers
        {
            get
            {
                return mAllCustomers;
            }
            set
            {
                mAllCustomers = value;
            }
        }
    }
}