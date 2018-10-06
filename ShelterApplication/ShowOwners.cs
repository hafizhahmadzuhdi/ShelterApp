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
    public partial class ShowOwners : Form
    {

        string query;
        private DataSet ds = new DataSet();
        public ShowOwners()
        {
            InitializeComponent();


        }

        public void getOurOwner()
        {

            //try
            //{
            //    string host = "studmysql01.fhict.local";
            //    string user = "dbi409310";
            //    string password = "halobekasi";
            //    string database = "dbi409310";
            //    string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";" + "SslMode=none";

            //    MySqlConnection conn = new MySqlConnection();
            //    conn.Open();
            //    MessageBox.Show("Connection Success");

            //    //Connection success

            //    MySqlCommand mycommand;
            //    DataTable dt = new DataTable();
            //    MySqlDataAdapter adapt = new MySqlDataAdapter("SELECT * FROM owner", conn);
            //    adapt.Fill(dt);
            //    dataGridView1.DataSource = dt;
            //    conn.Close();

            //}
            //catch(Exception err)
            //{
            //    MessageBox.Show(err.ToString());
            //}


            string host = "studmysql01.fhict.local";
            string user = "dbi409310";
            string password = "halobekasi";
            string database = "dbi409310";
            string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";" + "SslMode=none";
            string query = "";
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                MessageBox.Show("Connection Successful");
                query = string.Format("SELECT ownerID, firstName, lastName FROM owner");
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                conn.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[2].HeaderText = "First Name";
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[1].HeaderText = "Last Name";

                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                editButton.Width = 80;
                dataGridView1.Columns.Add(editButton);

                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.Width = 80;
                dataGridView1.Columns.Add(deleteButton);





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ShowOwners_Load(object sender, EventArgs e)
        {
            getOurOwner();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void cbAdoptable_CheckedChanged(object sender, EventArgs e)
        {
            //ignore
        }

        private void tbNotYetAdoptable_CheckedChanged(object sender, EventArgs e)
        {
            //ignore
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //ignore
        }

        private void tbSearchAnimals_TextChanged(object sender, EventArgs e)
        {

        }

        private void bHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Close();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            EditOwner editOwner = new EditOwner();
            editOwner.Show();
            this.Close();
        }

        private void bViewOwnersAnimals_Click(object sender, EventArgs e)
        {
            ViewOwnersAnimals viewOwnersAnimals = new ViewOwnersAnimals();
            viewOwnersAnimals.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
