namespace ShelterApplication
{
    partial class AddNewAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bCancelAdd = new System.Windows.Forms.Button();
            this.bCreateAnimal = new System.Windows.Forms.Button();
            this.tbDisplayRFID = new System.Windows.Forms.TextBox();
            this.ddSpecies = new System.Windows.Forms.ComboBox();
            this.tbDateFound = new System.Windows.Forms.TextBox();
            this.tbLocationFound = new System.Windows.Forms.TextBox();
            this.tbExtra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TestConnection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a new animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Species:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RFID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location Found:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date Found:";
            // 
            // bCancelAdd
            // 
            this.bCancelAdd.Location = new System.Drawing.Point(52, 405);
            this.bCancelAdd.Name = "bCancelAdd";
            this.bCancelAdd.Size = new System.Drawing.Size(70, 24);
            this.bCancelAdd.TabIndex = 15;
            this.bCancelAdd.Text = "Cancel";
            this.bCancelAdd.UseVisualStyleBackColor = true;
            this.bCancelAdd.Click += new System.EventHandler(this.bCancelAdd_Click);
            // 
            // bCreateAnimal
            // 
            this.bCreateAnimal.Location = new System.Drawing.Point(352, 405);
            this.bCreateAnimal.Name = "bCreateAnimal";
            this.bCreateAnimal.Size = new System.Drawing.Size(70, 24);
            this.bCreateAnimal.TabIndex = 16;
            this.bCreateAnimal.Text = "Add";
            this.bCreateAnimal.UseVisualStyleBackColor = true;
            this.bCreateAnimal.Click += new System.EventHandler(this.bCreateAnimal_Click);
            // 
            // tbDisplayRFID
            // 
            this.tbDisplayRFID.Location = new System.Drawing.Point(114, 69);
            this.tbDisplayRFID.Name = "tbDisplayRFID";
            this.tbDisplayRFID.ReadOnly = true;
            this.tbDisplayRFID.Size = new System.Drawing.Size(256, 20);
            this.tbDisplayRFID.TabIndex = 9;
            this.tbDisplayRFID.TabStop = false;
            // 
            // ddSpecies
            // 
            this.ddSpecies.FormattingEnabled = true;
            this.ddSpecies.Location = new System.Drawing.Point(114, 95);
            this.ddSpecies.Name = "ddSpecies";
            this.ddSpecies.Size = new System.Drawing.Size(256, 21);
            this.ddSpecies.TabIndex = 10;
            // 
            // tbDateFound
            // 
            this.tbDateFound.Location = new System.Drawing.Point(114, 122);
            this.tbDateFound.Name = "tbDateFound";
            this.tbDateFound.Size = new System.Drawing.Size(256, 20);
            this.tbDateFound.TabIndex = 11;
            this.tbDateFound.Text = "ddmmyyyy";
            // 
            // tbLocationFound
            // 
            this.tbLocationFound.Location = new System.Drawing.Point(114, 156);
            this.tbLocationFound.Multiline = true;
            this.tbLocationFound.Name = "tbLocationFound";
            this.tbLocationFound.Size = new System.Drawing.Size(256, 104);
            this.tbLocationFound.TabIndex = 12;
            // 
            // tbExtra
            // 
            this.tbExtra.Location = new System.Drawing.Point(164, 329);
            this.tbExtra.Multiline = true;
            this.tbExtra.Name = "tbExtra";
            this.tbExtra.Size = new System.Drawing.Size(206, 50);
            this.tbExtra.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Extra Description (for cats):";
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(114, 276);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(256, 20);
            this.tbOwner.TabIndex = 13;
            this.tbOwner.Text = "Owner ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Assign Owner:";
            // 
            // TestConnection
            // 
            this.TestConnection.Location = new System.Drawing.Point(247, 406);
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.Size = new System.Drawing.Size(75, 23);
            this.TestConnection.TabIndex = 39;
            this.TestConnection.Text = "testConnection";
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.TestConnection_Click);
            // 
            // AddNewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.TestConnection);
            this.Controls.Add(this.tbOwner);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbExtra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbLocationFound);
            this.Controls.Add(this.tbDateFound);
            this.Controls.Add(this.ddSpecies);
            this.Controls.Add(this.tbDisplayRFID);
            this.Controls.Add(this.bCreateAnimal);
            this.Controls.Add(this.bCancelAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewAnimal";
            this.Text = "AddNewAnimal";
            this.Load += new System.EventHandler(this.AddNewAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bCancelAdd;
        private System.Windows.Forms.Button bCreateAnimal;
        private System.Windows.Forms.TextBox tbDisplayRFID;
        private System.Windows.Forms.ComboBox ddSpecies;
        private System.Windows.Forms.TextBox tbDateFound;
        private System.Windows.Forms.TextBox tbLocationFound;
        private System.Windows.Forms.TextBox tbExtra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button TestConnection;
    }
}