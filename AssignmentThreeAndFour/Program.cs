using System;
using System.Text.RegularExpressions;



namespace AssignmentThreeAndFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("******************Welcome to console systems********************");
            Console.ResetColor();

            Console.WriteLine("Access system :");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  1. Number To Word");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("  2. Hotel Management System");
            Console.ResetColor();
            string input = Console.ReadLine();

            if (int.Parse(input) == 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Enter number to convert (0 - 9999):");
                string number = Console.ReadLine();
                Console.ResetColor();
                NumberToWords numberText = new NumberToWords();
                Console.ForegroundColor = ConsoleColor.Green;
                numberText.ToWords(number);
                Console.ResetColor();

            }
            else if (int.Parse(input) == 2)

            {
                string pattern = @"(?:[0-9]{1,4}|0)$";
                Regex r = new Regex(pattern);
                HotelManSys hotel = new HotelManSys();

                while (true)
                {

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("***************Welcome to FIL hotel********************");
                    Console.WriteLine("1. Check-in guest");
                    Console.WriteLine("2. Check-out guest");
                    Console.WriteLine("3. View rooms statuses");
                    Console.WriteLine("4. Print statuses to txt file");
                    Console.WriteLine("Enter 'exit' to leave");
                    Console.ResetColor();

                    string answer = Console.ReadLine();
                    






               if (r.IsMatch(answer)) { 

                    if (int.Parse(answer) == 1)
                    {
                        Console.WriteLine("Please enter your staff number (0-2):");
                        string id = Console.ReadLine();

                        Console.WriteLine("Enter the room number (0-3):");
                        string roomNumber = Console.ReadLine();

                        Console.WriteLine("Enter the guest's names:");
                        string guest = Console.ReadLine();
                        Console.WriteLine(hotel.BookRoom(int.Parse(roomNumber), int.Parse(id), guest));

                    }
                    else if (int.Parse(answer) == 2)
                    {
                           Console.WriteLine("Enter the room number to checkout the guest:");
                           string roomNumber = Console.ReadLine();
                           Console.WriteLine(hotel.CheckoutRoom(int.Parse(roomNumber)));
                           



                        }
                    else if (int.Parse(answer) == 3)
                    {
                        hotel.PrintRoomStatus();

                    }
                    else if (int.Parse(answer) == 4)
                    {
                        hotel.writetoFile();

                    }
                }
                else if (answer.ToLower() == "exit") {
                    break;
                        
                }

                }
            }
            else
            {
                Console.WriteLine("No an option!!");
            }
        }
    }
}
