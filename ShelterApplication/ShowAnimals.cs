﻿using MySql.Data.MySqlClient;
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
    public partial class ShowAnimals : Form
    {
        public ShowAnimals()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();

        public void getAnimal()
        {
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
                query = string.Format("SELECT rfid, species, status FROM animal");
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
                conn.Close();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 80;
                //dataGridView1.Columns[2].Width = 80;
                //dataGridView1.Columns[2].HeaderText = "rfid";
                //dataGridView1.Columns[1].Width = 80;
                //dataGridView1.Columns[1].HeaderText = "species";

                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.HeaderText = "Adopt";
                editButton.Text = "Adopt";
                editButton.UseColumnTextForButtonValue = true;
                editButton.Width = 80;
                dataGridView1.Columns.Add(editButton);

                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.HeaderText = "Claim";
                deleteButton.Text = "Claim";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.Width = 80;
                dataGridView1.Columns.Add(deleteButton);

            }
            catch
            {
                MessageBox.Show("Sorry can't connect to Database");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowAnimals_Load(object sender, EventArgs e)
        {
            getAnimal();
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Close();
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            EditAnimals editAnimals = new EditAnimals();
            this.Close();
            editAnimals.Show();
        }

        private void bAdopt_Click(object sender, EventArgs e)
        {
            AdoptAnimal adoptAnimal = new AdoptAnimal();
            adoptAnimal.Show();
            this.Close();
        }

        private void bClaim_Click(object sender, EventArgs e)
        {
            ClaimAnimal claimAnimal = new ClaimAnimal();
            claimAnimal.Show();
            this.Close();
        }
    }
}
