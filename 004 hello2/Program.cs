﻿using System;

namespace _004_hello2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[1];

            Console.WriteLine("Witaj, " + name);

            foreach (var item in args)
            {
                Console.WriteLine("Witaj " + item);

            }
        }
    }
}
