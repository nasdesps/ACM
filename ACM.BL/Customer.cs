using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        //Constructor chaining, calling one constructor from another constructor
        public Customer()
            : this(0)
        {

        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullname = LastName;

                if (!string.IsNullOrWhiteSpace(FirstName)) //firstname shouldn't be blank 
                {
                    if (!string.IsNullOrWhiteSpace(fullname)) //lastname shouldn't be blank
                    {
                        fullname += ", "; // fullname = fullname + ", ";
                        //var x = $"{FullName} kjajfkafkl; {Fac}";  string interpolation
                    }
                    fullname += FirstName; // fullname = fullname + FirstName;
                }
                return fullname;
            }
        }
                
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}
