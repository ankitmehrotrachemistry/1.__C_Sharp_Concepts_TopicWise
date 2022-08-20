using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_Constructor_Integer_Array
{
    class Employee
    {
        int[] myTeam;
        public Employee(int[] teams)
        {
            myTeam = teams;
        }
        public int[] Teams
        {
            get { return myTeam; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] teams = new int[3];
            teams[0] = 1;
            teams[1] = 2;
            teams[2] = 3;

            Employee employee = new Employee(teams);

            foreach (int team in employee.Teams)
            {
                Console.WriteLine(team);
            }
        }
    }
}