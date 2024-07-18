using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Linking2
{
    public class JackpotTarget
    {
        public int templateId { get; set; }
        public bool isTable { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            JackpotTarget jackpotTarget = new JackpotTarget();

            jackpotTarget.templateId = 4;

            Console.WriteLine(jackpotTarget.templateId);
        }
    }
}
