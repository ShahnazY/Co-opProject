using System;

namespace Co_opClasses
{
    public class clsCustomer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public int HouseNo { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string PostCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }

        public string Valid(string firstName, string lastName, string dateOfBirth, string email, string houseNo, string street, string town, string postCode)
        {
            //string variable to store the error message
            string Error = "";
            //create a temp variable to store date values
            DateTime DateTemp;
            //if the name of the personal injury is more than 50 characters
            if (firstName.Length > 50)
            {
                //return a blank string
                Error = "The first name cannot have more than 50 characters";
            }
            if (firstName.Length == 0)
            {
                //return an error message
                Error = "The first name must not be blank";
            }
            if (lastName.Length > 50)
            {
                //return a blank string
                Error = "The last name cannot have more than 50 characters";
            }
            if (lastName.Length == 0)
            {
                //return an error message
                Error = "The last name must not be blank";
            }
            if (street.Length > 50)
            {
                //return a blank string
                Error = "The street cannot have more than 50 characters";
            }
            if (street.Length == 0)
            {
                //return an error message
                Error = "The street must not be blank";
            }
            if (town.Length > 50)
            {
                //return a blank string
                Error = "The town cannot have more than 50 characters";
            }
            if (town.Length == 0)
            {
                //return an error message
                Error = "The town must not be blank";
            }

            try
            {
                //cope the dateOfClaim value to the DateTemp variable
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp > DateTime.Now.Date.AddYears(-18)) 
                {
                    //record the error
                    Error = Error + "You must be older than 18 : ";
                }
                DateTemp = Convert.ToDateTime(dateOfBirth);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "You are too old : ";
                }
            }
            catch
            {
                //record the error
                Error = Error + "The date entered is not in the valid format : ";
            }
            return Error;
        }
    }
}