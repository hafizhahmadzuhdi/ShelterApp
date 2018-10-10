using System;
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
                MySqlCommand mycommand;
                mycommand = conn.CreateCommand();
                mycommand.CommandText = "INSERT INTO dog (rfid, description, dateBrought, locationFound, po, status, lastWalked) VALUES (" + "'" +
                        dog.getRfid() + "', '" +
                        dog.getDescription() + "', '" +
                        dog.getDateBrought() + "', '" +
                        dog.getLocationFound() + "', " +
                        dog.getPoId() + ", '" +
                        "notYetAdoptable'" + ", NULL" +

                ");";
                mycommand.ExecuteNonQuery();
                conn.Close();
        }

        public void addCat(Cat cat)
        {
            conn.Open();
            MySqlCommand mycommand;
            mycommand = conn.CreateCommand();
            mycommand.CommandText = "INSERT INTO cat (rfid, description, dateBrought, locationFound, po, status, extra) VALUES (" + "'" +
                    cat.getRfid() + "', '" +
                    cat.getDescription() + "', '" +
                    cat.getDateBrought() + "', '" +
                    cat.getLocationFound() + "', " +
                    cat.getPoId() + ", '" +
                "notYetAdoptable'" + ", '" + cat.getExtra() + "'" +

            ");";
            mycommand.ExecuteNonQuery();
            conn.Close();
        }

        public Owner getOwnerById(int id){
            conn.Open();
            MySqlCommand mycommand = conn.CreateCommand();
            mycommand.CommandText = "SELECT * from owner o WHERE o.ownerId =" + id;
            Object result = mycommand.ExecuteScalar();

            MySqlDataReader rdr = mycommand.ExecuteReader();

            rdr.Read();
            Owner owner = new Owner(Convert.ToInt32(rdr[0]), Convert.ToString(rdr[1]), Convert.ToString(rdr[2]), Convert.ToString(rdr[3]), Convert.ToString(rdr[4]), Convert.ToInt32(rdr[5]), Convert.ToString(rdr[6]));

            rdr.Close();
            conn.Close();

            return owner;

        }
    }
}
