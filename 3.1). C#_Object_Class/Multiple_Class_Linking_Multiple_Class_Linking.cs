using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Class_Linking
{
    public class WildSymbolCell
    {
        public int SymbolID { get; set; }
        public string SymbolName { get; set; }
    }
    public class FloatingWildGroup
    {
        public List<WildSymbolCell> WildSymbolCell { get; set; }
        public int ID { get; set; }
    }
    public class FloatingWildData
    {
        public int windowWidth { get; set; }
        public int windowHeight { get; set; }
        public FloatingWildData(int width, int height)
        {
            windowWidth = width;
            windowHeight = height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            WildSymbolCell window = new WildSymbolCell
            {
                SymbolID = 2,
                SymbolName = "Ankit"
            };
            FloatingWildGroup wildData = new FloatingWildGroup()
            {
                ID = 12
            };
            Console.WriteLine(window.SymbolID);
            Console.WriteLine(window.SymbolName);
            Console.WriteLine(wildData.ID);
        }
    }
}
