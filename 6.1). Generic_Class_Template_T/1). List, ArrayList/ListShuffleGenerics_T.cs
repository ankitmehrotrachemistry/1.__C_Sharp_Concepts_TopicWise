using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListShuffleGenerics_T
{
    class Program
    {
        public static List<T> ShuffleList<T>(List<T> list)
        {
            Random rand = new Random();

            for (int i = 0; i < list.Count; i++)
            {
                int k = rand.Next(0, i);

                T value = list[k];
                list[k] = list[i];
                list[i] = value;
            }

            return list;
        }
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            myList.Add(1);
            myList.Add(4);
            myList.Add(8);
            myList.Add(12);
            myList.Add(2);
            myList.Add(20);

            myList = ShuffleList(myList);

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
