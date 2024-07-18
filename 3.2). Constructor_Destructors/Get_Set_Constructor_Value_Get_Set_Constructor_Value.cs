using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_Constructor_Value
{
    class Program
    {
        public class DriverLicence
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Gender { get; set; }
            public string LicenceNumber { get; set; }
            public DriverLicence(string firstName, string lastName, string gender, string licenceNumber)
            {
                FirstName = firstName;
                LastName = lastName;
                Gender = gender;
                LicenceNumber = licenceNumber;
            }
            public string Name()
            {
                string FullName = FirstName + " " + LastName;
                return FullName;
            }
            static void Main(string[] args)
            {
                DriverLicence DL = new DriverLicence("Ankit", "Mehrotra", "Male", "12345");
                Console.WriteLine(DL.Name());
            }
        }
    }
}