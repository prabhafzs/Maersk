using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWords
{
    class Program
    {
        public string[] unitsMap = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        public string[] tensMap = { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        static void Main(string[] args)
        {
            int input = 0;
            Program p = new Program();
            Console.WriteLine("Please enter a non-negative number: ");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                input = result;
                Console.WriteLine(p.NumberToWords(input));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Wrong Input. Press Any Key to Exit..");
                Console.ReadKey();
            }
            
        }

        

        public string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            //if (number < 0)
            //    return "minus " + NumberToWords((number));

            string text = "";

            if ((number / 1000000) > 0)
            {
                text += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                text += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                text += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    text += unitsMap[number];
                else
               {
                    text += tensMap[number / 10];
                    if ((number % 10) > 0)
                        text += " " + unitsMap[number % 10];
                }
            }
            return text;
        }
    }
}
