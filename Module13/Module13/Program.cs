using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Reflection;
using System.Security.Authentication;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using String = System.String;

namespace Module13
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\Ghosman\\Desktop\\Text1.txt");
            var words = text.Split(new[] { ',', '.', ' ', ';', ':', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            var listOne = new Dictionary<string, int>();
            foreach (var word in words)
                if (listOne.ContainsKey(word))
                    listOne[word]++;
                else
                    listOne.Add(word, 1);

            var sortDict = listOne.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            var i = 0;
            while (true) 
            {
                if (i == 10)
                    break;
                Console.WriteLine(sortDict.Last());
                    sortDict.Remove(sortDict.Keys.Last());
                    i++;
            }
        }
    }
}