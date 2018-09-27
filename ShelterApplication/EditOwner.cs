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
    public partial class EditOwner : Form
    {
        public EditOwner()
        {
            InitializeComponent();
        }

        private void bEditOwner_Click(object sender, EventArgs e)
        {
            ShowOwners showOwners = new ShowOwners();
            this.Close();
            showOwners.Show();
        }

        private void bCancelAdd_Click(object sender, EventArgs e)
        {
            ShowOwners showOwners = new ShowOwners();
            this.Close();
            showOwners.Show();
        }
    }
}
