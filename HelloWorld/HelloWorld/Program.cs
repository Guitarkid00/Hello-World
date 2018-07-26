using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = "Hello World";
            Console.WriteLine(output);

            //Or it can be done as a single line
            Console.WriteLine("Hello World 1");

            //Use console readline to stop automatically closing
            Console.ReadLine();
        }
    }
}
