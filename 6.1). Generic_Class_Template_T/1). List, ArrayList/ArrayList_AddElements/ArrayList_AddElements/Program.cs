using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ArrayList_AddElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Ankit");
            arrayList.Add(" ");
            arrayList.Add(true);
            arrayList.Add(2.4);
            // Adding Objects using Object Initializer
            var arrayList2 = new ArrayList()
                             {
                                 1,"Mehrotra",true,2.8
                             };
            Console.WriteLine("ArrayList 1 Elements are : ");
            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine(arrayList[i]);
            Console.WriteLine("ArrayList 2 Elements are : ");
            for (int i = 0; i < arrayList2.Count; i++)
                Console.WriteLine(arrayList2[i]);
        }
    }
}