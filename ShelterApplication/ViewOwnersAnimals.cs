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
    public partial class ViewOwnersAnimals : Form
    {
        public ViewOwnersAnimals()
        {
            InitializeComponent();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            ShowOwners showOwners = new ShowOwners();
            showOwners.Show();
            this.Close();
        }
    }
}
