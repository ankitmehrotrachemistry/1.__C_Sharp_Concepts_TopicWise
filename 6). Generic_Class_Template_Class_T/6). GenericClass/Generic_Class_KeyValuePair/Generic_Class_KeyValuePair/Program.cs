using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Class_KeyValuePair
{
    class DataStorage<T>
    {
        public T Data { get; set; }
    }
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataStorage<string> strStore = new DataStorage<string>();
            strStore.Data = "Ankit Mehrotra";
            Console.WriteLine(strStore.Data);

            DataStorage<int> intStore = new DataStorage<int>();
            intStore.Data = 100;
            Console.WriteLine(intStore.Data);

            KeyValuePair<int, string> KVP1 = new KeyValuePair<int, string>();
            KVP1.Key = 200;
            KVP1.Value = "Two Hundred";
            Console.WriteLine(KVP1.Key + " , " + KVP1.Value);
        }
    }
}
