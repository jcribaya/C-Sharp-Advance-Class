﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	public class Program
	{
		static void Main(string[] args)
		{

			var point = new Point(10, 20);
		
			point.Move(new Point(10, 20));
            Console.WriteLine("Point is at {0} {1},", point.X, point.Y);

			point.Move(100, 200);
            Console.WriteLine("Point is at {0} {1},", point.X, point.Y);
        }
    }
}
