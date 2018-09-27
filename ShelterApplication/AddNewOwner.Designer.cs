namespace ShelterApplication
{
    partial class AddNewOwner
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
            this.tbOwnerID = new System.Windows.Forms.TextBox();
            this.bCreateOwner = new System.Windows.Forms.Button();
            this.bCancelAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbDoB = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbOwnerID
            // 
            this.tbOwnerID.Location = new System.Drawing.Point(144, 86);
            this.tbOwnerID.Name = "tbOwnerID";
            this.tbOwnerID.Size = new System.Drawing.Size(175, 20);
            this.tbOwnerID.TabIndex = 21;
            // 
            // bCreateOwner
            // 
            this.bCreateOwner.Location = new System.Drawing.Point(323, 391);
            this.bCreateOwner.Name = "bCreateOwner";
            this.bCreateOwner.Size = new System.Drawing.Size(70, 24);
            this.bCreateOwner.TabIndex = 40;
            this.bCreateOwner.Text = "Add";
            this.bCreateOwner.UseVisualStyleBackColor = true;
            this.bCreateOwner.Click += new System.EventHandler(this.bCreateAnimal_Click);
            // 
            // bCancelAdd
            // 
            this.bCancelAdd.Location = new System.Drawing.Point(116, 391);
            this.bCancelAdd.Name = "bCancelAdd";
            this.bCancelAdd.Size = new System.Drawing.Size(70, 24);
            this.bCancelAdd.TabIndex = 39;
            this.bCancelAdd.Text = "Cancel";
            this.bCancelAdd.UseVisualStyleBackColor = true;
            this.bCancelAdd.Click += new System.EventHandler(this.bCancelAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 51);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add a new owner";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Owner ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Phone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email:";
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(144, 123);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(175, 20);
            this.tbFName.TabIndex = 33;
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(144, 156);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(175, 20);
            this.tbLName.TabIndex = 34;
            // 
            // tbDoB
            // 
            this.tbDoB.Location = new System.Drawing.Point(144, 197);
            this.tbDoB.Name = "tbDoB";
            this.tbDoB.Size = new System.Drawing.Size(175, 20);
            this.tbDoB.TabIndex = 35;
            this.tbDoB.Text = "ddmmyy";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(144, 233);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(175, 20);
            this.tbEmail.TabIndex = 36;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(144, 267);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(175, 20);
            this.tbPhone.TabIndex = 37;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(144, 301);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(175, 64);
            this.tbAddress.TabIndex = 38;
            // 
            // AddNewOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDoB);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbOwnerID);
            this.Controls.Add(this.bCreateOwner);
            this.Controls.Add(this.bCancelAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddNewOwner";
            this.Text = "AddNewOwner";
            this.Load += new System.EventHandler(this.AddNewOwner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbOwnerID;
        private System.Windows.Forms.Button bCreateOwner;
        private System.Windows.Forms.Button bCancelAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbDoB;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
    }
}