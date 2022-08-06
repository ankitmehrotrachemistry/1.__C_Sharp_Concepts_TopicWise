using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Insert_InsertRange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNameList = new List<string>() {"Ankit", "Anamika"};

            studentNameList.Insert(0, "Baby");
            studentNameList.Insert(3, "Aparajita");

            List<string> studentName = new List<string>() {"Angelina","Arkita"};

            studentNameList.InsertRange(1, studentName);

            Console.WriteLine("------ List Elements ------");

            foreach (string item in studentNameList)
            {
                Console.WriteLine($" {item} ");
            }
        }
    }
}
