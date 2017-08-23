using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        //fields because they are private
        private DateTime birthdate;
        private List<string> phoneNumbers = new List<string>();

        //properties because they are public. Here we use automatic properties.
        public string Firstname { get; set;  }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }


        // read only property
        public List<string> PhoneNumbers
        {
            get { return phoneNumbers; }
        }

        // property that validates input (the set accessor)
        public DateTime Birthdate
        {
            set
            {
                if ((DateTime.Now.Year - value.Year) > 120 ||
                    (DateTime.Now.Year - value.Year) < 0)
                {
                    throw new Exception("Age is not accepted");
                }
                else {
                    birthdate = value;
                }
            }
            get { return birthdate; }
        }

        // read only property
        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - birthdate.Year;
                if (now.Month < birthdate.Month ||
                    (now.Month == birthdate.Month && now.Day < birthdate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        // cunstructor
        public Customer(string firstnavn, string lastnavn, string address, string zip, string city)
        {
        // properties = input from parameters
            Firstname = firstnavn;
            Lastname = lastnavn;
            Address = address;
            Zip = zip;
            City = city;    
        }

        // method because of void. because else it would think it was a constructor
        public void AddPhone(string phone)
        {
            phoneNumbers.Add(phone);
        }
    }
}