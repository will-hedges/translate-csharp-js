﻿using System;

Main();

void Main()
{
    for (int n = 1; n <= 100; n++)
    {
        if (n % 15 == 0)
        {
            Console.WriteLine("fizzbuzz");
        }
        else if (n % 3 == 0)
        {
            Console.WriteLine("fizz");
        }
        else if (n % 5 == 0)
        {
            Console.WriteLine("buzz");
        }
        else
        {
            Console.WriteLine(n);
        }
    }
}
