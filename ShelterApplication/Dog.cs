using System;
namespace ShelterApplication
{
    public class Dog : Animal
    {
        private string lastWalked { get; set; }

        public Dog(string rfid, string description, DateTime dateBrought, string locationFound, Owner po)
            : base(rfid, description, dateBrought, locationFound, 10, 2, 20, po)
        {
        }

        public void setLastWalked(DateTime x)
        {
            lastWalked = Convert.ToString(x);
        }

        public string getLastWalked()
        {
            return lastWalked;
        }


    }
}
