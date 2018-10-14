using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ShelterApplication
{
    public partial class HomeForm : Form
    {
        //Attributes for adding
        //string rfid, description, locationFound, species, status, extraInfo, lastWalked;
        Owner po;
        DateTime dateBrought;
        DateTime dob;
        String fname, lname, address, email;
        int ownerID, phone;

        
        ShelterApp db = new ShelterApp();


        //Attributes for displaying
        DataSet ds = new DataSet();

        //Attributes for Adopt and Claim
        Animal animal;
        Owner owner_claiming;

        //Attributes for get


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
        }

        private void addAnimal_Click(object sender, EventArgs e)
        {
            RfidPanel.Show();
        }

        private void bViewOwners_Click(object sender, EventArgs e)
        {
            OwnersPanel.Show();

            //This is for showing the owners
            ds = db.getAllOwners();
            dataGridView2.DataSource = ds.Tables[0];
            dataGridView2.Columns[1].Width = 80;
            dataGridView2.Columns[1].HeaderText = "First Name";
            dataGridView2.Columns[2].Width = 80;
            dataGridView2.Columns[2].HeaderText = "Last Name";

            if (dataGridView2.ColumnCount < 4)
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                editButton.Width = 50;
                dataGridView2.Columns.Add(editButton);


                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.Width = 50;
                dataGridView2.Columns.Add(deleteButton);

            }


        }

        //This is a method for selecting selected cells
        private void claimButton_Click(object sender, System.EventArgs e)
        {
            Int32 selectedCellCount =
                dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb =
                        new System.Text.StringBuilder();

                    for (int i = 0;
                        i < selectedCellCount; i++)
                    {
                        sb.Append("Row: ");
                        sb.Append(dataGridView1.SelectedCells[i].RowIndex
                            .ToString());
                        sb.Append(", Column: ");
                        sb.Append(dataGridView1.SelectedCells[i].ColumnIndex
                            .ToString());
                        sb.Append(Environment.NewLine);
                    }

                    sb.Append("Total: " + selectedCellCount.ToString());
                    MessageBox.Show(sb.ToString(), "Selected Cells");
                }
            }
        }

        private void tbViewAnimals_Click(object sender, EventArgs e)
        {
            //todo make sure the animals are loaded
            AnimalsPanel.Show();
                // everytime we show the list we update the status
                db.updateStatus();
                //this is the method for showing All the animals
                ds = db.getAllAnimals();
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[1].Width = 80;
                dataGridView1.Columns[1].HeaderText = "Species";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[2].HeaderText = "Status";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //this is for fixing bugs
            //if (dataGridView1.Columns[3].Index == 0 && dataGridView1.Columns[4].Index == 0)
            if(dataGridView1.ColumnCount<4)
            {
                DataGridViewButtonColumn claimButton = new DataGridViewButtonColumn();
                claimButton.HeaderText = "Claim";
                claimButton.Text = "Claim";
                claimButton.UseColumnTextForButtonValue = true;
                claimButton.Width = 50;
                dataGridView1.Columns.Add(claimButton);


                DataGridViewButtonColumn adoptButton = new DataGridViewButtonColumn();
                adoptButton.HeaderText = "Adopt";
                adoptButton.Text = "Adopt";
                adoptButton.UseColumnTextForButtonValue = true;
                adoptButton.Width = 50;
                dataGridView1.Columns.Add(adoptButton);
            } 
            


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
            fname = tbFName.Text;
            lname = tbLName.Text;
            email = tbEmail.Text;
            phone = Convert.ToInt32(tbPhone.Text);
            dob = dtpDobOwner.Value;
            address = tbAddress.Text;
            ownerID = Convert.ToInt32(tbOwnerID.Text);
            Owner newOwner = new Owner(ownerID, lname, fname, dob, address, phone, email);
            try
            {
                db.addOwner(newOwner);
                MessageBox.Show("Owner Successfully Added");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }
            Cancel_Click(sender, e);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Panel a=(Panel)((Button)sender).Parent;
            foreach (Control t in a.Controls)
            {
                if (t.GetType()==typeof(TextBox))
                {
                    t.ResetText();
                }
            }
            a.Hide();
            
        }




        private void bSubmitRFID_Click_1(object sender, EventArgs e)
        {
            
            AddAnmPanel.Show();
            tbDisplayRFID.Text = tbRFID.Text;
            Cancel_Click(sender, e);
           //todo  add new rfid / blank animal
        }

        private void btnLookForOwner_Click(object sender, EventArgs e)
        {
            try
            {
                db.getOwnerById(Convert.ToInt32(tbOwner.Text));
                tbOwner.BackColor = Color.ForestGreen;
            }
            catch
            {
                tbOwner.BackColor = Color.DarkRed;
            }
        }


        private void bCreateAnimal_Click(object sender, EventArgs e)
        {
            if (tbOwner.Text != string.Empty)
            {
                int po_id = Convert.ToInt32(tbOwner.Text);
                try{po = db.getOwnerById(po_id); }
                catch (Exception err) { MessageBox.Show("Can't find previous owner: "+err.ToString()); }
                
            }
            else
            {
                po = null;
            }
            //Console.WriteLine(po); //debug text
            if (ddSpecies.Text == "Dog")
            {
                Dog dog = new Dog(tbDisplayRFID.Text, tbDescription.Text, dtpAddAnimal.Value, tbLocationFound.Text, po);
                try
                {
                    db.addDog(dog);
                    MessageBox.Show("Animal Successfully Added");
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.ToString());
                }
                Cancel_Click(sender, e);

            }
            else if (ddSpecies.Text == "Cat")
            {
                Cat cat = new Cat(tbDisplayRFID.Text, tbDescription.Text, dtpAddAnimal.Value, tbLocationFound.Text, tbExtra.Text, po);
                db.addCat(cat);
                MessageBox.Show("Animal Successfully Addedd");
                Cancel_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Please select an animal family");
            }
        }

        private void bAdopt_Click(object sender, EventArgs e)
        {
            ownerID = Convert.ToInt32(tbOwnerIDAdopt.Text);

 try {  db.Adopt(animal, db.getOwnerById(ownerID)); } catch (Exception er) { MessageBox.Show("Could not adopt: "+er.ToString()); }

            

            //displaying in DataGrid
            Cancel_Click(sender, e);
        }


        private void bSearchOwner_Click(object sender, EventArgs e)
        {
            DataSet dt = new DataSet();
            MySqlDataAdapter SDA = new MySqlDataAdapter("SELECT ownerID, firstName, lastName FROM owner where lastName like '%" + tbSearchOwners.Text + "%'", db.getConn());
            SDA.Fill(dt);
            dataGridView2.DataSource = dt.Tables[0];
        }

        private void bDisplayAll_Click(object sender, EventArgs e)
        {
            ds = db.getAllOwners();
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void rbNotYetAdoptable_CheckedChanged(object sender, EventArgs e)
        {
            ds = db.getAnimalsByStatus("notYetAdoptable");
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.Columns[1].Width = 80;
            //dataGridView1.Columns[1].HeaderText = "Species";
            //dataGridView1.Columns[2].Width = 80;
            //dataGridView1.Columns[2].HeaderText = "Status";


            
        }

        private void rbAllAnimals_CheckedChanged(object sender, EventArgs e)
        {
            ds = db.getAllAnimals();
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.Columns[1].Width = 80;
            //dataGridView1.Columns[1].HeaderText = "Species";
            //dataGridView1.Columns[2].Width = 80;
            //dataGridView1.Columns[2].HeaderText = "Status";


            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ds = db.getAllAnimals();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearchAnimals_Click(object sender, EventArgs e)
        {
            DataSet du = new DataSet();
            MySqlDataAdapter SDA2 = new MySqlDataAdapter("SELECT rfid, 'dog' AS species, status FROM dog where rfid like '%" + tbSearchAnimals.Text + "%' UNION SELECT rfid, 'cat' AS species, status FROM cat where rfid like '%" + tbSearchAnimals.Text + "%'", db.getConn());
            SDA2.Fill(du);
            dataGridView1.DataSource = du.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb =
                        new System.Text.StringBuilder();

                    for (int i = 0;
                        i < selectedCellCount; i++)
                    {

                        //an attributes to know which part we selecting
                        string condition = dataGridView1.SelectedCells[i].Value
                            .ToString();
                        //this is an attribute for getting the value of rfid
                        string rfidselected = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        //We need to create an attribute for identifying what species is our animal
                        string species = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        //Now time for creating the Adopt and Claim function in Database

                        MessageBox.Show(rfidselected + " , " + species);
                        if (species == "cat")
                        {
                            animal = db.getCatByRFID(rfidselected);
                        }
                        else if (species == "dog")
                        {
                            animal = db.getDogByRFID(rfidselected);
                        }

                        if (condition == "Claim")
                        {
                            // if the animal is in the shelter since less than 20 days and have a PO
                            if (animal.calculateDays() < 20 && animal.getPoId() != 0) {
                                // TODO put the informations of animal in the good variables (textbox)
                                // TODO the same with owner (use animal.getPo() to retrieve the owner)
                                AnimalsPanel.Hide();
                                ClaimPanel.Show();
                            }
                            else {
                                MessageBox.Show("can't claim this animal");
                            }
                            
                        }
                        else if (condition == "Adopt")
                        {
                            if (species == "cat")
                                tbExtraAdopt.Text = animal.getExtra();

                            tbDateBroughtAdopt.Text = Convert.ToString(animal.getDateBrought());
                            tbRfidAdopt.Text = animal.getRfid();
                            tbSpeciesAdopt.Text = species;
                            tbDescriptionAdopt.Text = animal.getDescription();
                            tbLocationFoundAdopt.Text = animal.getLocationFound();


                            AnimalsPanel.Hide();
                            AdoptPanel.Show();

                            
                          
                            //This method will continue to Adopt and showing the overview of animal
                            
                        }

                    }

                   
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //todo make buttons work
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //todo change content of grid box , also for other radio buttons

            ds = db.getAnimalsByStatus("adoptable");
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.Columns[1].Width = 80;
            //dataGridView1.Columns[1].HeaderText = "Species";
            //dataGridView1.Columns[2].Width = 80;
            //dataGridView1.Columns[2].HeaderText = "Status";

            

        }


        private void bDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //todo maybe make this one method cause this is so awkward
                animal = db.getCatByRFID(textBox7.Text.ToString());
            }
            catch
            {
                animal = db.getDogByRFID(textBox7.Text.ToString());
            }

            db.DeleteAnimal(animal);
            Cancel_Click(sender, e);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cat")
            {
                animal = new Cat(textBox7.Text, textBox1.Text, dateTimePicker1.Value, textBox6.Text, textBox5.Text, db.getOwnerById(Convert.ToInt32(textBox3.Text)));
                db.addCat((Cat)animal);
            }
            else if (comboBox1.Text == "Dog")
            {
                new Dog(textBox7.Text, textBox1.Text, dateTimePicker1.Value, textBox6.Text, db.getOwnerById(Convert.ToInt32(textBox3.Text)));
                db.addDog((Dog)animal);
            }
            else
            {
                MessageBox.Show("Please select a species");
            }
            bDelete_Click(sender, e);

            Cancel_Click(sender, e);

        }


        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedCellCount = dataGridView2.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dataGridView2.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    System.Text.StringBuilder sb =
                        new System.Text.StringBuilder();

                    for (int i = 0;
                        i < selectedCellCount; i++)
                    {

                        //an attributes to know which part we selecting
                        string condition = dataGridView2.SelectedCells[i].Value
                            .ToString();
                        //this is an attribute for getting the value of rfid
                        int idselected = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                        //We need to create an attribute for identifying what species is our animal


                        if (condition == "Delete")
                        {
                            MessageBox.Show(idselected.ToString());
                            DialogResult dialogResult = MessageBox.Show("Are you sure want to Delete this owner", "Confirmation", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {

                                db.dropOwner(idselected);
                                HomePanel.Show();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                OwnersPanel.Show();

                            }

                        }
                        else if (condition == "Edit")
                        {

                            po = db.getOwnerById(idselected);


                            this.textBox9.Text = po.getAddress();
                            this.textBox14.Text = Convert.ToString(po.getOwnerId());
                            this.textBox10.Text = Convert.ToString(po.getPhoneOwner());
                            this.textBox12.Text = po.getLastName();
                            this.textBox13.Text = po.getFirstName();
                            this.dateTimePicker1.Text = Convert.ToString(po.getDob());
                            this.textBox11.Text = po.getEmail();
                            //this.tbRfidOwner.Text = animal.getRfidByOwner(po);


                            OwnersPanel.Hide();
                            OwnDetailsPanel.Show();

                        }

                        idselected = 0;

                    }


                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //todo add buttons for owner functions
        }


        private void bClaim_Click(object sender, EventArgs e)
        {
            //todo claim the animal
            if (true){ // TODO replace condition with condition to verify the checkboxes are checked (infos and money)
                db.Claim(animal);
            }
            else {
                MessageBox.Show("you have to check the informations before claiming");
            }
            Cancel_Click(sender, e);
        }

        private void bEditOwner_Click(object sender, EventArgs e)
        {
            //todo save details
           
            po.setAddress(textBox9.Text);
            po.setDob(dateTimePicker1.Value.ToString());
            po.setLastName(textBox12.Text);
            po.setFirstName(textBox13.Text);
            po.setPhoneOwner(Convert.ToInt32(textBox10.Text));
            po.setEmail(textBox11.Text);

            

            try
            {
                db.updateOwner(po);
                MessageBox.Show(po.getLastName());
                MessageBox.Show("Owner Successfully Edited");
                HomePanel.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.ToString());
            }


            



            //db.updateAnimal
            Cancel_Click(sender, e);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //todo delete owner
            Cancel_Click(sender, e);
        }

    }
}
