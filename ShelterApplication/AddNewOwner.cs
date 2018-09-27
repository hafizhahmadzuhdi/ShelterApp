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
        public AddNewOwner()
        {
            InitializeComponent();
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
            HomeForm home = new HomeForm();
            this.Close();
            home.Show();
        }

        private void bCreateAnimal_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            MessageBox.Show("Owner Successfully Added");
            this.Close();
            home.Show();
        }
    }
}
