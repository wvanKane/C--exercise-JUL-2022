using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _02UnderstandingTypes
{
    public class Assignment1
    {
        static public void Main()
        {
            //please fill a number between 0 to 255
            //int max = 10; 
            for (byte hour = 0; hour < 24; hour++)
            {

            //String timeNow = DateTime.Now.ToString("t", CultureInfo.CreateSpecificCulture("es-ES"));
            //DateTime current = DateTime.Now;
            //byte hour = byte.Parse(current.Hour.ToString());
            //int hour = 7;
            //if (6 < hour < 12)
            if ((hour > 6) && (hour <= 12))
                Console.WriteLine("Good morning");
            if ((hour > 12) && (hour <= 18))
                Console.WriteLine("Good afternoon");
            if ((hour > 18) && (hour <= 21))
                Console.WriteLine("Good evening");
            if ((hour > 21) || (hour <= 6))
                Console.WriteLine("Good night");


            }
        }

        //private static void WriteLine(byte i)
        //{
        //    throw new NotImplementedException();
        //}

        public void NumCheck()
        {
            Console.WriteLine("The max of sbyte is " + sbyte.MaxValue + " and the min is " + sbyte.MinValue);
            Console.WriteLine("The max of byte is " + byte.MaxValue + " and the min is " + byte.MinValue);
            Console.WriteLine("The max of short is " + short.MaxValue + " and the min is " + short.MinValue);
            Console.WriteLine("The max of ushort is " + ushort.MaxValue + " and the min is " + ushort.MinValue);
            Console.WriteLine("The max of int is " + int.MaxValue + " and the min is " + int.MinValue);
            Console.WriteLine("The max of uint is " + uint.MaxValue + " and the min is " + uint.MinValue);
            Console.WriteLine("The max of long is " + long.MaxValue + " and the min is " + long.MinValue);
            Console.WriteLine("The max of ulong is " + ulong.MaxValue + " and the min is " + ulong.MinValue);
            Console.WriteLine("The max of float is " + float.MaxValue + " and the min is " + float.MinValue);
            Console.WriteLine("The max of double is " + double.MaxValue + " and the min is " + double.MinValue);
            Console.WriteLine("The max of decimal is " + decimal.MaxValue + " and the min is " + decimal.MinValue);
        }

        public void centuries(int input)
        {
            int years = input * 100;
            double days = years * 365.25;
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            decimal milliseconds = (decimal)(seconds * 1000);
            decimal microseconds = milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{input} centuries = {years} years = " +
                $"{days} days = {hours} hours = {minutes} minutes = {seconds} seconds" +
                $" = {milliseconds} milliseconds = {microseconds} microseconds = " +
                $"{nanoseconds} nanoseconds");
        }

        public void FizzBuzzGame()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " is a FizzBuzz word");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " is a Fizz word");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " is a Buzz word");
                }
                else
                {
                    Console.WriteLine(i + " ");
                }
            }
        }

        public void byteLimit()
        {
            //please fill a number between 0 to 255. Otherwise it will endless loop.
            int max = 256;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i); 
            }
        }

        public void GuessNumber()
        {
            int randomNumber = new Random().Next(3) + 1;  // generates a random number between 1 and 3 

            while (true)
            {
                Console.WriteLine("Please enter an intger between 1 and 3: ");
                double input = Convert.ToDouble(Console.ReadLine());
                if (input == randomNumber)
                {
                    Console.WriteLine("Corrent!! the number is " + randomNumber);
                    return;
                }
                else if (input > randomNumber)
                {
                    if (input > 3)
                    {
                        Console.WriteLine("Please enter number less than 3.");
                    }
                    Console.WriteLine("Your number is greater than corrent number");
                }
                else
                {
                    if (input < 1)
                    {
                        Console.WriteLine("Please enter number greater than 1.");
                    }
                    Console.WriteLine("Your number is less than corrent number");
                }
            }
        }

        public void print_a_Pyramid()
        {
            Console.WriteLine("Please enter an intger: ");
            int max = Convert.ToInt32(Console.ReadLine());
            //int max = 15;
            for (int i = max; i >= 0; i -= 2)
            {
                for (int k = 0; k <= i; k += 2)
                {
                    Console.Write(" ");
                }
                for (int j = max; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void birth_date()
        {
            Console.WriteLine("Please enter your birthday(MM/DD/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            int days = (DateTime.Today - date).Days;
            Console.WriteLine($"You are now {days} days old.");
            int daysToNextAnniversary = 10000 - (days % 10000);
            Console.WriteLine($"There are {daysToNextAnniversary} day(s) left to the next anniversy day");
            DateTime anniversaryDate = DateTime.Today.AddDays(10000 - (days % 10000));
            Console.WriteLine($"AnniversaryDate is {anniversaryDate}");
        }

        public void Greeting()
        {
            //String timeNow = DateTime.Now.ToString("t", CultureInfo.CreateSpecificCulture("es-ES"));
            DateTime current = DateTime.Now;
            byte hour = byte.Parse(current.Hour.ToString());
            //int hour = 7;
            //if (6 < hour < 12)
            if ((hour > 6) && (hour <= 12))
                Console.WriteLine("Good morning");
            if ((hour > 12) && (hour <= 18))
                Console.WriteLine("Good afternoon");
            if ((hour > 18) && (hour <= 21))
                Console.WriteLine("Good evening");
            if ((hour > 21) || (hour <= 6))
                Console.WriteLine("Good night");
        }
    }   
}

