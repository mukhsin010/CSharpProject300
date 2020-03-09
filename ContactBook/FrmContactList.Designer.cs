namespace ContactBook
{
	partial class FrmContactList
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
			this.dgvContactList = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnedit = new System.Windows.Forms.Button();
			this.btndelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvContactList
			// 
			this.dgvContactList.AllowUserToAddRows = false;
			this.dgvContactList.AllowUserToDeleteRows = false;
			this.dgvContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContactList.Dock = System.Windows.Forms.DockStyle.Left;
			this.dgvContactList.Location = new System.Drawing.Point(0, 0);
			this.dgvContactList.Margin = new System.Windows.Forms.Padding(4);
			this.dgvContactList.Name = "dgvContactList";
			this.dgvContactList.ReadOnly = true;
			this.dgvContactList.RowHeadersWidth = 51;
			this.dgvContactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContactList.Size = new System.Drawing.Size(881, 554);
			this.dgvContactList.TabIndex = 0;
			this.dgvContactList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactList_RowEnter);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnAdd.Location = new System.Drawing.Point(904, 85);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(147, 70);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnedit
			// 
			this.btnedit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnedit.Location = new System.Drawing.Point(904, 249);
			this.btnedit.Margin = new System.Windows.Forms.Padding(4);
			this.btnedit.Name = "btnedit";
			this.btnedit.Size = new System.Drawing.Size(147, 70);
			this.btnedit.TabIndex = 1;
			this.btnedit.Text = "Edit";
			this.btnedit.UseVisualStyleBackColor = false;
			this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
			// 
			// btndelete
			// 
			this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btndelete.Location = new System.Drawing.Point(904, 414);
			this.btndelete.Margin = new System.Windows.Forms.Padding(4);
			this.btndelete.Name = "btndelete";
			this.btndelete.Size = new System.Drawing.Size(147, 70);
			this.btndelete.TabIndex = 1;
			this.btndelete.Text = "Delete";
			this.btndelete.UseVisualStyleBackColor = false;
			// 
			// FrmContactList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.btndelete);
			this.Controls.Add(this.btnedit);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dgvContactList);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmContactList";
			this.Text = "FrmContactList";
			((System.ComponentModel.ISupportInitialize)(this.dgvContactList)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvContactList;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnedit;
		private System.Windows.Forms.Button btndelete;
	}
}