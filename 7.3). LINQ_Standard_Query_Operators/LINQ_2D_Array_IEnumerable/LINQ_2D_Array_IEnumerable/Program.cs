using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_2D_Array_IEnumerable
{
    static class Program
    {
        public static T[,] TwoDimensionalArray<T>(this IEnumerable<IEnumerable<T>> enumerable)
        {
            var lines = enumerable.Select(x => x.ToArray()).ToArray();
            var columnCount = lines.Max(x => x.Length);

            var tw = new T[lines.Length, columnCount];

            for (var lineIndex = 0; lineIndex < lines.Length; lineIndex++)
            {
                var line = lines[lineIndex];

                for (var columnIndex = 0; columnIndex < line.Length; columnIndex++)
                {
                    tw[lineIndex, columnIndex] = line[columnIndex];
                }
            }
            return tw;
        }
        static void Main(string[] args)
        {
            var r = new Random();
            var results = Enumerable.Range(0, 100)
                                    .Select(lineIndex => Enumerable.Range(0, 200)
                                    .Select(columnIndex => r.Next()))
                                    .TwoDimensionalArray();
            Console.WriteLine(results.GetLength(0) == 100);
            Console.WriteLine(results.GetLength(1) == 200);
        }
    }
}
