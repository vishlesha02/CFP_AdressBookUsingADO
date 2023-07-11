using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingDOTNet
{
    public class Contact
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string SState { get; set; }
        public string Zip { get; set; }


     
        public Contact()
        { 
            
        
        }
        public Contact(string firstName, string lastName, string email, string phoneNumber, string city, string sState, string zip)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            City = city;
            SState = sState;
            Zip = zip;
        
        }

    }
}
