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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowAnimals_Load(object sender, EventArgs e)
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
