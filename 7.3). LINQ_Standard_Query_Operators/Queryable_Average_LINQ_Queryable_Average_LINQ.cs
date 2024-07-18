using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queryable_Average_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = {40,20,10,50,80};

            double average = Queryable.Average(MyArray.AsQueryable());

            Console.WriteLine("Average of Array LEments : {0}", average);
        }
    }
}
