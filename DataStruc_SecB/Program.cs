using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruc_SecB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int asciiCode = 81;
            char asciiChar = ' ';
            string input = "";
            string output = "";

            //Console.WriteLine((int)asciiChar);
            //Console.WriteLine((char)asciiCode);
            //Console.ReadKey();

            Console.WriteLine("Please input anything and " +
                "i will change it to numbers...");
            input = Console.ReadLine();

            for(int x = 0; x < input.Length; x++) 
            { 
                asciiChar = input[x];
                asciiCode = (int)asciiChar;
                output += asciiCode + " ";
            }

            Console.WriteLine(output);
            Console.ReadKey();

        }
    }
}
