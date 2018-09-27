namespace ShelterApplication
{
    partial class AdoptAnimal
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdopt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 51);
            this.label1.TabIndex = 19;
            this.label1.Text = "Adopt Animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Animal Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Enter new owner ID: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total Fee (Euros):";
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(228, 240);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(125, 20);
            this.tbOwner.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(229, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TabStop = false;
            // 
            // cbPaid
            // 
            this.cbPaid.AutoSize = true;
            this.cbPaid.Location = new System.Drawing.Point(229, 310);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(47, 17);
            this.cbPaid.TabIndex = 25;
            this.cbPaid.Text = "Paid";
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(37, 384);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(118, 30);
            this.bCancel.TabIndex = 26;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdopt
            // 
            this.bAdopt.Location = new System.Drawing.Point(334, 384);
            this.bAdopt.Name = "bAdopt";
            this.bAdopt.Size = new System.Drawing.Size(118, 30);
            this.bAdopt.TabIndex = 27;
            this.bAdopt.Text = "Adopt";
            this.bAdopt.UseVisualStyleBackColor = true;
            this.bAdopt.Click += new System.EventHandler(this.bAdopt_Click);
            // 
            // AdoptAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.bAdopt);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbOwner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdoptAnimal";
            this.Text = "AdoptAnimal";
            this.Load += new System.EventHandler(this.AdoptAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdopt;
    }
}