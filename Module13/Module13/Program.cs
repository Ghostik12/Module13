using System;
using System.Collections;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = { 3, 4, 25, 23 };
            //Check check = new Check();
            //check.CheckArray(myArray); 
            //Console.WriteLine(check.CheckArray(myArray));

            //var months = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            //var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12};
            //var mas = new ArrayList { 1, "Nastya", 2, 5, "Seva" };
            //int sum = 0;
            //StringBuilder sb = new StringBuilder();

            //var array = new ArrayList();
            //foreach (var number in numbers)
            //{
            //    array.Add(months[number - 1]);
            //    array.Add(number);
            //}

            //foreach (var number in array)
            //    Console.WriteLine(number);

            //foreach (var number in mas)
            //{
            //    if (number is int)
            //        sum += (int)number;

            //    if(number is string)
            //        sb.Append(number);
            //}
            //var result = new ArrayList() { sum, sb.ToString() };

            //foreach (var number in result)
            //    Console.WriteLine(number);


            while (true)
            {
                var str = Console.ReadLine();
                var characters = str.ToCharArray();
                var symbols = new HashSet<char>();
                var signs = new[] { ',', ' ', '.' };
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                foreach (char c in characters)
                    symbols.Add(c);

                Console.WriteLine($"Количество не повторяющихся символов в строке: {symbols.Count}");

                bool containsNumber = symbols.Overlaps(numbers);
                Console.WriteLine($"Содержит ли коллекция цифры: {containsNumber}");

                symbols.ExceptWith(signs);
                Console.WriteLine($"Символов без знаков: {symbols.Count}");

            }
        }
    }
}