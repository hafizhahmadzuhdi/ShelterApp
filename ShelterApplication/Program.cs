using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data;

namespace ShelterApplication
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 




        public static void showOwner()
        {
            
        }

        

        public void getAnimalInfo()
        {
            
        }

        public Animal selectAdoptAnimal(Animal a)
        {
            return a;
        }


        public Animal selectClaimAnimal(Animal a)
        {
            return a;
        }

        public void Claim(Animal a, Owner o)
        {

        }

        public Boolean checkOwner(Owner o)
        {
            return false;
        }

        public Boolean checkPaid(Animal a)
        {
            return false;
        }

        public void adopt(Animal a, Owner o)
        {

        }

        public void getOwner()
        {

        }

        //public List<Animal> getOverviewOfAnimals()
        //{
          
        //}

        public void getOverviewofAnimals()
        {
            //return ListAnimal;
        }

        public  void getOverviewofAnimals(string status)
        {
            //return list of animals that selected based on some status
        }

        public void filterAnimalByStatus()
        {
            //Idkwhat is it
        }

        public void getOverviewofOwners()
        {

        }

        public void giveListofAnimalsByOwnerName(Owner o)
        {
            //
        }




        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomeForm());


        }

        
    }
}
