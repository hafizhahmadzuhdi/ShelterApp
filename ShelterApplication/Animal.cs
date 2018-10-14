using System;
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
        private DateTime dateBrought { get; set; }//This string then will be converted into Date Type
        private string locationFound { get; set; }
        status animalStatus;
        private Owner myOwner;
        private int baseFee { get; set; }
        private int dailyFee { get; set; }
        private int adoptFee { get; set; }
        

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

        public Animal(string rfid, string description, DateTime dateBrought, string locationFound, int baseFee, int dailyFee, int adoptFee, Owner po)
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

        public void setDescription(string x)
        {
            this.description = x;
        }

        public DateTime getDateBrought()
        {
            return this.dateBrought;
        }

        public void setDateBrought(string x)
        {
            this.dateBrought = Convert.ToDateTime(x);
        }

        public string getLocationFound(){
            return this.locationFound;
        }

        public void setLocationFound(string x)
        {
            this.locationFound = x;
        }

        public int getPoId(){
            if (this.myOwner != null)
                return this.myOwner.getOwnerId();
            else
                return 0;
        }

        

        public Owner getPo(){
            return this.myOwner;
        }

        public void setOwner(Owner o)
        {
            this.myOwner = o;
        }


        public string getStatusAsString(){
            string resp = "";
            switch (animalStatus)
            {
                case status.notYetAdoptable:
                    resp = "notYetAdoptable";
                    break;
                case status.adoptable:
                    resp = "adoptable";
                    break;
                case status.adopted:
                    resp = "adopted";
                    break;
                case status.dead:
                    resp = "dead";
                    break;
                case status.claimed:
                    resp = "claimed";
                    break;
                case status.lost:
                    resp = "lost";
                    break;
            }
            return resp;
        }

        public void setStatus(string x)
        {
            if (x == "adoptable") {
                animalStatus = status.adoptable;
            } else if (x == "notYetAdoptable")
            {
                animalStatus = status.notYetAdoptable;
            } else if (x == "dead")
            {
                animalStatus = status.dead;
            } else if (x == "lost")
            {
                animalStatus = status.lost;
            } else if (x == "adopted")
            {
                animalStatus = status.adopted;
            } else if (x == "claimed")
            {
                animalStatus = status.claimed;
            }
        }

        public int calculateDays()
        {
            DateTime dateFound = getDateBrought();
            DateTime dateNow = DateTime.Now;
            double daysTotal =  (dateNow - dateFound).TotalDays;
            int days = Convert.ToInt32(daysTotal);
            return days;
        }

        public int getAdoptFee()
        {
            return this.adoptFee;

        }

        public int getDailyFee()
        {
            return this.dailyFee;
        }

        public int getBaseFee()
        {
            return this.baseFee;
        }


        public virtual string getExtra()
        {
            return "";
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
