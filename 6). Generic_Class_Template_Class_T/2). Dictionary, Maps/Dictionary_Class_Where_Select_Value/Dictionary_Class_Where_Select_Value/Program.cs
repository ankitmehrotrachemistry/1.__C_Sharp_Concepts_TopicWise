using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Class_Where_Select_Value
{
    class Symbol
    {
        public int SymbolId { get; set; }
        public string SymbolName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Symbol> dict = new Dictionary<string, Symbol>();

            dict.Add("Ankit", new Symbol { SymbolId = 12, SymbolName = "PIC1" });
            dict.Add("Chaaya", new Symbol { SymbolId = 8, SymbolName = "PIC2" });
            dict.Add("Bubbly", new Symbol { SymbolId = 24, SymbolName = "PIC3" });
            dict.Add("Dubbly", new Symbol { SymbolId = 2, SymbolName = "PIC4" });

            var dictValue = from x in dict
                            where x.Value.SymbolName.Contains("PIC4")
                            select x;

            // Using LINQ
            Console.WriteLine(dictValue.First().Key);
            Console.WriteLine(dictValue.First().Value.SymbolId);

            Console.WriteLine("============================");

            // Using Lambda Expression
            var dictValue1 = dict.Where(x => x.Value.SymbolName == "PIC2")
                                 .Select(x => x);
            Console.WriteLine(dictValue1.First().Value.SymbolName);
            Console.WriteLine(dictValue1.First().Value.SymbolId);
        }
    }
}
