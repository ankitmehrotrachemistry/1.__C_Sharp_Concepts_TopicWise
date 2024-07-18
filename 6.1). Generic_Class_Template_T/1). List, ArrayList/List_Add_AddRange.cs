using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Add_AddRange
{
    class Program
    {
        public static void ShowListItems(List<string> list)
        {
            foreach (var elem in list)
            {
                Console.WriteLine("{0,3}", elem);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string> StudentName = new List<string>();

            StudentName.Add("Ankit");
            StudentName.Add("Baby");
            StudentName.Add("Chaaya");
            StudentName.Add("Daniya");
            StudentName.Add("Elizabeth");

            Console.WriteLine("---------- LIST 1 ----------");
            ShowListItems(StudentName);


            List<string> authors = new List<string>();

            string[] authorName = {"V.K Aggarwal", "M.L. Khanna", "K.C. Sinha", "R.C. Mukherjee"};

            authors.AddRange(authorName);
            Console.WriteLine("---------- LIST 2 ----------");
            ShowListItems(authors);
        }
    }
}
