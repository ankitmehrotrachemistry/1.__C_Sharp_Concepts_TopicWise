## Advanced C# Concepts

▶️ [Advanced C# Topics](https://www.youtube.com/watch?v=VT9ueWBqquU&list=PLwhVruPHD9ryiH4kN0EHYeXQXIOHLBcJX&index=1)

**Q-1. Abstract Classes.**  

- Abstract methods do not have an implementation.  
- Abstract methods are implicitly virtual.  
- If a class has abstract methods it must be declared abstract itself.  
- One cannot create objects of an abstract class.  

Abstract classes have the following features:

- An abstract class cannot be instantiated.
- An abstract class may contain abstract methods and accessors.
- It is not possible to modify an abstract class with the sealed modifier, which means that the class cannot be inherited.
- A non-abstract class derived from an abstract class must include actual implementations of all inherited abstract methods and accessors.

**Q-2. Interface.**  

- Interface = purely abstract class; only signatures, no implementation.
- Interface members must not be static.
- Every interface member (method, property, indexer) must be implemented or inherited from a base class.
- Implemented interface methods must not be declared as override.
- Implemented interface methods can be declared virtual or abstract (i.e. an interface can be implemented by an abstract class).

**Q-3. Difference between IEnumerable, IQueryable.**  

[The difference between IEnumerable and IQueryable: An Overview](https://www.scholarhat.com/tutorial/linq/ienumerable-vs-iqueryable)  
The main difference between IEnumerable and IQueryable lies in their handling of data. IEnumerable is suitable for in-memory collections and supports simple iteration, while IQueryable extends this capability for composing queries against remote data sources, offering deferred execution.
IEnumerable is slower than IQueryable because IQueryable allows for query optimizations and lazy loading, whereas IEnumerable does not support query optimizations and lazy loading. IEnumerable needs the query execution to happen entirely on the client side.  

▶️ [When to use IEnumerable vs IQueryable?](https://www.youtube.com/watch?v=J2u1DmnE9mU)  

![image](https://github.com/user-attachments/assets/53597d28-e0fb-4408-90f8-6cb86553f8fc)

![image](https://github.com/user-attachments/assets/ac07012b-da7d-44cf-a31a-25d3673898a5)

**Q-4. Can we create object of abstract class and Interface? Why or Why not?** 

[Why can't an object of abstract class be created?](https://stackoverflow.com/questions/2700256/why-cant-an-object-of-abstract-class-be-created)  

**Reason 1 :**  
If we have a class containing pure virtual function then the class is abstract. If we will create an object of the abstract class and calls the method having no body(as the method is pure virtual) it will give an error. That is why we cant create object of abstract class.  

**Reason 2 :**  
We cannot create object for abstract class bcoz ,mostly abstract class contain "abstract methods" ,so abstract methods are incomplete methods.so we cannot estimate the memory of those methods how much they are going to occupy .This is one of the reason why we cannot create object for abstract class.  

**Reason 3 :**  
Actually when we create an object of a normal class we use Constructor to allocate the memory for that object like   

```csharp
myclass obj=new myclass();
```

Here using constructor clr identifies how much memory the object needed depending upon the instance variabless and methods. But in case of abstract classes we cant predict the amount of memory required as we dont implement the abstract methods so its not possible to create object.  

**Q-5. Why C# don't support multiple inheritance?**   

[Why C# does not support multiple inheritances](https://medium.com/@kamaleshs48/why-c-does-not-support-multiple-inheritances-83904ba4874f)  

C# does not support multiple inheritance because it can lead to ambiguity and complexity.  

**Ambiguity:-** Ambiguity can occur when a child class inherits from two parent classes that have the same method or property with the same name. In this case, the compiler would not know which method or property to use. (Diamond Problem)  
**Complexity:-** Complexity can occur when a child class inherits from multiple parent classes with a large number of methods and properties. This can make it difficult to track the code and understand how the child's class works.  

![image](https://github.com/user-attachments/assets/c4f25fa7-0d34-4e34-9aa4-8ce748c56abd)

**Q-6. Difference between an abstract class and an interface**  

| Abstract Class | Interface | 
|----------|----------|
| Surprisingly, abstract classes can have both abstract and non-abstract methods. | All the methods of an interface are abstract methods. |
| Since abstract classes can have both abstract and non-abstract methods, we need to use the Abstract keyword to declare abstract methods. | But in the interface, there is no such need. |
| An abstract class has constructors. | An interface has no constructors.  |

**Q-7. StringBuilder Class. What is the difference between String and StringBuilder in C#?**  
[StringBuilder in C#](https://www.geeksforgeeks.org/stringbuilder-in-c-sharp/)  

StringBuilder is a dynamic object. It doesn’t create a new object in the memory but dynamically expands the needed memory to accommodate the modified or new string.

| String | StringBuilder | 
|----------|----------|
| String objects are immutable. | StringBuilder creates a mutable string of characters. StringBuilder will make the changes to the existing object rather than creating a new object. |
| Since the String class is immutable, it is costlier to create a new object every time we need to make a change. | StringBuilder class comes into picture which can be evoked using the System.Text namespace. |

In case, a string object will not change throughout the entire program, then use String class or else StringBuilder. 

For ex:

```csharp
string s = string.Empty; 
for (i = 0; i < 1000; i++) 
  { 
    s += i.ToString() + " "; 
  }
```
Here, you’ll need to create 2001 objects out of which 2000 will be of no use.

The same can be applied using StringBuilder:

```csharp
StringBuilder sb = new StringBuilder(); 
for (i = 0; i < 1000; i++) 
 { 
   sb.Append(i); sb.Append(' '); 
 }
```

By using StringBuilder here, you also de-stress the memory allocator.  

**Q-8. Difference between an Array and ArrayList** 

| Array | ArrayList | 
|----------|----------|
| An array is a collection of similar variables clubbed together under one common name. | ArrayList is a collection of objects that can be indexed individually. |
| An Array cannot access a number of features like dynamic memory allocation, adding, searching | ArrayList you can access a number of features like dynamic memory allocation, adding, searching, and sorting items in the ArrayList.  |
| When declaring an array the size of the items is fixed therefore, the memory allocation is fixed. | With ArrayList, it can be increased or decreased dynamically. |
| Array belongs to system.array namespace. | ArrayList belongs to the system.collection namespace. |
| All items in an array are of the same datatype. | All the items in an ArrayList can be of the same or different data types. |
| Arrays cannot accept null. | ArrayList can accept null values. |
 
**Q-9. Structure and Class**

A class can inherit from a single base class, but implement multiple interfaces.
A struct cannot inherit from any type, but can implement multiple interfaces.

**Q-10. Static Constructor.**  

[Static Constructor In C# And Its Usages](https://www.c-sharpcorner.com/article/static-constructor-in-C-Sharp-and-their-usages/)  
Some important point regarding static constructor from C# Language Specification and C# Programmer's Reference :  
- The static constructor for a class executes before any instance of the class is created.
- The static constructor for a class executes before any of the static members for the class are referenced.
- The static constructor for a class executes after the static field initializers (if any) for the class.
- The static constructor for a class executes at most one time during a single program instantiation
- A static constructor does not take access modifiers or have parameters.
- A static constructor is called automatically to initialize the class before the first instance is created or any static members are referenced.
- A static constructor cannot be called directly.
- The user has no control on when the static constructor is executed in the program.
- A typical use of static constructors is when the class is using a log file and the constructor is used to write entries to this file.

**Q-10. Private Constructor. Private Constructor vs Sealed Class in C#**  

| Private Constructor | Sealed Class | 
|----------|----------|
| A private constructor doesn't allow instancing (you can instance a sealed class).  | A sealed class doesn't allow inheritance. That is, you can't derive from it. |
| When you get deeper into the language, private constructors can be used in scenarios where you're overloading constructors.  | A sealed class cannot be used as a base class. For this reason, it also cannot be an abstract class. |
| In private Class: We can create a constructor and therefore we can create an instance of that class.  | But In Sealed class we can not create a constructor of that class, so no instance of that class is possible. |
| Private Constructor of a Private Class = Sealed Class.  | you can create a constructor of a sealed class.  |
| A private constructor prevents both inheritance and instantiation. You should use a private constructor if you wish to use a method to create instances of other classes.  |  Sealed allows you to prevent inheritance but still created instances of a class. |

**Q-11. Singleton vs Static Class**  

[Singleton vs Static Class](https://henriquesd.medium.com/singleton-vs-static-class-e6b2b32ec331)  

**Similarities between Singleton and Static :**  
- Both Static and Singleton classes can have only one instance available in the memory.
- Both classes can be used for holding the global state of an application.

**Differences between Singleton and Static :**
- A Singleton class supports interface implementation, while static classes cannot implement interfaces.
- A Singleton class supports inheritance, while a Static class is a sealed class, and therefore cannot be inherited.
- A Singleton class can inherit from other classes, while a Static class cannot (not even from other static classes).
- A Singleton class can be instantiated using the new keyword, while static can not be instantiated (static class can be used directly).
- Both Singleton and static are stored on the Heap memory, but static classes are stored in a special area of the Heap Memory called the High-Frequency Heap (Objects in High Frequency Heap are not garbage collected by GC, and hence static members are available throughout the application lifetime).
- A Singleton class can Dispose, while a static class can not.
- A Singleton class can have a constructor, while a static class can only have a private static parameterless constructor and cannot have instance constructors.
- A Static class has better performance since static methods are bonded on compile time.
- A Singleton class can be lazy loaded when needed, while static classes are always loaded. Static classes are loaded automatically by the .NET Framework common language runtime (CLR) when the program or namespace containing the class is loaded.

**Q-12. Why there is no need to create object of Static Class?**  
- Static classes do not contain any instance member properties or functions. So to make an instance would be pointless.  
- When we make class as static, Compiler gives guaranty that instance of this class (Static class) can not be created. therefore the methods are not associated with particular object of class in code.  
- Static class can not contains instance constructor But it can contain static constructor which does not takes the access modifiers. Static constructors is called automatically to initialize the class before the first instance is created.  
- Static class are sealed classes and therefore can not be inherited.  
- You can access the static members using the type name instead of reference.

[How to create object of static class ?](https://www.codeproject.com/Questions/452249/How-to-create-object-of-static-class)  

**Q-13. What are partial classes in C#?**  
Partial classes implement the functionality of a single class into multiple files. These multiple files are combined into one during compile time. The partial class can be created using the partial keyword. 
```csharp
public partial Clas_name  
{
       // code
}
```
You can easily split the functionalities of methods, interfaces, or structures into multiple files. You can even add nested partial classes. 

**Q-14. Uniform type system (boxing / unboxing)**  
**Boxing:** Boxing converts value type (int, char, etc.) to reference type (object) which is an implicit conversion process using object value. 

```csharp
int num = 23; // 23 will assigned to num
Object Obj = num; // Boxing
```

**Unboxing:** Unboxing converts reference type (object) to value type (int, char, etc.) using an explicit conversion process.  

```csharp
int num = 23;         // value type is int and assigned value 23
Object Obj = num;    // Boxing
int i = (int)Obj;    // Unboxing
```

**Q-15. Generics/Generic Classes**  
- Generic means the general form, not specific. In C#, generic means not specific to a particular data type.
- A generic type is declared by specifying a type parameter in an angle brackets after a type name, e.g. TypeName<T> where T is a type parameter.

Advantages of Generics
- Generics increase the reusability of the code. You don't need to write code to handle different data types.
- Generics are type-safe. You get compile-time errors if you try to use a different data type than the one specified in the definition.
- Generic has a performance advantage because it removes the possibilities of boxing and unboxing.

**Q-16. What are Properties in C#?**
- Properties in C# are public members of a class where they provide the ability to access private members of a class.
- The basic principle of encapsulation lets you hide some sensitive properties from the users by making the variables private.
- The private members are not accessible otherwise in a class.
- Therefore, by using properties in C# you can easily access the private members and set their values.
- The values can be easily assigned using get and set methods, also known as accessors. While the get method extracts the value, the set method assigns the value to the variables.

**Q-17. What are Extension Methods?**  
- Extension methods help to add new methods to the existing ones.
- The methods that are added are static.
- At times, when you want to add methods to an existing class but don’t perceive the right to modify that class or don’t hold the rights, you can create a new static class containing the new methods.
- Once the extended methods are declared, bind this class with the existing one and see the methods will be added to the existing one.
- It is introduced in C# 3.0.

**Q-18. List vs Dictionary**

**Q-19. Delegates**  
- A delegate is a reference type variable that holds the reference to a method. The reference can be changed at runtime.
- A delegate can be passed as a method parameter.
- = operator is used to assigning a single method, and += operator is used to assign multiple methods to a delegate.
- In C#, a delegate is a type that represents references to methods with a particular parameter list and return type. When you instantiate a delegate, you can associate its instance with any method that has a compatible signature and return type. You can then invoke the method through the delegate instance.

Delegates are primarily used for:  
1.Event handling: This is the most common use case. Windows Forms, WPF, and many other frameworks use delegates for event handling.  
2.Callback methods: They allow a method to call another method.  
3.Linq and Lambda Expressions: They often use delegates to represent inline anonymous functions.  
4. Asynchronous programming: They were historically used for Begininvoke and Endinvoke in asynchronous operations, though async and await are now more common.  

**Q-20. Func and Action Delegates**  
The Func delegate is another predefined delegate type that represents a method with zero or more input parameters that returns a value. Unlike the Action delegate, the return type of a Func delegate can be any type.  
The Action delegate is a predefined delegate type that encapsulates a method with zero or more input parameters that doesn't return a value. In other words, an Action delegate represents a void-returning method.  

[Action and Func Delegates in C# – Explained with Examples](https://www.freecodecamp.org/news/action-and-func-delegates-in-c-sharp/)

The main difference between Func and Action lies in their return types. The Func delegate allows you to specify a return type, whereas the Action delegate does not return a value. Both delegates can have up to 16 parameters.  
**Example:**  
```csharp
Func<int, int, int> sumFunc = (a, b) => a + b;
int result = sumFunc(3, 4);  // result = 7
```

In below example, we define an Action delegate that takes a string parameter. We assign a lambda expression to the delegate, which writes a greeting message to the console.  
```csharp
Action<string> greetAction = name => Console.WriteLine($"Hello, name!");
greetAction("John");  // Output: Hello, John!
```

[Introduction to Func and Action Delegates](https://medium.com/@interviewer.live/func-and-action-in-c-a-complete-guide-dfe8cf31581c)

**Q-21. Tuples**  
A tuple is a data structure that contains a sequence of elements of different data types. It can be used where you want to have a data structure to hold an object with properties, but you don't want to create a separate type for it.

[C# - Tuple](https://www.tutorialsteacher.com/csharp/csharp-tuple)  

**Syntax**  
```csharp
Tuple<T1, T2, T3, T4, T5, T6, T7, TRest>
```

The following example creates a tuple with three elements:

```csharp
Tuple<int, string, string> person = new Tuple <int, string, string>(1, "Steve", "Jobs");
```

**Usage of Tuple**  
Tuples can be used in the following scenarios:  
- When you want to return multiple values from a method without using ref or out parameters.
- When you want to pass multiple values to a method through a single parameter.
- When you want to hold a database record or some values temporarily without creating a separate class.

**Tuple Limitations:**  
- The Tuple is a reference type and not a value type. It allocates on heap and could result in CPU intensive operations.
- The Tuple is limited to include eight elements. You need to use nested tuples if you need to store more elements. However, this may result in ambiguity.

**Q-22. is and as operators**  

**is operator:**    
The 'is' operator in the C# programming language is used to check for compatibility of the runtime type of an object with a given type. If it is compatible, the expression evaluates to true, false otherwise.  
Here are the characteristics of the is operator in C#:  
- The is operator is used to check if the run-time type of an expression result is compatible with a given type.
- When an is operator is used, the expression either evaluates to true if the types are the same, or false if the types differ.
- The is operator is used only for boxing, unboxing, and reference conversions.

**as operator:**  
The as operator in C# allows you to explicitly convert the result of an expression to a given reference type or a nullable value type. If the conversion isn’t possible, as returns null.  
Here are the characteristics of the as operator in C#:  
- The as operator is used when you need to convert compatible reference types of nullable types.
- When the as operator is used, the expression on the right-hand side of the assignment operator doesn’t evaluate to a boolean value.
- When the as operator is used, the expression returns the object if the objects are compatible and returns null if no conversion if possible.
- You can use the as operator only for boxing, reference, and nullable conversions.

 [How to use the is and as operators in C#](https://www.infoworld.com/article/2338756/how-to-use-the-is-and-as-operators-in-c-sharp.html) 

**Q-23. ref and out parameters**  
The out and ref keywords are useful when we want to return a value in the same variables that are passed as an argument. 

**ref keyword**  
C# ref keywords pass arguments by reference and not value.  

```csharp
void Method(ref int refArgument)
{
   refArgument = refArgument + 10;
}
int number = 1;
Method(ref number);
Console.WriteLine(number);
// Output: 11
```

**out keyword**  
- C# out keywords pass arguments within methods and functions.
- ‘out’ keyword is used to pass arguments in a method as a reference to return multiple values.
- Although it is the same as the ref keyword, the out keyword needs to be initialised before it is passed.  

```csharp
public static string GetNextFeature(ref int id)  
{  
   string returnText = "Next-" + id.ToString();  
   id += 1;  
   return returnText;  
}  
public static string GetNextFeature(out int id)  
{  
   id = 1;  
   string returnText = "Next-" + id.ToString();  
   return returnText;  
}
```

**Q-24. constant and readonly**  

**Const**
A const keyword in C# is used to declare a constant field throughout the program. That means once a variable has been declared const, its value cannot be changed throughout the program. 
In C#, a constant is a number, string, null reference, or boolean values. 

**Readonly**
With readonly keyword, you can assign the variable only when it is declared or in a constructor of the same class in which it is declared. 

```csharp
public readonly int xvar1;
   public readonly int yvar2;
 
   // Values of the readonly variables are assigned Using constructor
   public IB(int b, int c)
   {
 
       xvar1 = b;
       yvar2 = c;
       Console.WriteLine("The value of xvar1 {0}, "+
                       "and yvar2 {1}", xvar1, yvar2);
   }
 
   // Main method
   static public void Main()
   {
     IB obj1 = new IB(50, 60);
   }
}

Output:
The value of xvar1 is 50, and yvar2 is 60
```

**Q-25. Anonymous Types**  

**Q-26. Indexers**  
Indexers are called smart arrays that allow access to a member variable. Indexers allow member variables using the features of an array. They are created using the Indexer keyword. Indexers are not static members.  

For ex. Here the indexer is defined the same way.  

```csharp
<return type> this[<parameter type> index]
{
   get{
       // return the value from the specified index of an internal collection
   }
   set{
       // set values at the specified index in an internal collection
   }
}
```

**Q-27. Reflections**  
Reflection in C# extracts metadata from the datatypes during runtime. 

To add reflection in the .NET framework, simply use System.Refelction namespace in your program to retrieve the type which can be anything from:

- Assembly
- Module
- Enum
- MethodInfo
- ConstructorInfo
- MemberInfo
- ParameterInfo
- Type
- FieldInfo
- EventInfo
- PropertyInfo

**Q-28. Attributes**  
Attributes are a form of metadata that you can apply to various program entities such as types, methods, properties, and more.  
To apply an attribute to an element, use square brackets.  

C# provides a variety of built-in attributes that offer powerful functionalities:  

- [Obsolete]: Marks code as deprecated.
- [Serializable]: Indicates that a class can be serialized.
- [Conditional]: Controls conditional compilation based on specified symbols.
- [DllImport]: Specifies a method to be imported from a dynamic link library (DLL).
- [Serializable]: Marks a class as serializable.
- [Serializable]: Marks a field as serializable.

[Mastering C# Attributes: A Comprehensive Guide from Basics to Advanced](https://medium.com/@lexitrainerph/mastering-c-attributes-a-comprehensive-guide-from-basics-to-advanced-38322b54dd98)

**Q-29. SOLID Principles**

![image](https://github.com/user-attachments/assets/4b28e602-24a5-493a-875c-8a9d9a40b3b7)

The 𝗦𝗢𝗟𝗜𝗗 acronym stands for the following:  

✅ 𝗦𝗶𝗻𝗴𝗹𝗲 𝗥𝗲𝘀𝗽𝗼𝗻𝘀𝗶𝗯𝗶𝗹𝗶𝘁𝘆 𝗣𝗿𝗶𝗻𝗰𝗶𝗽𝗹𝗲 (𝗦𝗥𝗣): A class should have only one reason to change, meaning it should have only one responsibility or job.  

✅ 𝗢𝗽𝗲𝗻-𝗖𝗹𝗼𝘀𝗲𝗱 𝗣𝗿𝗶𝗻𝗰𝗶𝗽𝗹𝗲 (𝗢𝗖𝗣): Entities should be open for extension but closed for modification, allowing new functionality to be added without altering existing code.  

✅ 𝗟𝗶𝘀𝗸𝗼𝘃 𝗦𝘂𝗯𝘀𝘁𝗶𝘁𝘂𝘁𝗶𝗼𝗻 𝗣𝗿𝗶𝗻𝗰𝗶𝗽𝗹𝗲 (𝗟𝗦𝗣): Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. This ensures that a subclass can stand in for its superclass.  

✅ 𝗜𝗻𝘁𝗲𝗿𝗳𝗮𝗰𝗲 𝗦𝗲𝗴𝗿𝗲𝗴𝗮𝘁𝗶𝗼𝗻 𝗣𝗿𝗶𝗻𝗰𝗶𝗽𝗹𝗲 (𝗜𝗦𝗣): Clients should not be forced to depend on interfaces they do not use. It’s preferable to have multiple small, specific interfaces instead of one large, general-purpose interface.  

✅ 𝗗𝗲𝗽𝗲𝗻𝗱𝗲𝗻𝗰𝘆 𝗜𝗻𝘃𝗲𝗿𝘀𝗶𝗼𝗻 𝗣𝗿𝗶𝗻𝗰𝗶𝗽𝗹𝗲 (𝗗𝗜𝗣): High-level modules should not depend on low-level modules; both should depend on abstractions. This principle encourages the use of interfaces and abstract classes to reduce coupling.  

**Q-29. Memory Allocation in C#**


**Q-30. Managed and Unmanaged code**
| Managed Code | Unmanaged Code | 
|----------|----------|
| Managed code lets you run the code on a managed CLR runtime environment in the .NET framework. | Unmanaged code is when the code doesn’t run on CLR, it is an unmanaged code that works outside the .NET framework.  |
| Managed code runs on the managed runtime environment than the operating system itself.  | They don’t provide services of the high-level languages and therefore, run without them.  |
| Benefits: Provides various services like a garbage collector, exception handling, etc. | Such an example is C++. |

**Q-31. What is Common Language Runtime (CLR)?**  
CLR handles program execution for various languages including C#. The Common Language Runtime (CLR) is a core component of . NET Framework that manages the execution and the lifecycle of all . NET applications (code). It provides various services, including automatic memory management, exception handling, security, and type safety.

![image](https://github.com/user-attachments/assets/a19e6a6a-a38e-4aa5-9802-b5145eaa9fb2)

**Q-32. Difference between late binding and early binding**  

**Q-33. C# Profiling**

**Q-34. What is garbage collection in C#?**  
Garbage collection is the process of freeing up memory that is captured by unwanted objects. When you create a class object, automatically some memory space is allocated to the object in the heap memory. Now, after you perform all the actions on the object, the memory space occupied by the object becomes waste. It is necessary to free up memory.  

Garbage collection happens in three cases:

- If the occupied memory by the objects exceeds the pre-set threshold value.
- If the garbage collection method is called
- If your system has low physical memory

**Q-35. What are some advanced garbage collection techniques in C# to improve performance?**

Advanced garbage collection techniques in C# to improve performance include:
- Generational Garbage Collection: Separates objects into generations based on their age, allowing the garbage collector to focus on younger generations more frequently.
- Large Object Heap (LOH) Optimization: Special handling for large objects to avoid frequent collections and fragmentation.
- Concurrent and Background Collection: Allows garbage collection to run concurrently with application threads, minimizing pause times.
- Tuning GC Settings: Adjusting parameters like generation sizes, thresholds, and modes (e.g., server mode) based on application requirements.

**Q-36. What techniques can be used to optimize string manipulation for better performance in C#?**

To optimize string manipulation for better performance in C#, consider using the following techniques:

- Use StringBuilder: Instead of concatenating strings directly (which can create new string objects), use StringBuilder for mutable string operations.
- Avoid String Interpolation in Loops: String interpolation ($"{var}") can be inefficient within loops due to repeated allocations; prefer StringBuilder for building complex strings.
- Preallocate StringBuilder Capacity: Set the initial capacity of StringBuilder if you know the expected final size to reduce resizing overhead.
- Utilize Span<T> for In-place Manipulation: Use Span<T> for low-level character manipulation without unnecessary allocations.
- Consider String Pooling: Reuse commonly used strings with string interning or custom string pooling techniques to reduce memory usage.

**Q-37. Difference between Task and Thread**

**Q-38. How do you handle deadlocks in multi-threaded applications in C#?**

Deadlocks in multi-threaded applications can be handled by following these practices:

- Use Resource Allocation Order: Acquire locks and resources in a consistent order across threads to avoid circular dependencies.
- Timeout Mechanisms: Implement timeouts on lock acquisitions to prevent threads from waiting indefinitely.
- Avoid Nested Locks: Minimize nested locking to reduce the risk of deadlocks.
- Detect and Recover: Implement deadlock detection mechanisms or use tools like Monitor.TryEnter with timeout to detect and recover from potential deadlocks.

**Q-39. Compare async/await with Task.Run for concurrent operations in C#.**

- async/await: Used for asynchronous programming to execute non-blocking operations. async methods allow the use of await to pause execution without blocking the thread.
- Task.Run: Used to execute synchronous operations asynchronously on the ThreadPool. Task.Run is typically used to offload CPU-bound work from the main thread.

**Comparison:**

- Use async/await for asynchronous I/O-bound operations (e.g., file I/O, network requests) that involve waiting without blocking the thread.
- Use Task.Run for offloading synchronous CPU-bound operations to the background thread (e.g., complex calculations) to prevent blocking the UI thread.

**Q-40. Describe the differences between deep and shallow copying of objects in C#?**

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

