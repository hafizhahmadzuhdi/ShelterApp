using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterApplication
{
    class Owner
    {
        int ownerID, phoneOwner;
        string lastName, firstName, dob, address, email;

        public Owner(int ownerID, int phoneOwner, string lastName, string firstName, string dob, string address, string email)
        {
            this.ownerID = ownerID;
            this.phoneOwner = phoneOwner;
            this.lastName = lastName;
            this.firstName = firstName;
            this.dob = dob;
            this.address = address;
            this.email = email;
        }
    

    }
}
