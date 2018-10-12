using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace ShelterApplication
{
    public class ShelterApp
    {
        private static string host = "studmysql01.fhict.local";
        private static string user = "dbi409310";
        private static string password = "halobekasi";
        private static string database = "dbi409310";
        private MySqlConnection conn = new MySqlConnection(
            "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";" + "SslMode=none"
        );

        public void addDog(Dog dog){
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO dog (rfid, description, dateBrought, locationFound, po, status, lastWalked) VALUES" +
                                                "(@rfid, @desc, @db, @lf, @po, @status, @lw)", conn);
                 
            cmd.Parameters.AddWithValue("@rfid", dog.getRfid());
            cmd.Parameters.AddWithValue("@desc", dog.getDescription());
            cmd.Parameters.AddWithValue("@db", dog.getDateBrought());
            cmd.Parameters.AddWithValue("@lf", dog.getLocationFound());

            if (dog.getPoId() != 0)
                cmd.Parameters.AddWithValue("@po", dog.getPoId());
            else
                cmd.Parameters.AddWithValue("@po", null);

            cmd.Parameters.AddWithValue("@status", "notYetAdoptable");
            cmd.Parameters.AddWithValue("@lw", null);

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void addCat(Cat cat)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO cat(rfid, description, dateBrought, locationFound, po, status, extra) VALUES" +
                                                "(@rfid, @desc, @db, @lf, @po, @status, @extra)", conn);
            cmd.Parameters.AddWithValue("@rfid", cat.getRfid());
            cmd.Parameters.AddWithValue("@desc", cat.getDescription());
            cmd.Parameters.AddWithValue("@db", cat.getDateBrought());
            cmd.Parameters.AddWithValue("@lf", cat.getLocationFound());

            if (cat.getPoId() != 0)
                cmd.Parameters.AddWithValue("@po", cat.getPoId());
            else
                cmd.Parameters.AddWithValue("@po", null);

            cmd.Parameters.AddWithValue("@status", "notYetAdoptable");
            cmd.Parameters.AddWithValue("@extra", cat.getExtra());

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void addOwner(Owner owner)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO owner (ownerID, lastName, firstName, dob, address, phone, email)  VALUES" +
                                                "(@ownId, @lName, @fName, @dob, @add, @phone, @email)", conn);

            cmd.Parameters.AddWithValue("@ownId", owner.getOwnerId());
            cmd.Parameters.AddWithValue("@lName", owner.getLastName());
            cmd.Parameters.AddWithValue("@fName", owner.getFirstName());
            cmd.Parameters.AddWithValue("@dob", owner.getDob());
            cmd.Parameters.AddWithValue("@add", owner.getAddress());
            cmd.Parameters.AddWithValue("@phone", owner.getPhoneOwner());
            cmd.Parameters.AddWithValue("@email", owner.getEmail());
            
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Cat getCatByRFID(string id)
        {
            // TODO do we really need two methods here? I'm pretty sure we can make do with one.
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from cat b WHERE b.rfid = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            Cat cat = new Cat(Convert.ToString(rdr[0]), Convert.ToString(rdr[1]), Convert.ToDateTime(rdr[2]), Convert.ToString(rdr[3]), Convert.ToString(rdr[4]), null);
            rdr.Close();
            conn.Close();

            return cat;
        }

        public Dog getDogByRFID(string id)
        {

            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from dog a WHERE a.rfid = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            Dog dog = new Dog(Convert.ToString(rdr[0]), Convert.ToString(rdr[1]), Convert.ToDateTime(rdr[2]), Convert.ToString(rdr[3]), null);
            rdr.Close();
            conn.Close();

            return dog;

        }

        //public Animal getAnimalByRFID(string id, string species)
        //{
        //    //it supposed to be work by the type of ANIMAL
        //    conn.Open();
        //    MySqlCommand cmd = new MySqlCommand("SELECT * from dog a WHERE a.rfid = @id UNION SELECT * FROM cat b WHERE b.rfid = @id", conn);
        //    cmd.Parameters.AddWithValue("@id", id);
        //    cmd.Prepare();
        //    MySqlDataReader rdr = cmd.ExecuteReader();
        //    rdr.Read();
        //    Dog dog;
        //    Cat cat;

        //    if (species == "Cat")
        //    {
        //        cat = new Cat(Convert.ToString(rdr[0]), Convert.ToString(rdr[1]), Convert.ToString(rdr[2]), Convert.ToString(rdr[3]), Convert.ToString(rdr[4]), null);
        //        rdr.Close();
        //        conn.Close();

        //        return cat;
        //    } else if (species == "Dog")
        //    {
        //        dog = new Dog(Convert.ToString(rdr[0]), Convert.ToString(rdr[1]), Convert.ToString(rdr[2]), Convert.ToString(rdr[3]), null);
        //        rdr.Close();
        //        conn.Close();

        //        return dog;
        //    }
        //    return cat;
        //}

        public Owner getOwnerById(int id){
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from owner o WHERE o.ownerId = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Owner owner = new Owner(Convert.ToInt32(rdr[0]), Convert.ToString(rdr[1]), Convert.ToString(rdr[2]), Convert.ToDateTime(rdr[3]), Convert.ToString(rdr[4]), Convert.ToInt32(rdr[5]), Convert.ToString(rdr[6]));
            rdr.Close();
            conn.Close();

            return owner;

        }

       

        public DataSet getAllOwners()
        {
            DataSet ds = new DataSet();
            conn.Open();
            string query = string.Format("SELECT ownerID, firstName, lastName from owner");
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            command.ExecuteNonQuery();
            ds.Clear();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet getAllAnimals()
        {
            DataSet ds = new DataSet();
            conn.Open();
            string query = string.Format("SELECT rfid, 'dog' AS species, status FROM dog UNION SELECT rfid, 'cat' AS species, status FROM cat");
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            command.ExecuteNonQuery();
            ds.Clear();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet getAnimals(string status)
        {
            DataSet ds = new DataSet();
            conn.Open();
            string query = string.Format("SELECT rfid, 'dog' AS species, status FROM dog UNION SELECT rfid, 'cat' AS species, status FROM cat WHERE status ="+status);
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            command.ExecuteNonQuery();
            ds.Clear();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }


        public DataSet getNotYetAdoptableAnimalsDateBrought(){
            DataSet ds = new DataSet();
            conn.Open();
            string query = string.Format("SELECT rfid, dateBrought FROM dog UNION SELECT rfid, dateBrought FROM cat");
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            command.ExecuteNonQuery();
            ds.Clear();
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public List<Animal> getAnimalsList(){
            conn.Open();
            List<Animal> resp = new List<Animal>();

            // dogs
            MySqlCommand cmd = new MySqlCommand("SELECT rfid, description, dateBrought, locationFound, po from dog", conn);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read()){
                Owner po;
                if (rdr[4].GetType() != typeof(DBNull))
                    po = this.getOwnerById(Convert.ToInt32(rdr[4]));
                else
                    po = null;

                Dog dog = new Dog(
                    Convert.ToString(rdr[0]), //rfid
                    Convert.ToString(rdr[1]), //desc
                    Convert.ToDateTime(rdr[2]), //datebrought
                    Convert.ToString(rdr[3]), // loc found
                    po// po
                );
                resp.Add(dog);
            }
            rdr.Close();

            // cats
            MySqlCommand cmd_cat = new MySqlCommand("SELECT rfid, description, dateBrought, locationFound, extra, po from cat", conn);
            cmd_cat.Prepare();
            MySqlDataReader rdr_cat = cmd_cat.ExecuteReader();
            while (rdr_cat.Read())
            {
                Owner po;
                if (rdr_cat[5].GetType() != typeof(DBNull))
                    po = this.getOwnerById(Convert.ToInt32(rdr[4]));
                else
                    po = null;
                Cat cat = new Cat(
                    Convert.ToString(rdr_cat[0]), //rfid
                    Convert.ToString(rdr_cat[1]), //desc
                    Convert.ToDateTime(rdr_cat[2]), //datebrought
                    Convert.ToString(rdr_cat[3]), // loc found
                    Convert.ToString(rdr_cat[4]), // extra
                    po // po
                );
                resp.Add(cat);
            }
            rdr_cat.Close();

            conn.Close();

            return resp;
        }

        public void updateStatus(){
            List<Animal> animals = this.getAnimalsList();
            foreach (Animal animal in animals){
                if (animal.getStatusAsString() == "notYetAdoptable" && animal.calculateDays() >= 20){ // if more than 20 days
                    animal.setStatus("adoptable");
                    this.updateAnimal(animal);
                }
            }
        }

        public void updateAnimal(Animal animal){
            string extra = "";
            string species = "";
            if (animal.GetType() == typeof(Cat))
            {
                species = "cat";
                extra = ", extra=@extra";
            }
            else if (animal.GetType() == typeof(Dog))
            {
                species = "dog";
            }
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE "+species+" SET description=@desc, dateBrought=@db, locationFound=@lf, po=@po, status=@status"+extra+" WHERE rfid=@rfid", conn);
            cmd.Parameters.AddWithValue("@rfid", animal.getRfid());
            cmd.Parameters.AddWithValue("@desc", animal.getDescription());
            cmd.Parameters.AddWithValue("@db", animal.getDateBrought());
            cmd.Parameters.AddWithValue("@lf", animal.getLocationFound());
            if (species =="cat")
            {
                Cat cat = (Cat)animal;
                cmd.Parameters.AddWithValue("@extra", cat.getExtra());
            }

            if (animal.getPoId() != 0)
                cmd.Parameters.AddWithValue("@po", animal.getPoId());
            else
                cmd.Parameters.AddWithValue("@po", null);

            cmd.Parameters.AddWithValue("@status", animal.getStatusAsString());

            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        public void Claim(Animal a, Owner o)
        {
            //we need to assign
        }

        public void Adopt(Animal a, Owner o)
        {
            
            if(a.calculateDays() >= 20)
            {
                if(a.getPoId() == null)
                {
                    int id = o.getOwnerId();
                    a.setStatus("adopted");

                    if (a.GetType() == typeof(Dog)) 
                    {
                        conn.Open();
                        string query = string.Format("UPDATE dog SET status='adopted' WHERE rfid ='" + a.getRfid() + "'");
                        MySqlCommand command = new MySqlCommand(query, conn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        command.ExecuteNonQuery();
                    } else if(a.GetType() == typeof(Cat)){
                        conn.Open();
                        string query = string.Format("UPDATE dog SET status='adopted' WHERE rfid ='" + a.getRfid() + "'");
                        MySqlCommand command = new MySqlCommand(query, conn);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        command.ExecuteNonQuery();

                    }


                    //a.setSetatus("adopted");

                }

            } else
            {
                //when somebody clicking the Adopt button while the days are still less than 20
                
                //a.setSetatus("notYetAdoptable");
            }
          
        }


        public void DeleteAnimal(Animal a)
        {
            string s ="cat"; if (a.GetType() == typeof(Dog)) { s = "dog"; }
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM"+s+"WHERE rfid=@rfid", conn);
            cmd.Parameters.AddWithValue("@rfid", a.getRfid());
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        

        

        public MySqlConnection getConn()
        {
            return this.conn;
        }


    }
}
