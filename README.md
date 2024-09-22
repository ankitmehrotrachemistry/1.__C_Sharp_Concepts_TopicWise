## 0). Advanced C# Concepts

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












