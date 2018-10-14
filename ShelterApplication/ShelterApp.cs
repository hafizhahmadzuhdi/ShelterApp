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
            int po_id = 0;
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from cat b WHERE b.rfid = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            if (rdr[4].GetType() != typeof(DBNull))
                po_id = Convert.ToInt32(rdr[4]);

            Cat cat = new Cat(Convert.ToString(rdr[0]), Convert.ToString(rdr[1]), Convert.ToDateTime(rdr[2]), Convert.ToString(rdr[3]), Convert.ToString(rdr[5]), null);
            rdr.Close();
            conn.Close();

            if (po_id != 0)
                cat.setOwner(this.getOwnerById(po_id));

            return cat;
        }

        public Dog getDogByRFID(string id)
        {
            conn.Open();
            int po_id = 0;

            MySqlCommand cmd = new MySqlCommand("SELECT * from dog a WHERE a.rfid = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr[4].GetType() != typeof(DBNull))
                po_id = Convert.ToInt32(rdr[4]);

            Dog dog = new Dog(Convert.ToString(rdr[0]), Convert.ToString(rdr[1]), Convert.ToDateTime(rdr[2]), Convert.ToString(rdr[3]), null);
            rdr.Close();
            conn.Close();

            if (po_id != 0)
                dog.setOwner(this.getOwnerById(po_id));

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

        public void updateOwner(Owner o)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE owner SET lastName=@lastName, firstName=@firstName, dob=@dob, address=@address, phone=@phone, email=@email" + " WHERE ownerID=@ownerID", conn);
            cmd.Parameters.AddWithValue("@ownerID", o.getOwnerId());
            cmd.Parameters.AddWithValue("@lastName", o.getLastName());
            cmd.Parameters.AddWithValue("@firstName", o.getFirstName());
            cmd.Parameters.AddWithValue("@dob", o.getDob());
            cmd.Parameters.AddWithValue("@address", o.getAddress());
            cmd.Parameters.AddWithValue("@phone", o.getOwnerId());
            cmd.Parameters.AddWithValue("@email", o.getEmail());
            Console.WriteLine(o.getLastName());
            Console.WriteLine(o.getOwnerId());
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void dropOwner(int id)
        {
            string query = string.Format("DELETE FROM owner WHERE ownerID = '") + id + string.Format("';");
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        public Owner getOwnerById(int id){

            conn.Open();
            Owner owner = null;
                
            MySqlCommand cmd = new MySqlCommand("SELECT * from owner o WHERE o.ownerId = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
                owner = new Owner(Convert.ToInt32(rdr[0]), Convert.ToString(rdr[1]), Convert.ToString(rdr[2]), Convert.ToDateTime(rdr[3]), Convert.ToString(rdr[4]), Convert.ToInt32(rdr[5]), Convert.ToString(rdr[6]));
            else
                throw new Exception("cannot find owner");

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

        public DataSet getAnimalsByStatus(string status)
        {
            DataSet ds = new DataSet();
            conn.Open();
            string query = string.Format("SELECT rfid, 'dog' AS species, status FROM dog WHERE status like '" + status + "' UNION SELECT rfid, 'cat' AS species, status FROM cat WHERE status like '" + status + "'");
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
            MySqlCommand cmd = new MySqlCommand("SELECT rfid, description, dateBrought, locationFound, po, status from dog", conn);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<int> po_ids = new List<int>();
            while (rdr.Read()){
                Dog dog = new Dog(
                    Convert.ToString(rdr[0]), //rfid
                    Convert.ToString(rdr[1]), //desc
                    Convert.ToDateTime(rdr[2]), //datebrought
                    Convert.ToString(rdr[3]), // loc found
                    null// po
                );
                if (rdr[4].GetType() != typeof(DBNull))
                    po_ids.Add(Convert.ToInt32(rdr[4]));
                else
                    po_ids.Add(0);
                dog.setStatus(rdr[5].ToString());
                resp.Add(dog);
            }
            rdr.Close();

            // cats
            MySqlCommand cmd_cat = new MySqlCommand("SELECT rfid, description, dateBrought, locationFound, extra, po, status from cat", conn);
            cmd_cat.Prepare();
            MySqlDataReader rdr_cat = cmd_cat.ExecuteReader();
            while (rdr_cat.Read())
            {
                Cat cat = new Cat(
                    Convert.ToString(rdr_cat[0]), //rfid
                    Convert.ToString(rdr_cat[1]), //desc
                    Convert.ToDateTime(rdr_cat[2]), //datebrought
                    Convert.ToString(rdr_cat[3]), // loc found
                    Convert.ToString(rdr_cat[4]), // extra
                    null // po
                );
                if (rdr_cat[5].GetType() != typeof(DBNull))
                    po_ids.Add(Convert.ToInt32(rdr_cat[5]));
                else
                    po_ids.Add(0);

                cat.setStatus(rdr_cat[6].ToString());
                resp.Add(cat);
            }
            rdr_cat.Close();
            conn.Close();

            for (int i = 0; i < resp.Count - 1; i++)
            {
                if (po_ids[i] != 0)
                    resp[i].setOwner(this.getOwnerById(po_ids[i]));
            }

            return resp;
        }

        public void updateStatus(){
            List<Animal> animals = this.getAnimalsList();
            foreach (Animal animal in animals){
                if (animal.getStatusAsString() == "notYetAdoptable" && animal.calculateDays() >= 20)
                { // if more than 20 days
                    animal.setStatus("adoptable");
                    this.updateAnimal(animal);
                }
            }
        }

        public void updateAnimal(Animal animal){
            string extra = "";
            string species = "";
            string lastWalked = "";
            if (animal.GetType() == typeof(Cat))
            {
                species = "cat";
                extra = ", extra=@extra";
            }
            else if (animal.GetType() == typeof(Dog))
            {
                species = "dog";
                lastWalked = ", lastWalked=@lastWalked";
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
            } else if (species == "dog")
            {
                Dog dog = (Dog)animal;
                cmd.Parameters.AddWithValue("@lastWalked", dog.getLastWalked());
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


        public void Claim(Animal a)
        {
            a.setStatus("claimed");
            this.updateAnimal(a);
        }

        public void Adopt(Animal a, Owner o)
        {
            Console.WriteLine(a.getRfid());
            int d = a.calculateDays();
            if ( d >= 20)
            {
                if(a.getPoId() == 0)
                {
                    int id = o.getOwnerId();
                    a.setStatus("adopted");
                    a.setOwner(o);
                    this.updateAnimal(a);
                }

            } else
            {
                throw new Exception("Animal cannot be adopted yet, "+(20 - d)+" days remain.");
                //when somebody clicking the Adopt button while the days are still less than 20
                
                //a.setSetatus("notYetAdoptable");
            }
          
        }


        public void DeleteAnimal(Animal a)
        {
            string s ="cat"; if (a.GetType() == typeof(Dog)) { s = "dog"; }
            conn.Open();
            string query = string.Format("DELETE FROM ") + s + string.Format(" WHERE rfid = '") + a.getRfid() + string.Format("';");
            
            MySqlCommand cmd = new MySqlCommand(query, conn);
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
