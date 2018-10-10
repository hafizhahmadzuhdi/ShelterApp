using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace ShelterApplication
{
    public class Database
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

        public Owner getOwnerById(int id){
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from owner o WHERE o.ownerId = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();
            MySqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            Owner owner = new Owner(Convert.ToInt32(rdr[0]), Convert.ToString(rdr[1]), Convert.ToString(rdr[2]), Convert.ToString(rdr[3]), Convert.ToString(rdr[4]), Convert.ToInt32(rdr[5]), Convert.ToString(rdr[6]));
            rdr.Close();
            conn.Close();

            return owner;

        }

        public DataSet getAllAnimals(){
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
    }
}
