using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsoleTest.StaticKeyword
{
    public class Person 
    {
        public static string name = "A Person";

        public string pname { get; set; }

        static Person()
        {
            Console.WriteLine("Static Block Working");
            Console.WriteLine(name);
        }

        public Person()
        {
            Console.WriteLine("Construtor working");
        }
    }
}
