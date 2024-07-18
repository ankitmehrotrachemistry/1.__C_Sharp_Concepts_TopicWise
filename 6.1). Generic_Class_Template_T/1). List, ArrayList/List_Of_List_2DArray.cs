using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Of_List_2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<string>> lists = new List<List<string>>()
            {
                new List<string>() {"CSE-1", "CSE-2", "CSE-3", "CSE-4" },
                new List<string>() {"ECE-1", "ECE-2", "ECE-3", "ECE-4" },
            };
            string[,] arrays = new string[lists.Count, lists[0].Count]; // lists.Count = 2, lists[0].Count = 4

            for (int i = 0; i < lists.Count; i++)
            {
                for (int j = 0; j < lists[i].Count; j++)
                {
                    arrays[i, j] = lists[i][j];
                }
            }
            foreach (var array in arrays)
                Console.WriteLine(String.Join(", ", array));

            string[][] array1 = lists.Select(x => x.ToArray()).ToArray();

            Console.WriteLine("---------------------------------------");

            foreach (var array in array1)
                Console.WriteLine(String.Join(", ", array));

        }
    }
}
