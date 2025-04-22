using System;


namespace AssignmentThreeAndFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Access assignment :");
            Console.WriteLine("  1. Assignment 3");
            Console.WriteLine("  2. Assignmet 4") ;
            string  input = Console.ReadLine(); 

            if(int.Parse(input) == 1)
            {
                Console.WriteLine("Enter number to convert:");
                string number = Console.ReadLine();
                NumberToWords.ToWords(number);
                
                
                
                
                //Do something
            }
            else if(int.Parse(input) == 2)

            {
                //Do something
            }
            else
            {
                Console.WriteLine("No an option!!");
            }
        }
    }
}
