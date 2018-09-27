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
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowOwners showOwners = new ShowOwners();
            this.Hide();
            showOwners.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowAnimals showAnimals = new ShowAnimals();
            this.Hide();
            showAnimals.Show();
        }

        private void addOwner_Click(object sender, EventArgs e)
        {
            AddNewOwner addNewOwner = new AddNewOwner();
            addNewOwner.Show();
            this.Hide();
        }

        private void addAnimal_Click(object sender, EventArgs e)
        {
            AddAnimalRFID addAnimalRFID = new AddAnimalRFID();
            addAnimalRFID.Show();
            this.Hide();
        }

        private void bViewOwners_Click(object sender, EventArgs e)
        {
            ShowOwners showOwners = new ShowOwners();
            this.Hide();
            showOwners.Show();
        }

        private void tbViewAnimals_Click(object sender, EventArgs e)
        {
            ShowAnimals showAnimals = new ShowAnimals();
            this.Hide();
            showAnimals.Show();
        }

        private void bExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
