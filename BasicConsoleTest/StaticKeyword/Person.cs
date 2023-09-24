using System;
using System.Collections.Generic;
using System.Text;

namespace BasicConsoleTest.StaticKeyword
{
    public class Person 
    {
        public static string Name = "A Person";

        public string Pname { get; set; }

        static Person()
        {
            Console.WriteLine("Static Block Working");
            Console.WriteLine(Name);
        }

        public Person()
        {
            Console.WriteLine("Construtor working");
        }
    }
}
