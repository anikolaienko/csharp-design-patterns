using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static System.Console;
using CsharpDesignPatterns.Creational;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var prod = new Product1("This is me");
            WriteLine(prod.Name);
            WriteLine((prod.Clone() as Product1).Name);

            var prod2 = new Product2("This is you");
            WriteLine(prod2.Title);
            WriteLine((prod2.Clone() as Product2).Title);
        }
    }
}
