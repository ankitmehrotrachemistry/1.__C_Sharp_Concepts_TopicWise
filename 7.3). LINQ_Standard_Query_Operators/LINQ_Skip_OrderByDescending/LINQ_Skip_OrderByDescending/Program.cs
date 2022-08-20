using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Skip_OrderByDescending
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] score = { 100, 20, 50, 8, 140, 80, 40};

            // Descending Order is : 140 , 100 , 80 , 50 , 40 , 20 , 8  
            // Skip will skip first Two Elements

            IEnumerable<int> playerScore = score.AsQueryable().OrderByDescending(s => s).Skip(2);

            foreach (int res in playerScore)
            {
                Console.WriteLine(res);
            }
        }
    }
}
