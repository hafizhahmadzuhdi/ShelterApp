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
    public partial class EditAnimals : Form
    {
        public EditAnimals()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            ShowAnimals showAnimals = new ShowAnimals();
            this.Close();
            showAnimals.Show();
        }

        private void bCancelAdd_Click(object sender, EventArgs e)
        {
            ShowAnimals showAnimals = new ShowAnimals();
            this.Close();
            showAnimals.Show();
        }
    }
}
