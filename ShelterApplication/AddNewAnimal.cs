using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ShelterApplication
{
    public partial class AddNewAnimal : Form
    {
        public AddNewAnimal()
        {
            InitializeComponent();
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

        private void bCreateAnimal_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            MessageBox.Show("Animal Successfully Added");
            this.Close();
            home.Show();
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
    }
}
