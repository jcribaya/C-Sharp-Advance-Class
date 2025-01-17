﻿using System.Collections.Generic;

namespace Constructors
{
	public partial class Program
	{
		public class Customer
		{
			public int Id;
			public string Name;
			public List<Order> Orders;
			public Customer()
			{
				Orders = new List<Order>();	
			}
			public Customer(int id)
			{
				this.Id = id;
			}

			public Customer(int id, string name)
			{
				this.Id = id;
				this.Name = name;
			}
		}
	}
}
