using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
	public class Person
	{
		private DateTime _birthDate;
		
		public void SetBirth(DateTime birthdate)
		{
			_birthDate = birthdate;
		}

		public DateTime GetBirthDate()
		{
			return _birthDate;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			var person = new Person();
			person.SetBirth(new DateTime(1998, 10, 29));
			Console.WriteLine(person.GetBirthDate().ToString()); 
		}
	}
}
