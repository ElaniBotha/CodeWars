using CodeWars.Kata;
using System;

namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            char a = 'a';
            char b = 'w';
            Console.WriteLine($"These letters ({a}, {b}) are the same case: {SameCaseKata.SameCase(a, b)}");

            a = 'a';
            b = 'B';
            Console.WriteLine($"These letters ({a}, {b}) are the same case: {SameCaseKata.SameCase(a, b)}");

            a = 'a';
            b = '0';
            Console.WriteLine($"These letters ({a}, {b}) are the same case: {SameCaseKata.SameCase(a, b)}");
        }
    }
}