namespace ShelterApplication
{
    partial class EditAnimals
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
            this.tbLocationFound = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bCancelAdd = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.tbDisplayRFID = new System.Windows.Forms.TextBox();
            this.ddSpecies = new System.Windows.Forms.ComboBox();
            this.tbDateFound = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDateWalked = new System.Windows.Forms.TextBox();
            this.tbExtra = new System.Windows.Forms.TextBox();
            this.bDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 51);
            this.label1.TabIndex = 18;
            this.label1.Text = "View/Edit Animal";
            // 
            // tbLocationFound
            // 
            this.tbLocationFound.Location = new System.Drawing.Point(127, 240);
            this.tbLocationFound.Multiline = true;
            this.tbLocationFound.Name = "tbLocationFound";
            this.tbLocationFound.Size = new System.Drawing.Size(175, 104);
            this.tbLocationFound.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Species:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "RFID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Location Found:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date Found:";
            // 
            // bCancelAdd
            // 
            this.bCancelAdd.Location = new System.Drawing.Point(124, 407);
            this.bCancelAdd.Name = "bCancelAdd";
            this.bCancelAdd.Size = new System.Drawing.Size(70, 24);
            this.bCancelAdd.TabIndex = 31;
            this.bCancelAdd.Text = "Cancel";
            this.bCancelAdd.UseVisualStyleBackColor = true;
            this.bCancelAdd.Click += new System.EventHandler(this.bCancelAdd_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(331, 407);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(70, 24);
            this.bSave.TabIndex = 32;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // tbDisplayRFID
            // 
            this.tbDisplayRFID.Location = new System.Drawing.Point(127, 75);
            this.tbDisplayRFID.Name = "tbDisplayRFID";
            this.tbDisplayRFID.ReadOnly = true;
            this.tbDisplayRFID.Size = new System.Drawing.Size(175, 20);
            this.tbDisplayRFID.TabIndex = 24;
            this.tbDisplayRFID.TabStop = false;
            // 
            // ddSpecies
            // 
            this.ddSpecies.FormattingEnabled = true;
            this.ddSpecies.Location = new System.Drawing.Point(127, 120);
            this.ddSpecies.Name = "ddSpecies";
            this.ddSpecies.Size = new System.Drawing.Size(175, 21);
            this.ddSpecies.TabIndex = 25;
            // 
            // tbDateFound
            // 
            this.tbDateFound.Location = new System.Drawing.Point(127, 158);
            this.tbDateFound.Name = "tbDateFound";
            this.tbDateFound.Size = new System.Drawing.Size(175, 20);
            this.tbDateFound.TabIndex = 26;
            this.tbDateFound.Text = "ddmmyyyy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Date Last Walked:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Extra Description (for cats):";
            // 
            // tbDateWalked
            // 
            this.tbDateWalked.Location = new System.Drawing.Point(428, 97);
            this.tbDateWalked.Name = "tbDateWalked";
            this.tbDateWalked.Size = new System.Drawing.Size(134, 20);
            this.tbDateWalked.TabIndex = 29;
            this.tbDateWalked.Text = "ddmmyy";
            // 
            // tbExtra
            // 
            this.tbExtra.Location = new System.Drawing.Point(331, 148);
            this.tbExtra.Multiline = true;
            this.tbExtra.Name = "tbExtra";
            this.tbExtra.Size = new System.Drawing.Size(231, 123);
            this.tbExtra.TabIndex = 30;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(407, 407);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(70, 24);
            this.bDelete.TabIndex = 33;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Adoptable?";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Assign Owner:";
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(127, 357);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(134, 20);
            this.tbOwner.TabIndex = 28;
            this.tbOwner.Text = "Owner ID";
            // 
            // EditAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.tbOwner);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.tbExtra);
            this.Controls.Add(this.tbDateWalked);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLocationFound);
            this.Controls.Add(this.tbDateFound);
            this.Controls.Add(this.ddSpecies);
            this.Controls.Add(this.tbDisplayRFID);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bCancelAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAnimals";
            this.Text = "EditAnimals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLocationFound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bCancelAdd;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tbDisplayRFID;
        private System.Windows.Forms.ComboBox ddSpecies;
        private System.Windows.Forms.TextBox tbDateFound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDateWalked;
        private System.Windows.Forms.TextBox tbExtra;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbOwner;
    }
}