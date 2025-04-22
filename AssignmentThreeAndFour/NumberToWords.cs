using System;

namespace AssignmentThreeAndFour
{

    public static class NumberToWords

    {
        public static string[] ones = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        private static string[] others = {"eleven", "twelve","thirteen","fourteen", "fifteen","sixteen","seventeen","eighteen","nineteen"};

        private static string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        //private static string[] hundreds = { "hundred", "thousand" };

        

        public static void ToWords(string number)

        {

            
                if (number.Length == 4)
                {
                    string thousand = number[0].ToString();
                    int digit = int.Parse(thousand);
                    string hundreds_digit = number[1].ToString();
                    int hundred = int.Parse(hundreds_digit);
                    string ten_digit = number[2].ToString();
                    int ten = int.Parse(ten_digit);
                    string units  = number[3].ToString();
                     int unit = int.Parse(units);  
                    if (int.Parse(units) == 0){
                        Console.WriteLine($"{ones[digit-1]} thousand {ones[hundred-1]} hundred and {tens[ten-1]}");
                    }
                    else if(!(ten==0) && !(hundred==0))
                    {
                        Console.WriteLine($"{ones[digit-1]} thousand {ones[hundred-1]} hundred and {tens[ten -1]} {ones[unit-1]}");
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
                            Console.WriteLine(others[digit]);

                        }
                        else if (int.Parse(number) == 10)
                        {
                           Console.WriteLine(tens[0]);
                        }
                        else if (int.Parse(number) > 19 && !(int.Parse(number[1].ToString()) == 0))
                        {
                            Console.WriteLine($"{tens[ten - 1]} {ones[unit-1]}");
                        }
                        else if (int.Parse(number[1].ToString()) == 0)
                        {
                            
                            Console.WriteLine(tens[ten - 1]);
                        }
                    
                    

                    }

                else if (number.Length == 1 )
                {
                    int digit = int.Parse(number);
                    Console.WriteLine(ones[digit-1]);
                }

            




        }
    }





}

