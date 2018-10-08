using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShelterApplication
{
    public partial class AddNewOwner : Form
    {
        String fname, lname, address, dob, email;
        int ownerID, phone;
        HomeForm home = new HomeForm();
        Owner myOwner;


        public AddNewOwner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void AddNewOwner_Load(object sender, EventArgs e)
        {

        }

        private void bCancelAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void bCreateAnimal_Click(object sender, EventArgs e)
        {
            /* HomeForm home = new HomeForm();
             MessageBox.Show("Owner Successfully Added");
             this.Close();
             home.Show();
             */

            


            if (tbFName.Text == string.Empty || tbLName.Text == string.Empty || tbEmail.Text == string.Empty || tbPhone.Text == string.Empty || dtpDobOwner.Text == string.Empty || tbAddress.Text == string.Empty || tbOwnerID.Text == string.Empty)
            {
                MessageBox.Show("Please Enter a valid value");
            }

            else
            {
                
                Owner newOwner = new Owner();
                //not finished yet
                fname = tbFName.Text;
                lname = tbLName.Text;
                email = tbEmail.Text;
                phone = Convert.ToInt32(tbPhone.Text);
                dob = Convert.ToString(dtpDobOwner.Text);
                address = tbAddress.Text;
                ownerID = Convert.ToInt32(tbOwnerID.Text);

                try
                {
                    string host = "studmysql01.fhict.local";
                    string user = "dbi409310";
                    string password = "halobekasi";
                    string database = "dbi409310";
                    string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";" + "SslMode=none";

                    MySqlConnection conn = new MySqlConnection();
                    conn.Open();

                    MySqlCommand mycommand;
                    mycommand = conn.CreateCommand();
                    mycommand.CommandText = "INSERT INTO owner (ownerID, lastName, firstName, dob, address, phone, email) VALUES (" + "'" +
                                            ownerID + "', '" +
                                            lname + "', '" +
                                            fname + "', '" +
                                            dob + "', '" +
                                            address + "', '" +
                                            phone + "', '" +
                                            email + "');";

                    mycommand.ExecuteNonQuery();

                    fname = "";
                    lname = "";
                    email = "";
                    phone = 0;
                    dob = "";
                    address = "";
                    ownerID = 0;

                    MessageBox.Show("Add New Owner Success");
                    

                    this.Close();
                    home.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
    }
}
