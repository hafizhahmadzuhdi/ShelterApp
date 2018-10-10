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
    public partial class HomeForm : Form
    {

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }


        private void addOwner_Click(object sender, EventArgs e)
        {
            AddOwnPanel.Show();
            AddOwnPanel.BringToFront();
        }

        private void addAnimal_Click(object sender, EventArgs e)
        {
            RfidPanel.Show();
        }

        private void bViewOwners_Click(object sender, EventArgs e)
        {
            OwnersPanel.Show();
        }

        private void tbViewAnimals_Click(object sender, EventArgs e)
        {
            //todo make sure the animals are loaded
            AnimalsPanel.Show();
        }

        private void bExitApp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to exit", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
            
        }

        private void bCreateOwner_Click(object sender, EventArgs e)
        {
            //todo make all the hiding of panels a generic event
            AddOwnPanel.Hide();
            //todo implement creation of Owner
        }

        private void bCancelAdd_Click(object sender, EventArgs e)
        {
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbFName.Text = "";
            tbLName.Text = "";
            tbOwnerID.Text = "";
            tbPhone.Text = "";
            AddOwnPanel.Hide();
        }

       
        

        private void bSubmitRFID_Click_1(object sender, EventArgs e)
        {
            RfidPanel.Hide();
            //todo  add new rfid / blank animal
        }

        private void btnLookForOwner_Click(object sender, EventArgs e)
        {
            //todo check if owner exists --> yes make box green --> no make box red
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAnmPanel.Hide();
            //todo clear values from panel
        }

        private void bCreateAnimal_Click(object sender, EventArgs e)
        {

            //todo call create animal function

            AddAnmPanel.Hide();
            
            //todo clear values from panel
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            AdoptPanel.Hide();
            //todo clear values
        }

        private void bAdopt_Click(object sender, EventArgs e)
        {
            //todo adopt the animal
            AdoptPanel.Hide();
            //todo clear values
        }

        private void bHome_Click(object sender, EventArgs e)
        {
            AnimalsPanel.Hide();
            //todo clear values
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //todo make buttons work
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //todo change content of grid box , also for other radio buttons
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnmDetailsPanel.Hide();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            //todo delete the animal
            AnmDetailsPanel.Hide();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            //todo save changes
            AnmDetailsPanel.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OwnersPanel.Hide();
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //todo add buttons for owner functions
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClaimPanel.Hide();
        }

        private void bClaim_Click(object sender, EventArgs e)
        {
            //todo claim the animal
            ClaimPanel.Hide();
        }

        private void bEditOwner_Click(object sender, EventArgs e)
        {
            //todo save details
            OwnDetailsPanel.Hide();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //todo delete owner
            OwnDetailsPanel.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OwnDetailsPanel.Hide();
        }
    }
}
