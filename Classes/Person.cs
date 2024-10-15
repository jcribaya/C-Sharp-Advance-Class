using System;

namespace Classes
{
	public class Person
	{
		public string Name;
		public void Introduce()
		{
			Console.WriteLine($"Hi, {Name}");
		}

		public static Person Parse(string str)
		{
			Person person = new Person();
			person.Name = str;

			return person;
		}
	}
}
