using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterApplication
{

    public class Owner
    {
        private int ownerID { get; set; }
        private int phoneOwner { get; set; }
        private string lastName { get; set; }
        private string firstName { get; set; }
        private string dob { get; set; }//dob in class diagram should be changed to string
        private string address { get; set; }
        private string email { get; set; }

        public Owner(int ownerID, string lastName, string firstName, string dob, string address, int phoneOwner, string email)
        {
            this.ownerID = ownerID;
            this.phoneOwner = phoneOwner;
            this.lastName = lastName;
            this.firstName = firstName;
            this.dob = dob;
            this.address = address;
            this.email = email;
        }


        public int getOwnerId()
        {
            return this.ownerID;
        }

        public int getPhoneOwner()
        {
            return this.phoneOwner;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getDob()
        {
            return this.dob;
        }

        public string getAddress()
        {
            return this.address;
        }

        public string getEmail()
        {
            return this.email;
        }
    }
}
    


