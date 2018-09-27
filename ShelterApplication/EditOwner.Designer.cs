namespace ShelterApplication
{
    partial class EditOwner
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbDoB = new System.Windows.Forms.TextBox();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOwnerID = new System.Windows.Forms.TextBox();
            this.bEditOwner = new System.Windows.Forms.Button();
            this.bCancelAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(82, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 51);
            this.label1.TabIndex = 17;
            this.label1.Text = "View/Edit Owner";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(157, 276);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(215, 64);
            this.tbAddress.TabIndex = 54;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(157, 242);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(215, 20);
            this.tbPhone.TabIndex = 53;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(157, 208);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(215, 20);
            this.tbEmail.TabIndex = 52;
            // 
            // tbDoB
            // 
            this.tbDoB.Location = new System.Drawing.Point(157, 172);
            this.tbDoB.Name = "tbDoB";
            this.tbDoB.Size = new System.Drawing.Size(215, 20);
            this.tbDoB.TabIndex = 51;
            this.tbDoB.Text = "ddmmyy";
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(157, 131);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(215, 20);
            this.tbLName.TabIndex = 50;
            // 
            // tbFName
            // 
            this.tbFName.Location = new System.Drawing.Point(157, 98);
            this.tbFName.Name = "tbFName";
            this.tbFName.Size = new System.Drawing.Size(215, 20);
            this.tbFName.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Owner ID:";
            // 
            // tbOwnerID
            // 
            this.tbOwnerID.Location = new System.Drawing.Point(157, 61);
            this.tbOwnerID.Name = "tbOwnerID";
            this.tbOwnerID.Size = new System.Drawing.Size(215, 20);
            this.tbOwnerID.TabIndex = 44;
            // 
            // bEditOwner
            // 
            this.bEditOwner.Location = new System.Drawing.Point(302, 415);
            this.bEditOwner.Name = "bEditOwner";
            this.bEditOwner.Size = new System.Drawing.Size(70, 24);
            this.bEditOwner.TabIndex = 56;
            this.bEditOwner.Text = "Save";
            this.bEditOwner.UseVisualStyleBackColor = true;
            this.bEditOwner.Click += new System.EventHandler(this.bEditOwner_Click);
            // 
            // bCancelAdd
            // 
            this.bCancelAdd.Location = new System.Drawing.Point(70, 415);
            this.bCancelAdd.Name = "bCancelAdd";
            this.bCancelAdd.Size = new System.Drawing.Size(70, 24);
            this.bCancelAdd.TabIndex = 55;
            this.bCancelAdd.Text = "Cancel";
            this.bCancelAdd.UseVisualStyleBackColor = true;
            this.bCancelAdd.Click += new System.EventHandler(this.bCancelAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "First Name:";
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(382, 415);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(70, 24);
            this.bDelete.TabIndex = 57;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // EditOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.bDelete);
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
            this.Controls.Add(this.bEditOwner);
            this.Controls.Add(this.bCancelAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditOwner";
            this.Text = "EditOwner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbDoB;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOwnerID;
        private System.Windows.Forms.Button bEditOwner;
        private System.Windows.Forms.Button bCancelAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bDelete;
    }
}