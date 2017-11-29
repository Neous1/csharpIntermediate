using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //create a class that derives from presentationObject

    public class Text: PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
