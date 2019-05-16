namespace Malling_Label_Program
{
    partial class frmMain
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtDisplayOutput = new System.Windows.Forms.TextBox();
            this.btnDisplayOutput = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Address:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "City:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "State:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(384, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "ZIP:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(399, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(106, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(399, 20);
            this.txtAddress.TabIndex = 1;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(106, 100);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(151, 20);
            this.txtCity.TabIndex = 2;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(322, 99);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(56, 20);
            this.txtState.TabIndex = 3;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(430, 98);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(75, 20);
            this.txtZip.TabIndex = 4;
            // 
            // txtDisplayOutput
            // 
            this.txtDisplayOutput.BackColor = System.Drawing.SystemColors.Control;
            this.txtDisplayOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayOutput.Location = new System.Drawing.Point(25, 210);
            this.txtDisplayOutput.Multiline = true;
            this.txtDisplayOutput.Name = "txtDisplayOutput";
            this.txtDisplayOutput.ReadOnly = true;
            this.txtDisplayOutput.Size = new System.Drawing.Size(480, 135);
            this.txtDisplayOutput.TabIndex = 10;
            // 
            // btnDisplayOutput
            // 
            this.btnDisplayOutput.BackColor = System.Drawing.SystemColors.Control;
            this.btnDisplayOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayOutput.Location = new System.Drawing.Point(25, 155);
            this.btnDisplayOutput.Name = "btnDisplayOutput";
            this.btnDisplayOutput.Size = new System.Drawing.Size(75, 23);
            this.btnDisplayOutput.TabIndex = 5;
            this.btnDisplayOutput.Text = "&Display";
            this.btnDisplayOutput.UseVisualStyleBackColor = false;
            this.btnDisplayOutput.Click += new System.EventHandler(this.BtnDisplayOutput_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(430, 155);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 369);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplayOutput);
            this.Controls.Add(this.txtDisplayOutput);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Mailing Label Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtDisplayOutput;
        private System.Windows.Forms.Button btnDisplayOutput;
        private System.Windows.Forms.Button btnExit;
    }
}

