namespace ShelterApplication
{
    partial class ShowOwners
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchAnimals = new System.Windows.Forms.TextBox();
            this.bHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(253, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "All Owners";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Owner by Last Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSearchAnimals
            // 
            this.tbSearchAnimals.Location = new System.Drawing.Point(192, 61);
            this.tbSearchAnimals.Name = "tbSearchAnimals";
            this.tbSearchAnimals.Size = new System.Drawing.Size(150, 20);
            this.tbSearchAnimals.TabIndex = 5;
            this.tbSearchAnimals.TextChanged += new System.EventHandler(this.tbSearchAnimals_TextChanged);
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(28, 468);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(111, 30);
            this.bHome.TabIndex = 8;
            this.bHome.Text = "Home";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // ShowOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 520);
            this.Controls.Add(this.bHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchAnimals);
            this.Name = "ShowOwners";
            this.Text = "All Owners";
            this.Load += new System.EventHandler(this.ShowOwners_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchAnimals;
        private System.Windows.Forms.Button bHome;
    }
}