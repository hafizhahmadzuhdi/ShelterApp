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
    public partial class AddAnimalRFID : Form
    {
        public AddAnimalRFID()
        {
            InitializeComponent();
        }

        private void submitRFID_Click(object sender, EventArgs e)
        {
            AddNewAnimal addNewAnimal = new AddNewAnimal();
            this.Close();
            addNewAnimal.Show();
        }

        private void AddAnimalRFID_Load(object sender, EventArgs e)
        {

        }
    }
}
