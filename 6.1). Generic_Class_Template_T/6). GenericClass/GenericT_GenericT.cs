using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericT
{
    class DataTypeCollector
    {
        public void DataCollector<T>(T data)
        {
            Console.WriteLine(data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DataTypeCollector d = new DataTypeCollector();
            
            d.DataCollector<int>(100);
            d.DataCollector(200);
            d.DataCollector<string>("My");
            d.DataCollector("Name!");
        }
    }
}
