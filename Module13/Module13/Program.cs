using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module13
{
    class Program
    {
        private static Stack<string> PhoneBook = new Stack<string>();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек или Введите pop если хотите удалить полседнее слово, или peek если хотите увидеть последнее слово или пропустите.");
            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "pop":
                        PhoneBook.TryPop(out string popResult);
                        break;
                    case "peek":
                        PhoneBook.TryPeek(out string peekResult);
                        break;
                    default:
                        PhoneBook.Push(input);
                        break;
                }

                //Console.WriteLine();
                //    Console.WriteLine("В стеке: ");

                //    foreach (var word in PhoneBook)
                //    {
                //        Console.WriteLine(word);
                //    }
            }
        }
    }
}