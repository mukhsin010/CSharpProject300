using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Models;
namespace ConsoleApp1.Repository
{
	public class ContactRepository
	{
		public List<Contact> Contacts { get; private set; }
		public ContactRepository()
		{
			Contacts = new List<Contact>();
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
