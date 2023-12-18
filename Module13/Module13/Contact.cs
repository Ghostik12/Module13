using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13
{
    class Contact
    {
        public Contact(long phoneNumber, String email)
        {
           // Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        //public String Name { get; }
        private long PhoneNumber { get; set; }
        private String Email { get; set; }
    }
}
