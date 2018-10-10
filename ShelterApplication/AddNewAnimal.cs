using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADODB;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ShelterApplication
{
    public partial class AddNewAnimal : Form
    {

        string rfid, description, dateBrought, locationFound, species, status, extraInfo, lastWalked;
        int ? po;
        string nullable;

        public AddNewAnimal(string x)
        {
            InitializeComponent();
            tbDisplayRFID.Text = x;
        }

        

        private void AddNewAnimal_Load(object sender, EventArgs e)
        {

        }

        private void bCancelAdd_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            this.Close();
            home.Show();
        }

        public static object ToDbNull(object value)
        {
            if (null != value)
                return value;
            return DBNull.Value;
        }

        private void bCreateAnimal_Click(object sender, EventArgs e)
        {
            //HomeForm home = new HomeForm();
            //MessageBox.Show("Animal Successfully Added");
            //this.Close();
            //home.Show();
            if (tbDescription.Text == string.Empty || ddSpecies.Text == string.Empty || tbLocationFound.Text == string.Empty || dtpAddAnimal.Text == string.Empty || tbDisplayRFID.Text == string.Empty)
            {
                MessageBox.Show("Please Enter a valid value");
            }

            else
            {
                rfid = tbDisplayRFID.Text;
                description = tbDescription.Text;
                dateBrought = Convert.ToString(dtpAddAnimal);
                locationFound = tbLocationFound.Text;
                if (tbOwner.Text != string.Empty)
                {
                    po = Convert.ToInt32(tbOwner.Text);
                } else
                {
                    po = null;
                }
                species = ddSpecies.Text;
                status = "notYetAdoptable";
                extraInfo = tbExtra.Text;
                Console.WriteLine(po);

                try
                {
                    string host = "studmysql01.fhict.local";
                    string user = "dbi409310";
                    string password = "halobekasi";
                    string database = "dbi409310";
                    string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";" + "SslMode=none";

                    MySqlConnection conn = new MySqlConnection(connStr);
                    conn.Open();
                    MessageBox.Show(Convert.ToString(po));

                    MySqlCommand mycommand;
                    mycommand = conn.CreateCommand();
                    mycommand.CommandText = "INSERT INTO animal (rfid, description, dateBrought, locationFound, po, species, status, extraInfo) VALUES (" + "'" +
                                            rfid + "', '" +
                                            description + "', '" +
                                            dateBrought + "', '" +
                                            locationFound + "', " +
                                            po + ", '" +
                                            species + "', '" +
                                            status + "', '" +
                                            extraInfo + "');";
                    mycommand.ExecuteNonQuery();
                    MessageBox.Show("Animal Successfully Addedd");
                        
                    rfid = "";
                    description = "";
                    dateBrought = "";
                    locationFound = "";
                    po = null;
                    nullable = "";
                    species = "";
                    status = "";
                    extraInfo = "";
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //ignore
        }

        private void TestConnection_Click(object sender, EventArgs e)
        {
            //string host = "studmysql01.fhict.local";
            //string user = "dbi409310";
            //string password = "halobekasi";
            //string database = "dbi409310";
            //string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";" +"SslMode=none";


            //MySqlConnection conn = new MySqlConnection(connStr);

            //try
            //{
            //    conn.Open();
            //    MessageBox.Show("Koneksi berhasil");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void tbDateFound_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDisplayRFID_TextChanged(object sender, EventArgs e)
        {
            //AddAnimalRFID myform = new AddAnimalRFID();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
