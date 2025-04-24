using System;
using System.Text.RegularExpressions;

namespace AssignmentThreeAndFour
{
    public class NumberToWords

    {
        private string[] ones = { "One", "Two", "Three", "Tour", "Five", "Six", "Seven", "Eight", "Nine" };

        private string[] others = {"Eleven", "Twelve","Thirteen","Fourteen", "Fifteen","Sixteen","Seventeen","Eighteen","Nineteen"};

        private string[] tens = { "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        //private static string[] hundreds = { "hundred", "thousand" };



        public void ToWords(string number)
        {
            string pattern = @"(?:[0-9]{1,4}|0)$";
            Regex r = new Regex(pattern);
            
            if (r.IsMatch(number)){
                if (number.Length == 4)
                {
                    string thousand = number[0].ToString();
                    int digit = int.Parse(thousand);
                    string hundreds_digit = number[1].ToString();
                    int hundred = int.Parse(hundreds_digit);
                    string ten_digit = number[2].ToString();
                    int ten = int.Parse(ten_digit);
                    string units = number[3].ToString();
                    int unit = int.Parse(units);

                    if (unit == 0) {
                        Console.WriteLine($"{ones[digit - 1]} thousand {ones[hundred - 1]} hundred and {tens[ten - 1]}");
                    }
                    else if (!(ten == 0) && !(hundred == 0) && !(unit == 0))
                    {
                        Console.WriteLine($"{ones[digit - 1]} thousand {ones[hundred - 1]} hundred and {tens[ten - 1]} {ones[unit - 1]}");
                    }
                    else if (ten == 0 && hundred == 0) {
                        Console.WriteLine($"{ones[digit - 1]} thousand and {ones[unit - 1]}");

                    }
                    else if (unit == 0 && hundred == 0) {
                        Console.WriteLine($"{ones[digit - 1]} thousand and {tens[ten - 1]}");
                    }
                    else if (unit == 0 && hundred == 0 && ten == 0)
                    {
                        Console.WriteLine($"{ones[digit - 1]} thousand");
                    }
                }

                else if (number.Length == 3)
                {
                    string hundreds_digit = number[0].ToString();
                    int hundred = int.Parse(hundreds_digit);
                    string ten_digit = number[1].ToString();
                    int ten = int.Parse(ten_digit);
                    string units = number[2].ToString();
                    int unit = int.Parse(units);
                    if (!(ten == 0) && !(unit == 0)) {
                        Console.WriteLine($"{ones[hundred - 1]} hundred and {tens[ten - 1]} {ones[unit - 1]}");
                    }
                    else if (ten == 0 && unit == 0)
                    {
                        Console.WriteLine($"{ones[hundred - 1]} hundred");
                    }
                    else if (unit == 0)
                    {
                        Console.WriteLine($"{ones[hundred - 1]} hundred and {tens[ten - 1]} ");
                    }
                    else if (ten == 0 && unit != 0) {
                        Console.WriteLine($"{ones[hundred - 1]} hundred and {ones[unit - 1]}");
                    }
                }

                else if (number.Length == 2)
                {
                    string ten_digit = number[0].ToString();
                    int ten = int.Parse(ten_digit);
                    string units = number[1].ToString();
                    int unit = int.Parse(units);

                    if ((int.Parse(number) <= 19))
                    {
                        int digit = int.Parse(number.ToString()) - 11;
                        Console.WriteLine(others[digit]); }
                    else if (int.Parse(number) == 10)
                    {
                        Console.WriteLine(tens[0]);
                    }
                    else if (int.Parse(number) > 19 && !(int.Parse(number[1].ToString()) == 0))
                    {
                        Console.WriteLine($"{tens[ten - 1]} {ones[unit - 1]}");
                    }
                    else if (int.Parse(number[1].ToString()) == 0)
                    {

                        Console.WriteLine(tens[ten - 1]);
                    }
                }
                else if (number.Length == 1)
                {
                    if (int.Parse(number) == 0)
                    {
                        Console.WriteLine("zero");
                    }
                    else
                    {
                        int digit = int.Parse(number);
                        Console.WriteLine(ones[digit - 1]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Use a valid number between 0-9999!");
                Console.Beep();
            }
        }
    }
}

