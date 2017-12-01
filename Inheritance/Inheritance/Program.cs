using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //create a class that derives from presentationObject

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}
