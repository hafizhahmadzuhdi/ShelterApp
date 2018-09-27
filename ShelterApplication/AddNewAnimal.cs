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
    }
}
