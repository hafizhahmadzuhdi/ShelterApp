using System;
namespace ShelterApplication
{
    public class Cat : Animal
    {
        private string extra;

        public Cat(string rfid, string description, DateTime dateBrought, string locationFound, string extra, Owner po)
            : base(rfid, description, dateBrought, locationFound, 15, 0, 25, po)
        {
            this.extra = extra;
        }

        public override string getExtra(){
            return this.extra;
        }

        public void setExtra(string x)
        {
            this.extra = x;
        }
    }
}
