using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            

            do
            {
                Console.WriteLine("Menu----------");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                
                Console.WriteLine("Enter your choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Addition: " + (num1 + num2));
                        break;

                    case 2:
                        Console.WriteLine("Substraction: " + (num1 - num2));
                        break;

                    case 3:
                        Console.WriteLine("Multiplication: " + (num1 * num2));
                        break;

                    case 4:
                        Console.WriteLine("Division: " + (num1 / num2));
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            } while (choice != 5);
        }
    }
}