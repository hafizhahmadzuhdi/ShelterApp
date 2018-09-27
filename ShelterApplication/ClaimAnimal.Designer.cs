namespace ShelterApplication
{
    partial class ClaimAnimal
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
            this.bClaim = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbConfirmInfo = new System.Windows.Forms.CheckBox();
            this.tbTotalDays = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bClaim
            // 
            this.bClaim.Location = new System.Drawing.Point(317, 398);
            this.bClaim.Name = "bClaim";
            this.bClaim.Size = new System.Drawing.Size(118, 30);
            this.bClaim.TabIndex = 36;
            this.bClaim.Text = "Claim";
            this.bClaim.UseVisualStyleBackColor = true;
            this.bClaim.Click += new System.EventHandler(this.bClaim_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(47, 399);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(118, 30);
            this.bCancel.TabIndex = 35;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Location = new System.Drawing.Point(223, 337);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(47, 17);
            this.cbPaid.TabIndex = 34;
            this.cbPaid.Text = "Paid";
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // tbFee
            // 
            this.tbFee.Location = new System.Drawing.Point(317, 302);
            this.tbFee.Name = "tbFee";
            this.tbFee.ReadOnly = true;
            this.tbFee.Size = new System.Drawing.Size(125, 20);
            this.tbFee.TabIndex = 33;
            this.tbFee.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Total Fee (Euros):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Animal Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(104, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 51);
            this.label1.TabIndex = 28;
            this.label1.Text = "Claim Animal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Owner Details:";
            // 
            // cbConfirmInfo
            // 
            this.cbConfirmInfo.AutoSize = true;
            this.cbConfirmInfo.Location = new System.Drawing.Point(165, 241);
            this.cbConfirmInfo.Name = "cbConfirmInfo";
            this.cbConfirmInfo.Size = new System.Drawing.Size(157, 17);
            this.cbConfirmInfo.TabIndex = 32;
            this.cbConfirmInfo.Text = "Above information is correct";
            this.cbConfirmInfo.UseVisualStyleBackColor = true;
            this.cbConfirmInfo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbTotalDays
            // 
            this.tbTotalDays.Location = new System.Drawing.Point(74, 302);
            this.tbTotalDays.Name = "tbTotalDays";
            this.tbTotalDays.ReadOnly = true;
            this.tbTotalDays.Size = new System.Drawing.Size(125, 20);
            this.tbTotalDays.TabIndex = 39;
            this.tbTotalDays.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Total Days:";
            // 
            // ClaimAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.tbTotalDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbConfirmInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bClaim);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.tbFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ClaimAnimal";
            this.Text = "ClaimAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClaim;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.TextBox tbFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbConfirmInfo;
        private System.Windows.Forms.TextBox tbTotalDays;
        private System.Windows.Forms.Label label3;
    }
}