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
            Assignment1 assignment1 = new Assignment1();
        }
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

    }   
}

