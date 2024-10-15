using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	class Program
	{
		static void Main(string[] args)
		{
			var text = new Text();
			text.width = 100;
			text.height = 100;
			text.Copy();
		}
	}
}
