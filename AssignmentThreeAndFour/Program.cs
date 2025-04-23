using System;


namespace AssignmentThreeAndFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************Welcome to console systems********************");
            Console.ResetColor();

            Console.WriteLine("Access system :");
            Console.WriteLine("  1. Number To Word");
            Console.WriteLine("  2. Hotel Management System");
            string input = Console.ReadLine();

            if (int.Parse(input) == 1)
            {
                Console.WriteLine("Enter number to convert (0 - 9999):");
                string number = Console.ReadLine();
                NumberToWords numberText = new NumberToWords();
                numberText.ToWords(number);

            }
            else if (int.Parse(input) == 2)

            {
                Console.WriteLine("***************Welcome to FIL hotel********************");
                Console.WriteLine("1. Check-in guest");
                Console.WriteLine("2. Check-in guest");
                Console.WriteLine("3. View rooms statuses");


                HotelManSys hotel = new HotelManSys();

                string answer = Console.ReadLine();
                
                if (int.Parse(answer) == 1)
                {
                    Console.WriteLine("Please enter your staff number:");
                    string id = Console.ReadLine();

                    Console.WriteLine("Enter the room number:");
                    string roomNumber = Console.ReadLine();
                    Console.WriteLine(hotel.BookRoom(int.Parse(roomNumber), int.Parse(id)));
                }
                else if ((int.Parse(answer) == 2))
                {
                    Console.WriteLine(hotel.CheckoutRoom(1));

                }
                else if (((int.Parse(answer)==3)))
                    hotel.PrintRoomStatus();
            }
            else
            {
                Console.WriteLine("No an option!!");
            }
        }
    }
}
