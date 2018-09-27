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
    public partial class ClaimAnimal : Form
    {
        public ClaimAnimal()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            ShowAnimals showAnimals = new ShowAnimals();
            showAnimals.Show();
            this.Close();
        }

        private void bClaim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Animal is claimed and is now archived in the system.");
            HomeForm home = new HomeForm();
            home.Show();
            this.Close();
        }
    }
}
