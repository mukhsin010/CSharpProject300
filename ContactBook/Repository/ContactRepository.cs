using ContactBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook.Repository
{
	public class ContactRepository
	{
		public List<Contact> Contacts { get; private set; }
		public ContactRepository()
		{
			Contacts = new List<Contact>();
			for(int i = 0; i<100; i++)
			{
				var c = new Contact();
				c.FirstName = "first name" + i;
				c.LastName = "last name" + i;
				c.OtherName = "other name" + i;
				c.PhoneNumber = "phone number" + i;
				c.Group = "group " + i;

				Contacts.Add(c);

			}
		}
		public void AddContact(Contact contact)
		{

			if (contact.FirstName.Trim() == "" || contact.ContactId == 0)
			{ 
				Console.WriteLine("Enter your First Name and Contact ID");
				return;
			}
			
			
				Contacts.Add(contact);
			
			
			
		}

		public void EditContact()
		{

		}

		public void DeleteContact(Contact contact)
		{
			Contacts.Remove(contact);
		}

		public List<Contact> GetContacts()
		{
			return Contacts;
		}
	}
}
