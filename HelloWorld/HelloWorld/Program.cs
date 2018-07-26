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

            string aTutor = "Murray in 303";
            string bTutor = "Jacob in 308";
            string cTutor = "Stefan in 219";
            string dTutor = "Ray";
            Console.WriteLine($"Our tutors are {aTutor}, {bTutor}, {cTutor} and {dTutor}");

            Console.ReadLine();

            Console.WriteLine("Our current class is");
            string input1 = Console.ReadLine();

            Console.WriteLine($"Our current class is {input1}");
            Console.WriteLine("Our current class is {0}",input1);
            Console.WriteLine($"Our current class is " + input1);

            if(input1 == "5202")
            {
                Console.WriteLine("your teacher is " + bTutor);
            }

            if (input1 == "Wed 1" || input1 == "Tues 1")
            {
                Console.WriteLine("your teacher is " + cTutor);
            }

            if (input1 == "Prog")
            {
                Console.WriteLine("Programming Classes are 3+4 Mon, 4 Wed, and 1+2 Thursday with " + bTutor);
            }

            if (input1 == "Enterprise")
            {
                Console.WriteLine("Enterprise Classes are 1+2 Mon, 3 Wed, and 3+4 Thursday with " + aTutor);
            }


            Console.ReadLine();



        }
    }
}
