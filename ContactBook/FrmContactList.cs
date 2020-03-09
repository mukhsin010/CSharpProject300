using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactBook.Models;
using ContactBook.Repository;

namespace ContactBook
{
	public partial class FrmContactList : Form
	{
		public FrmContactList()
		{
			InitializeComponent();
			var repo = new ContactRepository();
			dgvContactList.DataSource = repo.GetContacts();

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Form1 add = new Form1();
			add.ShowDialog();
		}

		private void dgvContactList_RowEnter(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnedit_Click(object sender, EventArgs e)
		{
			var selectedRowCells =
				dgvContactList.SelectedRows[0].Cells;

			var contactId = selectedRowCells[0].Value;
			var firstName = selectedRowCells[1].Value.ToString();
			var lastName = selectedRowCells[2].Value.ToString(); ;
			var otherName = selectedRowCells[3].Value.ToString(); ;
			var phoneNumber = selectedRowCells[4].Value.ToString(); ;
			var group = selectedRowCells[5].Value;

			var contact = new Contact();
			contact.FirstName = firstName;
			contact.LastName = lastName;
			contact.OtherName = otherName;
			contact.PhoneNumber = phoneNumber;
			contact.Group =  group.ToString();
			Form1 edit = new Form1(contact);
			edit.ShowDialog();
		}
	}
}
