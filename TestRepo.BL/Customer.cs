using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRepo.BL
{
    public class Customer
    {
        public Customer()
        {

        }
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
        public string emailAddress { get; set; }

        /// <summary>
        /// Concatenates Firstname and Lastname together 
        /// separating them with a ","
        /// </summary>
        /// <returns></returns>
        public string FullName()
        {
            return LastName + ", " + FirstName;
        }
    }
}
