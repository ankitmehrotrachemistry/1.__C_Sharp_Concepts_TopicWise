using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerable_Demo
{
    public class Person
    {
        public string firstName;
        public string lastName;
        public Person(string fName, string lName)
        {
            this.firstName = fName;
            this.lastName = lName;
        }
    }
    public class PeopleEnum : IEnumerator
    {
        public Person[] _people;

        int position = -1;
        public PeopleEnum(Person[] list)
        {
            _people = list;
        }
        
        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public void Reset()
        {
            position = -1;
        }
        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
    }
    public class People : IEnumerable
    {
        private Person[] _people;
        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }
        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[4]
                {
                    new Person("Pew", "Dio"),
                    new Person("Rajesh", "Khanna"),
                    new Person("Simran", "Khaton"),
                    new Person("Lucky", "Bale"),
                };

            People peopleList = new People(peopleArray);

            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " +p.lastName);
        }
    }
}
