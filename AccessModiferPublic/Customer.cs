﻿using System;

namespace AccessModiferPublic
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public void Promote()
		{
			var rating = CalculateRating(true);
			if(rating == 0)
			{
				Console.WriteLine("Promoted to Level 1");
			}
			else
			{
				Console.WriteLine("Promoted to Level 2");
			}
		}

		public int CalculateRating(bool rating)
		{
			return 0;
		}
	}
}