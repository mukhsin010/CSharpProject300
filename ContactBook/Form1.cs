using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactBook
{
	public partial class Form1 : Form
	{
		//Adding New Contact
		public Form1()
		{
			InitializeComponent();	

		}

		//Editting
		public Form1(Contact contact)
		{
			InitializeComponent();

			txtfirstname.Text = contact.FirstName;
			txtlastname.Text = contact.LastName;
			txtothername.Text = contact.OtherName;
			mtxtphonenumber.Text = contact.PhoneNumber;
			cbgroup.SelectedText = contact.Group;



		}


		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void btncancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
