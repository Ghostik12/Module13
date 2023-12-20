using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Reflection;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\Ghosman\\Desktop\\Text1.txt");
            
            var words = text.Split(' ');
            var stopWatchList = Stopwatch.StartNew();

            List<string> listOne = new List<string>(words);
            Console.WriteLine(stopWatchList.Elapsed.TotalMilliseconds);

            var stopWatchLinked = Stopwatch.StartNew();

            LinkedList<string> listTwo = new LinkedList<string>(words);
            Console.WriteLine(stopWatchLinked.Elapsed.TotalMilliseconds);
        }
    }
}