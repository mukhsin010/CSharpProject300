using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var repo = new ContactRepository();
			Console.WriteLine(repo.Contacts.Count);
			var contact1 = new Contact();
			contact1.FirstName = "John";
			contact1.LastName = "Doe";
			contact1.OtherName = "";
			contact1.Group = "Family";
			repo.AddContact(contact1);
			Console.WriteLine(repo.Contacts.Count);
			repo.DeleteContact(contact1);//Remove Object
			Console.WriteLine(repo.Contacts.Count);

			Console.ReadKey();

		}
	}
}
