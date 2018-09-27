namespace ShelterApplication
{
    partial class ShowAnimals
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
            this.tbSearchAnimals = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAdoptable = new System.Windows.Forms.CheckBox();
            this.tbNotYetAdoptable = new System.Windows.Forms.CheckBox();
            this.bHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSearchAnimals
            // 
            this.tbSearchAnimals.Location = new System.Drawing.Point(173, 49);
            this.tbSearchAnimals.Name = "tbSearchAnimals";
            this.tbSearchAnimals.Size = new System.Drawing.Size(150, 20);
            this.tbSearchAnimals.TabIndex = 0;
            this.tbSearchAnimals.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Animals by RFID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(255, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Animals";
            // 
            // cbAdoptable
            // 
            this.cbAdoptable.AutoSize = true;
            this.cbAdoptable.Location = new System.Drawing.Point(406, 50);
            this.cbAdoptable.Name = "cbAdoptable";
            this.cbAdoptable.Size = new System.Drawing.Size(74, 17);
            this.cbAdoptable.TabIndex = 3;
            this.cbAdoptable.Text = "Adoptable";
            this.cbAdoptable.UseVisualStyleBackColor = true;
            // 
            // tbNotYetAdoptable
            // 
            this.tbNotYetAdoptable.AutoSize = true;
            this.tbNotYetAdoptable.Location = new System.Drawing.Point(500, 49);
            this.tbNotYetAdoptable.Name = "tbNotYetAdoptable";
            this.tbNotYetAdoptable.Size = new System.Drawing.Size(113, 17);
            this.tbNotYetAdoptable.TabIndex = 4;
            this.tbNotYetAdoptable.Text = "Not Yet Adoptable";
            this.tbNotYetAdoptable.UseVisualStyleBackColor = true;
            // 
            // bHome
            // 
            this.bHome.Location = new System.Drawing.Point(27, 469);
            this.bHome.Name = "bHome";
            this.bHome.Size = new System.Drawing.Size(111, 30);
            this.bHome.TabIndex = 5;
            this.bHome.Text = "Home";
            this.bHome.UseVisualStyleBackColor = true;
            this.bHome.Click += new System.EventHandler(this.bHome_Click);
            // 
            // ShowAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 511);
            this.Controls.Add(this.bHome);
            this.Controls.Add(this.tbNotYetAdoptable);
            this.Controls.Add(this.cbAdoptable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearchAnimals);
            this.Name = "ShowAnimals";
            this.Text = "ShowAnimals";
            this.Load += new System.EventHandler(this.ShowAnimals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearchAnimals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAdoptable;
        private System.Windows.Forms.CheckBox tbNotYetAdoptable;
        private System.Windows.Forms.Button bHome;
    }
}