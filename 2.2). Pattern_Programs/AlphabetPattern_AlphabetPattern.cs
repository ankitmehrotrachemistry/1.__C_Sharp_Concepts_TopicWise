﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabetPattern
{
    /* 
         1
         2a
         3ab
         4abc
         5abcd
         6abcde
    */
    class Program
    {
        static void Main(string[] args)
        {
            int n, s = 1;
            Console.Write("Number of rows : ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(s);
                        s++;
                    }
                    else
                    {
                        Console.Write((char)('a' + (j - 1)));
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}