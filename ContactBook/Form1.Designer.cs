namespace ContactBook
{
	partial class Form1
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
			this.lblfirstname = new System.Windows.Forms.Label();
			this.txtfirstname = new System.Windows.Forms.TextBox();
			this.lbllastname = new System.Windows.Forms.Label();
			this.lblothername = new System.Windows.Forms.Label();
			this.txtlastname = new System.Windows.Forms.TextBox();
			this.txtothername = new System.Windows.Forms.TextBox();
			this.lblphonenumber = new System.Windows.Forms.Label();
			this.mtxtphonenumber = new System.Windows.Forms.MaskedTextBox();
			this.cbgroup = new System.Windows.Forms.ComboBox();
			this.cmbgroup = new System.Windows.Forms.Label();
			this.btncancel = new System.Windows.Forms.Button();
			this.btnsave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblfirstname
			// 
			this.lblfirstname.AutoSize = true;
			this.lblfirstname.Location = new System.Drawing.Point(33, 24);
			this.lblfirstname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblfirstname.Name = "lblfirstname";
			this.lblfirstname.Size = new System.Drawing.Size(106, 25);
			this.lblfirstname.TabIndex = 0;
			this.lblfirstname.Text = "First Name";
			this.lblfirstname.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtfirstname
			// 
			this.txtfirstname.Location = new System.Drawing.Point(184, 24);
			this.txtfirstname.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.txtfirstname.Name = "txtfirstname";
			this.txtfirstname.Size = new System.Drawing.Size(196, 30);
			this.txtfirstname.TabIndex = 1;
			// 
			// lbllastname
			// 
			this.lbllastname.AutoSize = true;
			this.lbllastname.Location = new System.Drawing.Point(33, 85);
			this.lbllastname.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lbllastname.Name = "lbllastname";
			this.lbllastname.Size = new System.Drawing.Size(106, 25);
			this.lbllastname.TabIndex = 0;
			this.lbllastname.Text = "Last Name";
			// 
			// lblothername
			// 
			this.lblothername.AutoSize = true;
			this.lblothername.Location = new System.Drawing.Point(33, 126);
			this.lblothername.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblothername.Name = "lblothername";
			this.lblothername.Size = new System.Drawing.Size(118, 25);
			this.lblothername.TabIndex = 0;
			this.lblothername.Text = "Other Name";
			// 
			// txtlastname
			// 
			this.txtlastname.Location = new System.Drawing.Point(184, 66);
			this.txtlastname.Margin = new System.Windows.Forms.Padding(6);
			this.txtlastname.Name = "txtlastname";
			this.txtlastname.Size = new System.Drawing.Size(196, 30);
			this.txtlastname.TabIndex = 1;
			// 
			// txtothername
			// 
			this.txtothername.Location = new System.Drawing.Point(184, 123);
			this.txtothername.Margin = new System.Windows.Forms.Padding(6);
			this.txtothername.Name = "txtothername";
			this.txtothername.Size = new System.Drawing.Size(196, 30);
			this.txtothername.TabIndex = 1;
			// 
			// lblphonenumber
			// 
			this.lblphonenumber.AutoSize = true;
			this.lblphonenumber.Location = new System.Drawing.Point(33, 173);
			this.lblphonenumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblphonenumber.Name = "lblphonenumber";
			this.lblphonenumber.Size = new System.Drawing.Size(143, 25);
			this.lblphonenumber.TabIndex = 0;
			this.lblphonenumber.Text = "Phone Number";
			this.lblphonenumber.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// mtxtphonenumber
			// 
			this.mtxtphonenumber.Location = new System.Drawing.Point(184, 177);
			this.mtxtphonenumber.Mask = "(999) 000-0000";
			this.mtxtphonenumber.Name = "mtxtphonenumber";
			this.mtxtphonenumber.Size = new System.Drawing.Size(196, 30);
			this.mtxtphonenumber.TabIndex = 2;
			// 
			// cbgroup
			// 
			this.cbgroup.FormattingEnabled = true;
			this.cbgroup.Items.AddRange(new object[] {
            "Family",
            "Friends",
            "Classmates"});
			this.cbgroup.Location = new System.Drawing.Point(184, 224);
			this.cbgroup.Name = "cbgroup";
			this.cbgroup.Size = new System.Drawing.Size(196, 33);
			this.cbgroup.TabIndex = 3;
			// 
			// cmbgroup
			// 
			this.cmbgroup.AutoSize = true;
			this.cmbgroup.Location = new System.Drawing.Point(33, 224);
			this.cmbgroup.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.cmbgroup.Name = "cmbgroup";
			this.cmbgroup.Size = new System.Drawing.Size(66, 25);
			this.cmbgroup.TabIndex = 0;
			this.cmbgroup.Text = "Group";
			this.cmbgroup.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// btncancel
			// 
			this.btncancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btncancel.Location = new System.Drawing.Point(256, 307);
			this.btncancel.Name = "btncancel";
			this.btncancel.Size = new System.Drawing.Size(170, 68);
			this.btncancel.TabIndex = 4;
			this.btncancel.Text = "Cancel";
			this.btncancel.UseVisualStyleBackColor = false;
			this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
			// 
			// btnsave
			// 
			this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnsave.Location = new System.Drawing.Point(29, 307);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(170, 68);
			this.btnsave.TabIndex = 4;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = false;
			this.btnsave.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 426);
			this.Controls.Add(this.btnsave);
			this.Controls.Add(this.btncancel);
			this.Controls.Add(this.cbgroup);
			this.Controls.Add(this.mtxtphonenumber);
			this.Controls.Add(this.txtothername);
			this.Controls.Add(this.txtlastname);
			this.Controls.Add(this.txtfirstname);
			this.Controls.Add(this.cmbgroup);
			this.Controls.Add(this.lblphonenumber);
			this.Controls.Add(this.lblothername);
			this.Controls.Add(this.lbllastname);
			this.Controls.Add(this.lblfirstname);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblfirstname;
		private System.Windows.Forms.TextBox txtfirstname;
		private System.Windows.Forms.Label lbllastname;
		private System.Windows.Forms.Label lblothername;
		private System.Windows.Forms.TextBox txtlastname;
		private System.Windows.Forms.TextBox txtothername;
		private System.Windows.Forms.Label lblphonenumber;
		private System.Windows.Forms.MaskedTextBox mtxtphonenumber;
		private System.Windows.Forms.ComboBox cbgroup;
		private System.Windows.Forms.Label cmbgroup;
		private System.Windows.Forms.Button btncancel;
		private System.Windows.Forms.Button btnsave;
	}
}

