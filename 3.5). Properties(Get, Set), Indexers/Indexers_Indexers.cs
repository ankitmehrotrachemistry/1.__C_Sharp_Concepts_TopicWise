using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static public int size = 10;
        private string[] playerList = new string[size];

        public Program()
        {
            for (int i = 0; i < size; i++)
                playerList[i] = "N.A.";
        }

        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = playerList[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    playerList[index] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            p[0] = "A";
            p[1] = "B";
            p[2] = "C";
            p[3] = "D";
            p[4] = "E";

            for (int i = 0; i < Program.size; i++)
            {
                Console.WriteLine(p[i]);
            }
            Console.ReadKey();
        }
    }
}
