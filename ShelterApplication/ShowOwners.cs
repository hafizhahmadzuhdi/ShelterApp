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
        public ShowOwners()
        {
            InitializeComponent();
        }

        private void ShowOwners_Load(object sender, EventArgs e)
        {

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
    }
}
