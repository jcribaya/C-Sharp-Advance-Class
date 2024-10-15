using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
	class Program
	{
		static void Main(string[] args)
		{
			var cookie = new HttpCokie();
			cookie["name"] = "test";
			Console.WriteLine(cookie["name"]);
		}
	}
}
