## Advanced C# Concepts

▶️ [Advanced C# Topics](https://www.youtube.com/watch?v=VT9ueWBqquU&list=PLwhVruPHD9ryiH4kN0EHYeXQXIOHLBcJX&index=1)

**Q-1. Abstract Classes.**  

• Abstract methods do not have an implementation.  
• Abstract methods are implicitly virtual.  
• If a class has abstract methods it must be declared abstract itself.  
• One cannot create objects of an abstract class.  

**Q-2. Interface.**  

- Interface = purely abstract class; only signatures, no implementation.
- Interface members must not be static.
- Every interface member (method, property, indexer) must be implemented or inherited from a base class.
- Implemented interface methods must not be declared as override.
- Implemented interface methods can be declared virtual or abstract (i.e. an interface can be implemented by an abstract class).

**Q-2. Static Constructor.**  

**Q-2. StringBuilder Class.**  
StringBuilder is a dynamic object. It doesn’t create a new object in the memory but dynamically expands the needed memory to accommodate the modified or new string.
[StringBuilder in C#](https://www.geeksforgeeks.org/stringbuilder-in-c-sharp/)

**Q-3. Structure and Class**

A class can inherit from a single base class, but implement multiple interfaces.
A struct cannot inherit from any type, but can implement multiple interfaces.

**Q-4. Singleton vs Static Class**  

**Q-4. Uniform type system (boxing / unboxing)**

**Q-5. Generic Classes**

**Q-5. List vs Dictionary**

**Q-5. Delegates**

**Q-6. Func and Action Delegates** 

**Q-7. Tuples** 

**Q-7. as and is operators**

**Q-7. ref and out parameters**

**Q-7. Anonymous Types** 

**Q-6. Indexers**

**Q-8. Value objects on the stack**

**Q-2. Reflections and Attributes**

**Q-2. SOLID Principles**

**Q-1. CLR (Common Language Runtime)**  
The Common Language Runtime (CLR) is a core component of . NET Framework that manages the execution and the lifecycle of all . NET applications (code). It provides various services, including automatic memory management, exception handling, security, and type safety.

**Q-2. C# Profiling**

**Q-1. What are some advanced garbage collection techniques in C# to improve performance?**

Advanced garbage collection techniques in C# to improve performance include:
- Generational Garbage Collection: Separates objects into generations based on their age, allowing the garbage collector to focus on younger generations more frequently.
- Large Object Heap (LOH) Optimization: Special handling for large objects to avoid frequent collections and fragmentation.
- Concurrent and Background Collection: Allows garbage collection to run concurrently with application threads, minimizing pause times.
- Tuning GC Settings: Adjusting parameters like generation sizes, thresholds, and modes (e.g., server mode) based on application requirements.

**Q-2. What techniques can be used to optimize string manipulation for better performance in C#?**

To optimize string manipulation for better performance in C#, consider using the following techniques:

- Use StringBuilder: Instead of concatenating strings directly (which can create new string objects), use StringBuilder for mutable string operations.
- Avoid String Interpolation in Loops: String interpolation ($"{var}") can be inefficient within loops due to repeated allocations; prefer StringBuilder for building complex strings.
- Preallocate StringBuilder Capacity: Set the initial capacity of StringBuilder if you know the expected final size to reduce resizing overhead.
- Utilize Span<T> for In-place Manipulation: Use Span<T> for low-level character manipulation without unnecessary allocations.
- Consider String Pooling: Reuse commonly used strings with string interning or custom string pooling techniques to reduce memory usage.

**Q-2. Difference between Task and Thread**

**Q-4. How do you handle deadlocks in multi-threaded applications in C#?**

Deadlocks in multi-threaded applications can be handled by following these practices:

- Use Resource Allocation Order: Acquire locks and resources in a consistent order across threads to avoid circular dependencies.
- Timeout Mechanisms: Implement timeouts on lock acquisitions to prevent threads from waiting indefinitely.
- Avoid Nested Locks: Minimize nested locking to reduce the risk of deadlocks.
- Detect and Recover: Implement deadlock detection mechanisms or use tools like Monitor.TryEnter with timeout to detect and recover from potential deadlocks.

**Q-4. Compare async/await with Task.Run for concurrent operations in C#.**

- async/await: Used for asynchronous programming to execute non-blocking operations. async methods allow the use of await to pause execution without blocking the thread.
- Task.Run: Used to execute synchronous operations asynchronously on the ThreadPool. Task.Run is typically used to offload CPU-bound work from the main thread.

**Comparison:**

- Use async/await for asynchronous I/O-bound operations (e.g., file I/O, network requests) that involve waiting without blocking the thread.
- Use Task.Run for offloading synchronous CPU-bound operations to the background thread (e.g., complex calculations) to prevent blocking the UI thread.

**Q-5. Describe the differences between deep and shallow copying of objects in C#?**

- **Shallow Copying:** Shallow copying involves creating a new object and copying all of the fields of the original object to the new object. For reference type fields, only the references are copied, not the actual objects they refer to. Therefore, both the original and copied objects will refer to the same referenced objects.

- **Deep Copying:** Deep copying involves creating a new object and recursively copying all of the fields of the original object, including any nested objects that it refers to. This results in a new object graph where each object and its nested objects are independent copies.

The choice between deep and shallow copying depends on the requirements of your application and the nature of the objects being copied. Deep copying is typically used when you need truly independent copies of objects and their entire object graphs.

## LINQ

### A). LINQ Tutorial

- **LINQ Syntax**

```csharp
int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
IEnumerable<int> result = from numbers in Num  
                                where numbers >3  
                                select numbers;  
```

Rewrite the same example by using the LINQ method syntax: 
```csharp
using System;  
usingSystem.Collections.Generic;  
usingSystem. Linq;  
usingSystem. Text;  
usingSystem.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
classProgram  
{  
static void Main(string[] args)  
{  
//Data Source  
List<int>integerList = new List<int>()  
    {  
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10  
    };  

//LINQ Query using Method Syntax  
varMethodSyntax = integerList.Where(obj =>obj> 5).ToList(); 

//Execution  
foreach (var item inMethodSyntax)  
            {  
Console.Write(item + " ");  
            }  
  
Console.ReadKey();  
        }  
    }  
}  
/* Output : 6 7 8 9 10
*/
```

LINQ Mixed Syntax Example: 

```csharp
classProgram  
{  
static void Main(string[] args)  
{  
//Data Source  
List<int>integerList = new List<int>()  
    {  
        1, 2, 3, 4, 5, 6, 7, 8, 9, 10  
    };  
//LINQ Query using Mixed Syntax  
varMethodSyntax = (from obj in integerList  
                   where obj > 5  
                   select obj).Sum();  

//Execution  
Console.Write("Sum Is : " + MethodSyntax);  
  
Console.ReadKey();  
}  
}  
```
- **Lambda Expresssion**

// List to store the countries type of string  
```csharp
List<string> countries = new List<string>();

countries.Add("India");
countries.Add("US");
countries.Add("Australia");
countries.Add("Russia");

//use lambda expression to show the list of the countries  
IEnumerable<string> result = countries.Select(x => x);

//foreach loop to display the countries  
foreach (var item in result)    
{
    Console.WriteLine(item);
}
```

### B). Aggregate Function

- **LINQ Min () Function Syntax in C#**

```csharp
int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
int minimumNum = a.Min();  
```

- **LINQ Max () Function Syntax in C#**

```csharp
int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
int MaximumNum = a.Max();  
```

- **LINQ Sum () Function Syntax in C#**

```csharp
int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
int Sum = Num.Sum();  
```

- **LINQ Count () Function Syntax in C#**

```csharp
int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };  
int Count = Num.Count();  
```

- **LINQ Aggregate () Function Syntax in C#**  
Aggregate() function is used to perform the operation on each item of the list. The Aggregate() function performs the action on the first and second elements and then carry forward the result. 
```csharp
int[] Num = { 1, 2, 3, 4 };  
double Average = Num.Aggregate((a, b) => a + b);  
Console.WriteLine("{0}", Average); //Output 10 ((1+2)+3)+4  
```

### C). LINQ Sorting Operators

Sorting Operators available in LINQ are:  

1. ORDER BY  
2. ORDER BY DESCENDING  
3. THEN BY  
4. THEN BY DESCENDING  
5. REVERSE  

- **Syntax of LINQ OrderBy operator**

```csharp
var studentname = Objstudent.OrderBy(x => x.Name);
```

**LINQ OrderBy Operator Example**
```csharp
using System;  
using System.Collections;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            List<Student> Objstudent = new List<Student>(){  
        new Student() { Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },  
        new Student() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },  
        new Student() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },  
        new Student() { Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },  
        new Student() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }  
        };  
            var studentname = Objstudent.OrderBy(x => x.Name);
 
            foreach (var student in student name)  
            {  
                Console.WriteLine(student.Name);  
            }  
                Console.ReadLine();  
    }  
}  
    class Student  
    {  
        public string Name { get; set; }  
        public string Gender { get; set; }  
        public List<string> Subjects { get; set; }  
    }  
}  
```

- **Syntax of LINQ OrderByDescending operator**

```csharp
var studentname = Objstudent.OrderByDescending(x => x.Name);  
```

**LINQ OrderByDescending Operator Example**

```csharp
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //create object of Student class and create a list of the student information  
            List<Student> Objstudent = new List<Student>()
            {
                new Student() { Name = "Akshay", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
                new Student() { Name = "Vaishali", Gender = "Female", Subjects = new List<string> { "Computer", "Botany" } },
                new Student() { Name = "Arpita", Gender = "FMale", Subjects = new List<string> { "Economics", "Operating System", "Java" } },
                new Student() { Name = "Shubham", Gender = "Male", Subjects = new List<string> { "Account", "Social Studies", "Chemistry" } },
                new Student() { Name = "Himanshu", Gender = "Male", Subjects = new List<string>{ "English", "Charted" } }
    };
            /*OrderByDescending() operator is used to print the name of the student in the descending form*/
            var studentname = Objstudent.OrderByDescending(x => x.Name);

            //foreach loop is used to print the name of the student  
            foreach (var student in studentname)
            {
                Console.WriteLine(student.Name);
            }
            Console.ReadLine();
        }
    }
    //create a class student  
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
    }
}
```

- **ThenBy Operator**  

```csharp
var studentname = Objstudent.OrderBy(x => x.Name).ThenBy(x => x.RoleId);  
```

- **ThenBy Descending Operator**  
```csharp
var studentname = Objstudent.OrderBy(x => x.Name).ThenByDescending(x => x.RoleId);  
```

### D). Partition Operator

- **Take Operator**  
In LINQ, Take Operator is used to get the specified number of elements in sequence from the list/collection.  
```csharp
IEnumerable<string> result = countries.Take(3);  
```

- **TakeWhile Operator**

```csharp
IEnumerable<string> result = countries.TakeWhile(x => x.StartsWith("U"));   
```

- **Skip Operator**

```csharp
IEnumerable<string> result = countries.Skip(3);  
```


### E). Conversion Operator

- **ToList() Method**

```csharp
List<string> result = countries.ToList();  
```
The demonstration by Code :  
```csharp
static void Main(string[] args)  
        {  
            string[] countries = { "US", "UK", "India", "Russia", "China", "Australia", "Argentina" };  
//used query syntax to convert the collection of the data into the list  
            List<string> result = (from x in countries select x).ToList();  
            foreach (string s in result)  
            {  
                Console.WriteLine(s);  
            }  
                Console.ReadLine();  
        }
```

- **ToArray() Method**

```csharp
string[] countryarray = countries.ToArray();   
```

The demonstration by Code :  
```csharp
static void Main(string[] args)  
        {  
            string[] countries = { "India", "China", "US", "Russia", "Argentina", "Australia", "UK" };  
//query syntax is used to convert the collection of data into the form of array  
            string[] countrArray = (from x in countries select x).ToArray();  
            foreach (string s in countrArray)  
            {  
                Console.WriteLine(s);  
            }  
                Console.ReadLine();  
        }  
```


- **ToLookup() Method**  
ToLookup operator in LINQ is an extension method, and it is used to extract a set of key/value pairs from the source. Lookup object holds the Key and subsequence items that matched with the Key.

```csharp
var Emp = objEmployee.ToLookup(x => x.Department);  
```

```csharp
using System;  
using System.Collections;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
//create an objEmployee of the class Employee and create a list of Employee  
            List<Employee> objEmployee = new List<Employee>()  
            {  
                new Employee(){ Name="Akshay Tyagi", Department="IT", Country="India"},  
                new Employee(){ Name="Vaishali Tyagi", Department="Marketing", Country="Australia"},  
                new Employee(){ Name="Arpita Rai", Department="HR", Country="China"},  
                new Employee(){ Name="Shubham Ratogi", Department="Sales", Country="USA"},  
                new Employee(){ Name="Himanshu Tyagi", Department="Operations", Country="Canada"}  
            };  
    //objEmployee.ToLookup() method is used to print the value of the data in the pair/collection of items.  
                var Emp = objEmployee.ToLookup(x => x.Department);  
                Console.WriteLine("Grouping Employees by Department");  
                Console.WriteLine("---------------------------------");  
                foreach (var KeyValurPair in Emp)  
                {  
                    Console.WriteLine(KeyValurPair.Key);  
                // Lookup employees by Department  
                foreach (var item in Emp[KeyValurPair.Key])  
                {  
                    Console.WriteLine("\t" + item.Name + "\t" + item.Department + "\t" + item.Country);  
                }  
          }  
                Console.ReadLine();  
    }  
}  
    class Employee  
    {  
        public string Name { get; set; }  
        public string Department { get; set; }  
        public string Country { get; set; }  
    }  
}
```

- **Cast() Method**
Cast operator is used to cast/convert all the elements present in a collection into a specified data type of new collection.

```csharp
IEnumerable<string> result = obj.Cast<string>();
```

- **OfType() Method**

```csharp
IEnumerable<string> result = obj.OfType<string>();  
```

```csharp
using System;  
using System. Collections;  
using System.Collections.Generic;  
using System.Linq;  
using System. Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
//Create an object of ArrayList and add the values  
            ArrayList obj = new ArrayList();  
            obj.Add("Australia");  
            obj.Add("India");  
            obj.Add("UK");  
            obj.Add("USA");  
            obj.Add(1);  
//ofType() method will return the value only the specific type  
            IEnumerable<string> result = obj.OfType<string>();  
    //foreach loop is applied to print the value of the item  
            foreach (var item in result)  
            {  
                Console.WriteLine(item);  
            }  
                Console.ReadLine();  
        }  
    }  
}  
```

- **AsEnumerable() Method**

```csharp
var result = numarray.AsEnumerable();  
```

- **ToDictionary() Method**

```csharp
var student = objStudent.ToDictionary(x => x.Id, x => x.Name);   
```

```csharp
using System;  
using System. Collections;  
using System.Collections.Generic;  
using System. Linq;  
using System. Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
//Create a object objStudent of Student class and add the information of student in the List  
            List<Student> objStudent = new List<Student>()  
            {  
                new Student() { Id=1,Name = "Vinay Tyagi", Gender = "Male",Location="Chennai" },  
                new Student() { Id=2,Name = "Vaishali Tyagi", Gender = "Female", Location="Chennai" },  
                new Student() { Id=3,Name = "Montu Tyagi", Gender = "Male",Location="Bangalore" },  
                new Student() { Id=4,Name = "Akshay Tyagi", Gender = "Male", Location ="Vizag"},  
                new Student() { Id=5,Name = "Arpita Rai", Gender = "Male", Location="Nagpur"}  
             };  
    /*here with the help of ToDictionary() method we are converting the colection  
    of information in the form of dictionary and will fetch only the required information*/  
                var student = objStudent.ToDictionary(x => x.Id, x => x.Name);  
    //foreach loop is used to print the information of the student  
                foreach (var stud in student)  
                {  
                    Console.WriteLine(stud.Key + "\t" + stud.Value);  
                }  
                Console.ReadLine();  
    }  
}  
        class Student  
        {  
            public int Id { get; set; }  
            public string Name { get; set; }  
            public string Gender { get; set; }  
            public string Location { get; set; }  
         }  
} 
```

### F). Element Operators

- **First() Element**
The First () method/operator is used to return the first element from the sequence of the items in the list or collection or the first element in the sequence of items in the list based on the specified condition. 

```csharp
int result = objList.First();   
```

- **FirstOrDefault() Method**
FirstOrDefault() Operator is same as LINQ First() Operator and the only difference is, in case if the lists returns no elements then LINQ FirstOrDefault operator method will return default value.

```csharp
int result = objList.FirstOrDefault();  
```

Here is the example of using the LINQ FirstOrDefault() operator in query syntax :  

```csharp
using System;  
using System. Collections;  
using System.Collections.Generic;  
using System. Linq;  
using System. Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Program1  
    {  
        static void Main(string[] args)  
        {  
  
  
            int[] ListOb = { 1, 2, 3, 4, 5 };  
  
            int[] ValOb = { };  
  
            int result = (from l in ListOb select l).FirstOrDefault();  
  
            int val = (from x in ValOb  
  
                       select x).FirstOrDefault();  
  
            Console.WriteLine("Element from the List1: {0}", result);  
  
            Console.WriteLine("Element from the List2: {0}", val);  
  
            Console.ReadLine();  
  
        }  
  
    }  
  
    }  

/* Output : Element from the List1: 1  
            Element from the List2: 0
*/
```

- **Last() Method**

```csharp
int result = objList.Last();  
```

- **LastOrDefault() Method**

```csharp
int result = ListObj.LastOrDefault();  
```
Example of using the LINQ LastOrDefault() operator in query syntax :

```csharp
using System;  
using System. Collections;  
using System.Collections.Generic;  
using System. Linq;  
using System. Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Program1  
    {  
        static void Main(string[] args)  
        {  
            int[] LISTOBJ = { 1, 2, 3, 4, 5 };  
            int[] ValObj = { };  
            int result = (from l in LISTOBJ select l).LastOrDefault();  
            int val = (from x in ValObj select x).LastOrDefault();  
            Console.WriteLine("Element from the List1: {0}", result);  
            Console.WriteLine("Element from the List2: {0}", val);  
            Console.ReadLine();  
        }  
    }  
}  
/*
Output : Element from the List1: 5
         Element from the List2: 0
*/
```

- **ElementAt() Method**
ElementAt() operator is used to return the elements from the list/collection based on the specified index.

```csharp
int result = objList.ElementAt(1);  
```

- **ElementAtOrDefault() Method**
If the specified index position of the element does not exist in the list, then in that case also this will return the default value.

```csharp
int result = objList.ElementAtOrDefault(1);  
```

- **Single() Method**
In LINQ, the Single() method is used to return the single element from the collection, which satisfies the condition. In case, if the Single() method found more than one element in collection or no element in the collection, then it will throw the "InvalidOperationException" error.

```csharp
int a = objList.Single(); 
```

Here is the example of the LINQ Single () method to get a single element from the collection.
```csharp
using System;  
using System. Collections;  
using System.Collections.Generic;  
using System. Linq;  
using System. Text;  
using System.Threading.Tasks;  
  
namespace ConsoleApp1  
{  
    class Programme2  
    {  
        static void Main(string[] args)  
        {  
//create an object objStudent of the class Student added the record to the list.  
            List<Student> objStudent = new List<Student>()  
            {  
                new Student() { Name = "Shubham Rastogi", Gender = "Male",Location="Chennai" },  
                new Student() { Name = "Rohini Tyagi", Gender = "Female", Location="Chennai" },  
                new Student() { Name = "Praveen Alavala", Gender = "Male",Location="Bangalore" },  
                new Student() { Name = "Sateesh Rastogi", Gender = "Male", Location ="Vizag"},  
                new Student() { Name = "Madhav Sai", Gender = "Male", Location="Nagpur"}  
            };  
    //initialize the array objList  
                int[] objList = { 1 };  
    //objStudent.Single() used to select the student  
                var user = objStudent.Single(s => s.Name == "Shubham Rastogi");  
                string result = user.Name;  
                int val = objList.Single();  
                Console.WriteLine("Element from objStudent: {0}", result);  
                Console.WriteLine("Element from objList: {0}", val);  
                Console.ReadLine();  
        }  
    }  
        class Student  
        {  
           public string Name { get; set; }  
           public string Gender { get; set; }  
           public string Location { get; set; }  
        }  
}
/*Output :
Element from objStudent: Shubham Rastogi
Element from objList: 1
*/
```

- **SingleOrDefault Method**

```csharp
int a = objList.SingleOrDefault(); 
```
If there are no elements present in the list/collection, then this will return more than one element and will throw an exception like a Single () method.

```csharp
// initialize the array 'vs' from 1 to 5  
int[] vs = { 1, 2, 3, 4, 5 };  

// objStudent.SingleOrDefault() method will return the information of the student  
var user = objStudent.SingleOrDefault(i => i.Name == "Akshay Tyagi");  

string result = user.Name;  
int val = vs.SingleOrDefault(j => j > 5);  
```

The LINQ SingleOrDefault() method will throw the InvalidOperationException error in case if the list/collection returns more than one element.

```csharp
// initialize the objList array from 1 to 5  
int[] objList = { 1, 2, 3, 4, 5 };  

// here SingleOrDefault()method will return the default value  
int val = objList.SingleOrDefault();  
```

- **DefaultfEmpty() Method**

```csharp
var result = List1.DefaultIfEmpty();  
```

### G). Grouping Operators

- **GroupBy() Method**

```csharp
var student1 = objStudent.GroupBy(x => x.Location);  
```

Example: Group employees by department
```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", Department = "HR" },
            new Employee { Id = 2, Name = "Bob", Department = "Finance" },
            new Employee { Id = 3, Name = "Charlie", Department = "HR" },
            new Employee { Id = 4, Name = "David", Department = "IT" },
            new Employee { Id = 5, Name = "Eve", Department = "Finance" }
        };

        var groupedEmployees = employees.GroupBy(e => e.Department);

        foreach (var group in groupedEmployees)
        {
            Console.WriteLine($"Department: {group.Key}");
            foreach (var employee in group)
            {
                Console.WriteLine($" - {employee.Name}");
            }
        }
    }
}

/* Output :
Department: HR
 - Alice
 - Charlie
Department: Finance
 - Bob
 - Eve
Department: IT
 - David
*/ 
```

### H). Join Operators

- **Inner Join**

```csharp
var result = from item1 in collection1
             join item2 in collection2
             on item1.Property equals item2.Property
             select new
             {
                 Property1 = item1.SomeProperty,
                 Property2 = item2.AnotherProperty
             };
```

```csharp
using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}

public class Department
{
    public int Id { get; set; }
    public string DepartmentName { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", DepartmentId = 1 },
            new Employee { Id = 2, Name = "Bob", DepartmentId = 2 },
            new Employee { Id = 3, Name = "Charlie", DepartmentId = 1 },
            new Employee { Id = 4, Name = "David", DepartmentId = 3 },
            new Employee { Id = 5, Name = "Eve", DepartmentId = 4 }  // No matching department
        };

        List<Department> departments = new List<Department>
        {
            new Department { Id = 1, DepartmentName = "HR" },
            new Department { Id = 2, DepartmentName = "Finance" },
            new Department { Id = 3, DepartmentName = "IT" }
        };

        var employeeDepartments = employees.Join(
            departments,                       // Second collection
            e => e.DepartmentId,               // Key from the first collection (employees)
            d => d.Id,                         // Key from the second collection (departments)
            (e, d) => new                      // Result selector
            {
                EmployeeName = e.Name,
                DepartmentName = d.DepartmentName
            }
        );

        foreach (var item in employeeDepartments)
        {
            Console.WriteLine($"{item.EmployeeName} works in {item.DepartmentName} department.");
        }
    }
}
/* Output :
Alice works in HR department.
Bob works in Finance department.
Charlie works in HR department.
David works in IT department.
*/
```

- **Left Join**

In LINQ, LEFT JOIN or LEFT OUTER JOIN is used to return all the records or elements from the left side collection and matching the elements from the right side of the collection.

Syntax of LINQ Left Outer Join : 
```csharp
var result = from e in objEmp1  
join d in objDept1  
on e.DeptId equals d.DepId into empDept  
from ed in empDept.DefaultIfEmpty()  
select new  
{  
    EmployeeName = e.Name,  
    DepartmentName = ed == null ? "No Department" : ed.DepName  
}  
```

- **Cross Join**

In LINQ Cross join, each element on the left side collection will be mapped to all the elements on the right side collection.
```csharp
var result = from e in objEmp1  
from d in objDept1  
select new  
{  
    EmployeeName = e.Name,  
    DepartmentName = d.DepName  
};   
```

- **Group Join**

In LINQ, Group join produces a sequence of the elements of the objects, which is based on the matching element from both left and right collections.

Syntax of LINQ Group Join
```csharp
var result = from d in objDept  
join e in objEmp on d.DepId equals e.DeptId into empDept  
select new  
{  
    DepartmentName = d.DepName,  
    Employees = from emp2 in empDept  
    orderby emp2.Name  
     select emp2  
};  
```

### I). Set Operations

- **Union Method**

```csharp
var result = count1.Union(count2);   
```

Here is the example of using the LINQ Union Method.
```csharp
class Programme2  
    {  
        static void Main(string[] args)  
        {  
//create array count1 and count2 of type string  
            string[] count1 = { "India", "USA", "UK", "Australia" };  
            string[] count2 = { "India", "Canada", "UK", "China" };  
//count1.Union(count2) is used to find out the unique element from both the collection  
            var result = count1.Union(count2);  
//foreach loop is used to print the output conaining in the result  
            foreach (var item in result)  
            {  
                Console.WriteLine(item);  
            }  
                Console.ReadLine();  
        }  
    }
```

- **Intersect Method**

LINQ Intersect method will combine both the collections into a single collection and return only the matching element from the collection.

```csharp
var result = count1.Intersect(count2);  
```

```csharp
class Programme2  
    {  
        static void Main(string[] args)  
        {  
//declare the two array variable count1 and count2 of the type string   
            string[] count1 = { "India", "Australia", "UK", "USA" };  
            string[] count2 = { "India", "China", "UK", "China" };  
/*apply the Intersect method on both of the array 
 count1 and count2 and store the output in result variable*/  
            var result = count1.Intersect(count2);  
/*foreach loop will iterate over all the element of  
the variable item which store the output of the result variable*/   
            foreach (var item in result)  
            {  
/*Console.WriteLine(item) print  
all element store in the item variable.*/  
                Console.WriteLine(item);  
            }  
                Console.ReadLine();  
        }
     }
```

- **Distinct Method**

The LINQ Distinct method or operator is used to get only the distinct elements from the collection.
```csharp
IEnumerable<int> result = numbers.Distinct();  
```

```csharp
    class Programme2  
    {  
        static void Main(string[] args)  
        {  
//taking an array named countries type of string having the list of countries   
            string[] countries = { "UK", "India", "Australia", "uk", "india", "USA" };  
//apply the Distinct method to find out the different country names   
            IEnumerable<string> result = countries.Distinct(StringComparer.OrdinalIgnoreCase);  
    //with the help of foreach loop fetch each element from the list of the array  
            foreach (var item in result)  
            {  
    /*with the help of WriteLine() function print the values of  
    the variable item having the output of the result*/   
                Console.WriteLine(item);  
            }  
                Console.ReadLine();  
        }  
  
    }
```

- **Except Method**

In LINQ, the Except method or operator is used to return only the elements from the first collection, which are not present in the second collection.
```csharp
var result = arr1.Except(arr2);   
```

```csharp
class Programme2  
    {  
        static void Main(string[] args)  
        {  
//create an array 'a' and 'b' type of string having the values  
            string[] a = { "Rohini", "Suresh", "Sateesh", "Praveen" };  
            string[] b = { "Madhav", "Sushmitha", "Sateesh", "Praveen" };  
//Except method is used to return the value which does not exist in the second list   
            var result = a.Except(b);  
            foreach (var item in result)  
            {  
                Console.WriteLine(item);  
            }  
                Console.ReadLine();  
        }  
    }

// Output :
// Rohini
// Suresh
```

### J). Equality Operations

- **SequenceEqual Method**

In LINQ, the SequenceEqual method is used to compare the sequence of two collections that are equal or not. It determines two sequences whether they are equal or not by comparing the elements in a pair-wise manner, and two sequences contain the equality number of the element or not.

### K). Concat Operations

- **Concat Method**

In LINQ, the Concat method or operator is used to concatenate or append the two collection elements into a single collection, and it does not remove the duplicates from two sequences.

### L). Generations Operations

- **Range Method**

```csharp
IEnumerable<int> obj = Enumerable.Range(100, 10); 
```

- **Repeat Method**

```csharp
IEnumerable<int> obj = Enumerable.Repeat(100, 10);
```

- **Empty Method**

```csharp
var result1 = Enumerable.Empty<int>();   
```


### M). LINQ with Objects

- **LINQ to Objects**

In LINQ, if we use "LINQ to Objects" in our applications, it will give us a chance to use IEnumerable or IEnumerable<T> collections directly in LINQ queries, without the use of any intermediate LINQ provider or API such as LINQ to SQL, or LINQ to XML. 

- **LINQ to Strings**

```csharp
var result = from s in str.ToLowerInvariant().Split()
```

- **LINQ to String Array**

```csharp
IEnumerable<string> result = from a in arr  
    select a;  
```

```csharp
class Programme2  
    {  
        static void Main(string[] args)  
        {  
//create an array of type string  
            string[] array = { "Vaishali", "Shalu", "Akshay", "Akki" };  
/*IEnumerable will iterate over the collection of data use  
Linq query to select the particular element which starts from s*/  
            IEnumerable<string> result = from a in array  
            where a.ToLowerInvariant().StartsWith("s")  
            select a;  
    //foreach loop is used to print the output which is in the result  
            foreach (string item in result)  
            {  
                Console.WriteLine(item);  
            }  
                Console.ReadLine();  
         }  
    } 
```

- **LINQ to Int Array**

The syntax of writing the LINQ queries on integer arrays to get the required elements from array collection.

```csharp
class Programme2  
    {  
        static void Main(string[] args)  
        {  
//create an array numarray of type int  
            int[] numarray = { 1, 6, 9, 10, 50, 60, 100, 200, 300 };  
/*write LINQ query to get hte data from the  
numarray where the value is greater than 10 and less than 200*/  
            IEnumerable<int> result = from a in numarray  
            where a > 10 && a < 200  
            select a;  
            foreach (int item in result)  
            {  
                Console.WriteLine(item);  
            }  
                Console.ReadLine();  
        }
```

- **LINQ to Lists/Collection**

Here is the syntax of writing the LINQ queries on the list or collection to get the required elements.  

```csharp
var result = from e in objEmp  
select new  
{  
   Name = e.Name,  
  Location = e.Location  
};   
```


### N). LINQ with SQL

- **LINQ to SQL**

The LINQ to SQL is the component of .NET Framework version 3.5. It provides the run time infrastructure to manage the relational data as objects.

It allows us to access and get the data from the SQL database with LINQ queries. It allows us to perform the select, insert, update, and delete operations on tables like SQL using the LINQ Query.

- **LINQ to SQL Select Query**

```csharp
EmployeeDBDataContext db = new EmployeeDBDataContext();  
var result = from ed in db.EmployeeDetails  
select new  
{  
     EmployeeName = ed.EmpName,  
     Location = ed.Location  
};
```

- **LINQ to SQL Inner Join**

```csharp
var result = from ed in db.EmployeeDetails  
join d in db.Departments on ed.DeptId equals d.DeptId  
select new   
{  
Name = ed.EmpName,  
Department = d.DeptName  
};  
```

- **LINQ to SQL Group Join**

```csharp
var result = from ed in db.EmployeeDetails  
join d in db. Departments on ed.DeptId equals d.DeptId into edept  
from dpem in edept  
select new  
{  
Name = ed.EmpName,  
Department = dpem.DeptName  
};   
```

- **LINQ to SQL CRUD Operations**

**LINQ to SQL Insert Operations**  
```csharp
EmployeeDBDataContext db = new EmployeeDBDataContext();  
EmployeeDetail emp = new EmployeeDetail();  
emp.EmpName = txtname.Text;  
emp.Location = txtlocation.Text;  
db.EmployeeDetails.InsertOnSubmit(emp);  
db.SubmitChanges();  
```

**LINQ to SQL Update Operations**
```csharp
EmployeeDBDataContext db = new EmployeeDBDataContext();  
EmployeeDetail emp = new EmployeeDetail();  
emp = db.EmployeeDetails.Single(x => x.EmpId == empid);  
emp.EmpName = txtname.Text;  
emp.Location = txtlocation.Text;  
emp.Gender = txtgender.Text;  
db.SubmitChanges();  
```

**LINQ to SQL Delete Operations**
```csharp
EmployeeDBDataContext db = new EmployeeDBDataContext();  
EmployeeDetail emp = new EmployeeDetail();  
emp = db.EmployeeDetails.Single(x => x.EmpId == empid);  
db.EmployeeDetails.DeleteOnSubmit(emp);  
db.SubmitChanges();  
```










