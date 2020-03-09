using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Animal
	{
		public Animal()
		{
			noOfLegs = 2;

			
		}

		public Animal(int noofLegs)
		{
			noOfLegs = noofLegs;
		}

		public int noOfLegs { get; set; }
	}
}
