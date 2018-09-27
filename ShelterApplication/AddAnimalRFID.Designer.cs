namespace ShelterApplication
{
    partial class AddAnimalRFID
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
            this.tbRFID = new System.Windows.Forms.TextBox();
            this.bSubmitRFID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label1.Location = new System.Drawing.Point(60, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a new animal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter RFID here:";
            // 
            // tbRFID
            // 
            this.tbRFID.Location = new System.Drawing.Point(159, 214);
            this.tbRFID.Name = "tbRFID";
            this.tbRFID.Size = new System.Drawing.Size(195, 20);
            this.tbRFID.TabIndex = 2;
            // 
            // bSubmitRFID
            // 
            this.bSubmitRFID.Location = new System.Drawing.Point(223, 281);
            this.bSubmitRFID.Name = "bSubmitRFID";
            this.bSubmitRFID.Size = new System.Drawing.Size(117, 28);
            this.bSubmitRFID.TabIndex = 3;
            this.bSubmitRFID.Text = "Continue";
            this.bSubmitRFID.UseVisualStyleBackColor = true;
            this.bSubmitRFID.Click += new System.EventHandler(this.submitRFID_Click);
            // 
            // AddAnimalRFID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 433);
            this.Controls.Add(this.bSubmitRFID);
            this.Controls.Add(this.tbRFID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAnimalRFID";
            this.Text = "AddAnimalRFID";
            this.Load += new System.EventHandler(this.AddAnimalRFID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbRFID;
        private System.Windows.Forms.Button bSubmitRFID;
    }
}