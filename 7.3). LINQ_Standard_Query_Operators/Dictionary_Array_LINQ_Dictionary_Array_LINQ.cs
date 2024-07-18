using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Array_LINQ
{
    public static class CustomArray
    {
        public static T[] GetRow<T>(T[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                             .Select(x => matrix[rowNumber, x])
                             .ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[,]
                             {
                                 { 8,9,6},
                                 { 4,8,2},
                                 { 6,4,2},
                                 { 10,14,16},
                                 { 24,28,44}
                             };
            var dictionary = new Dictionary<int, int[]>();

            int row = myArray.GetLength(0);
            int col = myArray.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                dictionary.Add(i,
                                 new int[i]);
            }

            foreach (KeyValuePair<int, int[]> kvp in dictionary)
            {
                Console.WriteLine("Key is : " + kvp.Key + " Value is : " + string.Join(" , ", CustomArray.GetRow(myArray, kvp.Key) ) );
            }
        }
    }
}
