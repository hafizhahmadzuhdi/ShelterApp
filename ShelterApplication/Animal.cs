﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterApplication
{
    public abstract class Animal
    {
        private string rfid { get; set; }
        private string description { get; set; }
        private string dateBrought { get; set; }
        private string locationFound { get; set; }
        private Owner myOwner;

        private double baseFee { get; set; }
        private double dailyFee { get; set; }
        private double adoptFee { get; set; }
        

        private enum status
        {
            adoptable,
            notYetAdoptable,
            adopted,
            claimed,
            dead,
            lost
        }

        private status animalstatus;

        private bool info { get; set; }
        private bool paid { get; set; }

        public Animal(string rfid, string description, string dateBrought, string locationFound, double baseFee, double dailyFee, double adoptFee, Owner po)
        {
            this.rfid = rfid;
            this.description = description;
            this.dateBrought = dateBrought;
            this.locationFound = locationFound;
            this.baseFee = baseFee;
            this.dailyFee = dailyFee;
            this.adoptFee = adoptFee;
            this.myOwner = po;
        }

        public string getRfid(){
            return this.rfid;
        }

        public string getDescription()
        {
            return this.description;
        }

        public string getDateBrought()
        {
            return this.dateBrought;
        }

        public string getLocationFound(){
            return this.locationFound;
        }

        public int getPoId(){
            if (this.myOwner != null)
                return this.myOwner.getOwnerId();
            else
                return 0;
        }
 
        //public Animal()
        //{

        //}

        //public Animal(string rfid, string description, string dateBrought, string locationFound, Owner po, double baseFee, double dailyFee, double adoptFee, bool info, bool paid)
        //{
        //    this.rfid = rfid;
        //    this.description = description;
        //    this.dateBrought = dateBrought;
        //    this.locationFound = locationFound;
        //    this.myOwner = po;
        //    this.baseFee = baseFee;
        //    this.dailyFee = dailyFee;
        //    this.adoptFee = adoptFee;
        //    this.info = info;
        //    this.paid = paid;
        //}

        //public class Cat : Animal
        //{
        //    private string extra;

        //    public Cat()
        //    {

        //    }
        //}

        //public Owner getOwner()
        //{
        //    return this.myOwner;
        //}

        //public double getDays(Owner a)
        //{
        //    //return a.getInt();
        //    return baseFee;
        //}

        //public double calculateClaimFee()
        //{
        //    return baseFee;
        //}
    }
}
