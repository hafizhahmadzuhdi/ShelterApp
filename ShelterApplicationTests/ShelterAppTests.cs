using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using ShelterApplication;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelterApplication.Tests
{
    [TestClass()]
    public class ShelterAppTests
    {
        //IMPORTANT
        //THINGS TO NOTE IN HERE
        //We focused on create a test for Adopt and Claim as what our teacher said



        Owner testOwner;
        //ShelterApp db = new ShelterApp();
        Animal testAnimal;
        Dog dogNoOwner;
        Cat catWithOwner;

        private static string host = "studmysql01.fhict.local";
        private static string user = "dbi409310";
        private static string password = "halobekasi";
        private static string database = "dbi409310";
        private MySqlConnection conn = new MySqlConnection(
            "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";" + "SslMode=none"
        );

        ShelterApp db = new ShelterApp();


        [TestMethod()]
        public void CreateNewOwner()
        {
            testOwner = new Owner(124, "TESTING", "TESTING", Convert.ToDateTime("2018-09-09"), "Testing", 100, "TESTING");
        }

        [TestMethod()]
        public void AddNewOwner()
        {
            testOwner = new Owner(124, "TESTING", "TESTING", Convert.ToDateTime("2018-09-09"), "Testing", 100, "TESTING");
            db.addOwner(testOwner);
        }

        [TestMethod()]
        public void CreateNewDog()
        {
            Dog dog = new Dog("9000", "DOG TESTING", Convert.ToDateTime("2018 - 09 - 09"), "Eindhoven", testOwner);

        }


        [TestMethod()]
        public void CreateNewCat()
        {
            Cat cat = new Cat("9001", "CAT TESTING", Convert.ToDateTime("2018 - 10 - 09"), "Eindhoven", "Cat Testing", testOwner);
        }


        [TestMethod()]
        public void AdoptTest()
        {
            Owner notDogOwner = new Owner(125, "TESTING", "TESTING", Convert.ToDateTime("2018-09-09"), "Testing", 100, "TESTING");
            db.addOwner(notDogOwner);
            dogNoOwner = new Dog("9000", "DOG TESTING", Convert.ToDateTime("2018 - 09 - 09"), "Eindhoven", null);
            db.addDog(dogNoOwner);
            dogNoOwner.calculateDays();
            db.calculateAdoptFee(dogNoOwner);
            db.Adopt(dogNoOwner, notDogOwner);

            //for adopt fee automattically will success if adopt success


        }

        [TestMethod()]
        public void ClaimTest()
        {
            Owner catOwner = new Owner(901, "TESTING", "TESTING", Convert.ToDateTime("2018-09-09"), "Testing", 100, "TESTING");
            db.addOwner(catOwner);
            catWithOwner = new Cat("9001", "CAT TESTING", Convert.ToDateTime("2018 - 10 - 09"), "Eindhoven", "Cat Testing", catOwner);
            db.addCat(catWithOwner);
            db.calculateClaimFee(catWithOwner);
            catWithOwner.calculateDays();
            db.Claim(catWithOwner);

            //for calculate fee automattically will success if claim success

        }

    }
}