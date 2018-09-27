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
    public partial class AdoptAnimal : Form
    {
        public AdoptAnimal()
        {
            InitializeComponent();
        }

        private void AdoptAnimal_Load(object sender, EventArgs e)
        {

        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            ShowAnimals showAnimals = new ShowAnimals();
            showAnimals.Show();
            this.Close();
        }

        private void bAdopt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Animal is adopted and is now archived in the system.");
            HomeForm home = new HomeForm();
            home.Show();
            this.Close();
        }
    }
}
