using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Tutorial_Main(string[] args)
        {
            // print
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");
            // 1. variable
            string name = "mark";
            int num = 1;
            float length = 123.1f;
            bool tf =  true;
            Console.WriteLine($"my name is {name}");
            Console.WriteLine($"my backnumber is {num}");
            Console.WriteLine($"my foot length is {length}");
            Console.WriteLine($"my answer is {tf}");


            // grub variable
            string[] usr = { "dmlwls", "user", "loot" };
            Console.WriteLine($"my team member is {usr[0]},");
            Console.WriteLine($"my team member is {usr[1]},");
            Console.WriteLine($"my team member is {usr[2]},");


        }
    }
}
