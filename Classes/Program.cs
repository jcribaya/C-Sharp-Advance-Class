using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
	class Program
    {
        static void Main(string[] args)
        {
            var p = Person.Parse("John");
            p.Introduce();
        }
    }
}
