using System;
using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module13
{
    class Program
    {
        private static Dictionary<string, Contact> PhoneBook = new Dictionary<string, Contact>()
        {
            ["Seva"] = new Contact(5435435345, "dfsgsdg@dfsfsdf"),
            ["Nastya"] = new Contact(4534535, "dfgdfgdfg#$43534")
        };
        static void Main(string[] args)
        {
            //Console.WriteLine("Текущий список");
            //WriteContactsAll();
            var stopWatch = Stopwatch.StartNew();
            PhoneBook.Add("Dima", new Contact(2432342423, "csgsdsdf@dsfgfdsaf"));
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);
            //Console.WriteLine("Обнавленный список");
            //WriteContactsAll();

            //if (PhoneBook.TryGetValue("Dima", out Contact contact))
            //    contact.PhoneNumber = 345345345345;

            //Console.WriteLine("Список после изменений");
            //WriteContactsAll();
        }
        
        //public static void WriteContactsAll()
        //{
        //    foreach (var contact in PhoneBook)
        //    {
        //        Console.Write(contact.Key + ": " + contact.Value.PhoneNumber);
        //        Console.WriteLine();
        //    }
        //}
    }
}