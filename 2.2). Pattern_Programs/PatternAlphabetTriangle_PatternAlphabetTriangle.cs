﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAlphabetTriangle
{
    class Program
    {
        /*
                   A
                  ABA
                 ABCBA
                ABCDCBA
               ABCDEDCBA
         
        */
        static void Main(string[] args)
        {
            char ch = 'A';
            int i, j, k, m, n;
            Console.Write("Enter the Range=");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = n; j >= i; j--)
                    Console.Write(" ");
                for (k = 1; k <= i; k++)
                    Console.Write(ch++);
                ch--;
                for (m = 1; m < i; m++)
                    Console.Write(--ch);
                Console.Write("\n");
                ch = 'A';
            }
        }
    }
}
