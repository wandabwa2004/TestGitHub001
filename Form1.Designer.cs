namespace TestGitHub001
{
    partial class TestProject001
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
            this.Name = new System.Windows.Forms.Label();
            this.ID_Number = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtdob = new System.Windows.Forms.TextBox();
            this.txtidnumber = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(83, 64);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(51, 20);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // ID_Number
            // 
            this.ID_Number.AutoSize = true;
            this.ID_Number.Location = new System.Drawing.Point(83, 120);
            this.ID_Number.Name = "ID_Number";
            this.ID_Number.Size = new System.Drawing.Size(86, 20);
            this.ID_Number.TabIndex = 1;
            this.ID_Number.Text = "ID Number";
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(83, 176);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(103, 20);
            this.DOB.TabIndex = 2;
            this.DOB.Text = "Date of  Birth";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(273, 57);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(322, 26);
            this.txtname.TabIndex = 3;
            // 
            // txtdob
            // 
            this.txtdob.Location = new System.Drawing.Point(273, 176);
            this.txtdob.Name = "txtdob";
            this.txtdob.Size = new System.Drawing.Size(322, 26);
            this.txtdob.TabIndex = 4;
            // 
            // txtidnumber
            // 
            this.txtidnumber.Location = new System.Drawing.Point(273, 120);
            this.txtidnumber.Name = "txtidnumber";
            this.txtidnumber.Size = new System.Drawing.Size(322, 26);
            this.txtidnumber.TabIndex = 5;
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(294, 267);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(266, 103);
            this.btnsubmit.TabIndex = 6;
            this.btnsubmit.Text = "Click Here!";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // TestProject001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtidnumber);
            this.Controls.Add(this.txtdob);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.ID_Number);
            this.Controls.Add(this.Name);
           // this.Name = "TestProject001";
            this.Text = "TestProject001";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label ID_Number;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtdob;
        private System.Windows.Forms.TextBox txtidnumber;
        private System.Windows.Forms.Button btnsubmit;
    }
}

