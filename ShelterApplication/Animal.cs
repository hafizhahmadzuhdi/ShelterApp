using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterApplication
{
    class Animal
    {
        private string rfid { get; set; }
        private string description { get; set; }
        private string dateBrought { get; set; }
        private string locationFound { get; set; }
        private Owner po;

        private double baseFee { get; set; }
        private double dailyFee { get; set; }
        private double adoptFee { get; set; }

        private bool info { get; set; }
        private bool paid { get; set; }

        public Animal(string rfid, string description, string dateBrought, string locationFound, Owner po, double baseFee, double dailyFee, double adoptFee, bool info, bool paid)
        {
            this.rfid = rfid;
            this.description = description;
            this.dateBrought = dateBrought;
            this.locationFound = locationFound;
            this.po = po;
            this.baseFee = baseFee;
            this.dailyFee = dailyFee;
            this.adoptFee = adoptFee;
            this.info = info;
            this.paid = paid;
        }
    }
}
