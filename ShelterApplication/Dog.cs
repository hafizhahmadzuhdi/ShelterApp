using System;
namespace ShelterApplication
{
    public class Dog : Animal
    {
        private string lastWalked;

        public Dog(string rfid, string description, DateTime dateBrought, string locationFound, Owner po)
            : base(rfid, description, dateBrought, locationFound, 10, 2, 20, po)
        {
        }
    }
}
