﻿using System;
namespace ShelterApplication
{
    public class Cat : Animal
    {
        private string extra;

        public Cat(string rfid, string description, string dateBrought, string locationFound, string extra, Owner po)
            : base(rfid, description, dateBrought, locationFound, 15, 0, 25, po)
        {
            this.extra = extra;
        }

        public string getExtra(){
            return this.extra;
        }
    }
}