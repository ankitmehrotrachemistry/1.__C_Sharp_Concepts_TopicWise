using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Collections;

namespace JSON_ParseData
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Ankit",
                Degree = "CSE",
                Hobbies = new List<string>
                {
                    "Playing Games",
                    "Programming"
                }
            };

            string strResultJson = JsonConvert.SerializeObject(student);
            //Console.WriteLine(strResultJson);
            File.WriteAllText(@"student.json", strResultJson);
            Console.WriteLine("Stored!");

            strResultJson = string.Empty;
            strResultJson = File.ReadAllText(@"student.json");
            Student resultStudent = JsonConvert.DeserializeObject<Student>(strResultJson);
            Console.WriteLine(resultStudent.ToString());

            var dictionary = JsonConvert.DeserializeObject<IDictionary>(strResultJson);
            foreach(DictionaryEntry entry in dictionary)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
    }
}
