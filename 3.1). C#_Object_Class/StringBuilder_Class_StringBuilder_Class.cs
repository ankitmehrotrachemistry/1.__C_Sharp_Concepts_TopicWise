using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Ankit", 1120580);
            sb.Append("Mehrotra");
            sb.AppendLine("Game Developer");
            sb.AppendLine("New Line");
            Console.WriteLine(sb);
        }
    }
}