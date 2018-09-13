using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project_Ex1
{
    class Program
    {//By Kamil Jusis on 13/09/2018
     //This program asks for your name and then welcomes you to the module
        static void Main(string[] args)
        {
            Console.Write("Please enter your first name\n");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your surname\n");
            string surName = Console.ReadLine();
            Console.Write("Welcome to Programming with objects " + firstName + " " + surName);
            Console.ReadKey();
        }
    }
}