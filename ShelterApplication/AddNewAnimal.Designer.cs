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
            this.bAssignOwner = new System.Windows.Forms.Button();
            this.tbLocationFound = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(117, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a new animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Species:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "RFID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Location Found:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Date Found:";
            // 
            // bCancelAdd
            // 
            this.bCancelAdd.Location = new System.Drawing.Point(152, 374);
            this.bCancelAdd.Name = "bCancelAdd";
            this.bCancelAdd.Size = new System.Drawing.Size(70, 24);
            this.bCancelAdd.TabIndex = 14;
            this.bCancelAdd.Text = "Cancel";
            this.bCancelAdd.UseVisualStyleBackColor = true;
            this.bCancelAdd.Click += new System.EventHandler(this.bCancelAdd_Click);
            // 
            // bCreateAnimal
            // 
            this.bCreateAnimal.Location = new System.Drawing.Point(359, 374);
            this.bCreateAnimal.Name = "bCreateAnimal";
            this.bCreateAnimal.Size = new System.Drawing.Size(70, 24);
            this.bCreateAnimal.TabIndex = 15;
            this.bCreateAnimal.Text = "Add";
            this.bCreateAnimal.UseVisualStyleBackColor = true;
            this.bCreateAnimal.Click += new System.EventHandler(this.bCreateAnimal_Click);
            // 
            // tbDisplayRFID
            // 
            this.tbDisplayRFID.Location = new System.Drawing.Point(180, 69);
            this.tbDisplayRFID.Name = "tbDisplayRFID";
            this.tbDisplayRFID.ReadOnly = true;
            this.tbDisplayRFID.Size = new System.Drawing.Size(175, 20);
            this.tbDisplayRFID.TabIndex = 9;
            // 
            // ddSpecies
            // 
            this.ddSpecies.FormattingEnabled = true;
            this.ddSpecies.Location = new System.Drawing.Point(180, 114);
            this.ddSpecies.Name = "ddSpecies";
            this.ddSpecies.Size = new System.Drawing.Size(175, 21);
            this.ddSpecies.TabIndex = 10;
            // 
            // tbDateFound
            // 
            this.tbDateFound.Location = new System.Drawing.Point(180, 152);
            this.tbDateFound.Name = "tbDateFound";
            this.tbDateFound.Size = new System.Drawing.Size(175, 20);
            this.tbDateFound.TabIndex = 11;
            this.tbDateFound.Text = "ddmmyyyy";
            // 
            // bAssignOwner
            // 
            this.bAssignOwner.Location = new System.Drawing.Point(81, 324);
            this.bAssignOwner.Name = "bAssignOwner";
            this.bAssignOwner.Size = new System.Drawing.Size(91, 29);
            this.bAssignOwner.TabIndex = 13;
            this.bAssignOwner.Text = "Assign Owner";
            this.bAssignOwner.UseVisualStyleBackColor = true;
            // 
            // tbLocationFound
            // 
            this.tbLocationFound.Location = new System.Drawing.Point(180, 194);
            this.tbLocationFound.Multiline = true;
            this.tbLocationFound.Name = "tbLocationFound";
            this.tbLocationFound.Size = new System.Drawing.Size(175, 104);
            this.tbLocationFound.TabIndex = 12;
            // 
            // AddNewAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 487);
            this.Controls.Add(this.tbLocationFound);
            this.Controls.Add(this.bAssignOwner);
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
        private System.Windows.Forms.Button bAssignOwner;
        private System.Windows.Forms.TextBox tbLocationFound;
    }
}