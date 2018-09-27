namespace ShelterApplication
{
    partial class HomeForm
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
            this.addOwner = new System.Windows.Forms.Button();
            this.addAnimal = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bViewOwners = new System.Windows.Forms.Button();
            this.tbViewAnimals = new System.Windows.Forms.Button();
            this.bExitApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addOwner
            // 
            this.addOwner.Location = new System.Drawing.Point(78, 279);
            this.addOwner.Name = "addOwner";
            this.addOwner.Size = new System.Drawing.Size(127, 24);
            this.addOwner.TabIndex = 3;
            this.addOwner.Text = "Add a New Owner";
            this.addOwner.UseVisualStyleBackColor = true;
            this.addOwner.Click += new System.EventHandler(this.addOwner_Click);
            // 
            // addAnimal
            // 
            this.addAnimal.Location = new System.Drawing.Point(250, 280);
            this.addAnimal.Name = "addAnimal";
            this.addAnimal.Size = new System.Drawing.Size(127, 24);
            this.addAnimal.TabIndex = 4;
            this.addAnimal.Text = "Add a New Animal";
            this.addAnimal.UseVisualStyleBackColor = true;
            this.addAnimal.Click += new System.EventHandler(this.addAnimal_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShelterApplication.Properties.Resources.animalimg;
            this.pictureBox2.Location = new System.Drawing.Point(264, 117);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(94, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShelterApplication.Properties.Resources.ownerimg;
            this.pictureBox1.Location = new System.Drawing.Point(96, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bViewOwners
            // 
            this.bViewOwners.Location = new System.Drawing.Point(79, 225);
            this.bViewOwners.Name = "bViewOwners";
            this.bViewOwners.Size = new System.Drawing.Size(127, 23);
            this.bViewOwners.TabIndex = 1;
            this.bViewOwners.Text = "View/Edit Owners";
            this.bViewOwners.UseVisualStyleBackColor = true;
            this.bViewOwners.Click += new System.EventHandler(this.bViewOwners_Click);
            // 
            // tbViewAnimals
            // 
            this.tbViewAnimals.Location = new System.Drawing.Point(250, 225);
            this.tbViewAnimals.Name = "tbViewAnimals";
            this.tbViewAnimals.Size = new System.Drawing.Size(127, 23);
            this.tbViewAnimals.TabIndex = 2;
            this.tbViewAnimals.Text = "View/Edit Animals";
            this.tbViewAnimals.UseVisualStyleBackColor = true;
            this.tbViewAnimals.Click += new System.EventHandler(this.tbViewAnimals_Click);
            // 
            // bExitApp
            // 
            this.bExitApp.Location = new System.Drawing.Point(174, 322);
            this.bExitApp.Name = "bExitApp";
            this.bExitApp.Size = new System.Drawing.Size(108, 28);
            this.bExitApp.TabIndex = 5;
            this.bExitApp.Text = "Exit";
            this.bExitApp.UseVisualStyleBackColor = true;
            this.bExitApp.Click += new System.EventHandler(this.bExitApp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "SHELTER APPLICATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 14);
            this.label2.TabIndex = 8;
            this.label2.Text = "Copyright made by Alex, Hafizh, Nhi and Thibbault 2018";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Alpha Version";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bExitApp);
            this.Controls.Add(this.tbViewAnimals);
            this.Controls.Add(this.bViewOwners);
            this.Controls.Add(this.addAnimal);
            this.Controls.Add(this.addOwner);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addOwner;
        private System.Windows.Forms.Button addAnimal;
        private System.Windows.Forms.Button bViewOwners;
        private System.Windows.Forms.Button tbViewAnimals;
        private System.Windows.Forms.Button bExitApp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

