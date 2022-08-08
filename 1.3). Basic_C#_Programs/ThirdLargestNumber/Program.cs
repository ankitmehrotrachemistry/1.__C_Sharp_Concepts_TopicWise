using System;

namespace ThirdLargestNumber
{
    class Program
    {
        public static int getThirdLargest(int[] a, int total)
        {
            int temp;
            for (int i = 0; i < total; i++)
            {
                for (int j = i + 1; j < total; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a[total - 3];
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 4, 8, 0, 12 };
            Console.WriteLine("Third largets is : " +getThirdLargest(a,6));
        }
    }
}
