﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModiferPublic
{
	public class Program
	{
		static void Main(string[] args)
		{
			var customer = new Customer();
			customer.CalculateRating(true);

		}
	}
}
