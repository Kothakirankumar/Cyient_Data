## C#
### [Anatomy of C# program](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/)
- namespace -> Types -> Type members
    - Namespace
        - Types - Members (Methods, variables, properties)
- [Types](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types) (Classes, Enums, Structs, Interface, Delegates)
  - All types in C# are inherited directly or indirectly Sytem.Object
        - **[Value Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)** - which has the direct value, stored in memory Stack, fast to access. Structs, Enums. Predefined (int, long, short, byte, DateTime, char)
        - **[Reference Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)** - it stores the reference to that value, value is stored in heap, expensive retrieval process. Classes, interface, Delegates. Predefined -> string, arrays, collections etc
  - Type Conversion : conversion of 1 type into another 
    - Implicit type conversion : no need to type cast. Ex byte value can be placed in int. No data loss.
    - Explicit type conversion : type cast it using `<datatype>.Parse(value)`, `Convert.<datatype>(value)`. You can have a data loss if its not fitting in the type.
  
- **Boxing**- refers to conversion Value type to reference types.
- **Unboxing**- refers to conversion of reference types to value types.

## [Statements](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/statements)
- A statement can consist of a single line of code that ends in a semicolon, or a series of single-line statements in a block. A statement block is enclosed in {} brackets and can contain nested blocks.
  -  **Expressions statements**: consists of operands and operators. Ex a + b ;
  -  **Declaration statements** : creating a new variable. Ex int a;
  -  **Selection Statements** : enables to branch a code in different sections based on the conditions. Ex if, else, switch, case.
  -  **Iteration Statements** : enables to repeat or loop through. Ex do-while, for, foreach, while.
  -  **Jump statements** : transfer controlt o another section of code. Ex break, continue, default, goto, return.
  -  **Exception handling statements** : recover from runtime errors gracefully. Ex throw, try-catch, try-catch-finally, try-finally.

## [Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/) 
- A variable to hold multiple values which are of same type (homogenous) and are located in contigious memory location.
- An array which in initialized must consist of a value.

## OOP(Object-Oriented Programming)
- Procedural Oriented languages - C, C++
  - The code scattered - variables, functions were loose and no structure.
  - Data leak due to garbage, that means data is less secure.
  - What to do and How to do?
  - Resuability wasn't a great option in Procedural oriented language.
- OOP
  - In OOP the program is organized into classes and accessed via object.
  - Programmer focus on what to do over how to do.
  - **[Class](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes)**: Blueprint of user defined type which is mapped to real time entities. Ex: Pen can be created as class with attributes/properties - type (ball, ink), color (blue, black, red, green) , behavior (writing).
  - **Object**: An object is a implementation of the class. It has been allocated memory. Whenever a class is instantiated the obj comes into the picture.
    - `Pen pen1 = new Pen();`, `Pen pen2 = pen1`.
    - Object has set of attributes/properties (static/dynamic)
    - Behaviour/Operations
  - [Constructors](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constructors)
    - Constructors are special methods which are called first during the execution of a program. They are used to create an object of a class and place a class into the memory.
    - A constructors has a same name as the name of the class. It doesn't have a return type but it may or may not have parameters.
  
  - **Pillars of OOP**
    - [OOP](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop) is structured on 4 pillars of OOP as:
      - **Encapsulation** - Wrapping up of the data (ex - methods encloses data field, class/Type encloses a method, namespace encapsulates the type) and data hiding, to provide protection from the outside world. We use Access modifiers to provide various levels of access.
      - **Abstraction** - Showing only essential features of the program instead on un-necessary details. In C#, abstraction can be achieved by **abstract** classes and **interfaces**. Through abstraction a template is provide which is generally impltemented by Team of Software Developers.
      - **Inheritance** - Is a way to extend a type so that its properties and behaviours can be extended/branched further. Types of Inheritance:
        - Single - level: A->B
        - Multi - level: A->B->C
        - Hierarichal level A->B,C,D
        - Multiple inheritance - (A,B)->C
        - Hybrid inheritance - Combination of more than one above types of inheritance.
      - C# doesnot support multiple and hybrid inheritance.
      - **Polymorphism** - Poly - many, morphs - forms. Ability to implement inherited properties or methods in different ways across multiple abstractions. 
## [Strings](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)
- A `string` is an object of type `String` whose value is text. Internally, the text is stored as a sequential read-only collection of `Char` objects. 
- There is no *null-terminating* character at the end of a C# string; therefore a C# string can contain any number of embedded null characters `('\0')`. 
- The `Length` property of a string represents the number of `Char` objects it contains, not the number of Unicode characters. 
- To access the individual Unicode code points in a string, use the `StringInfo` object.
- String class offers many String operations that can be performed on a string - Contains, ToUpper, ToLower, Clone, CopyTo, Substring, IndexOf, Reverse, Replace, EndsWith, StartsWith, Trim.
```
// Declare without initializing.
string message1;

// Initialize to null.
string message2 = null;

// Initialize as an empty string.
// Use the Empty constant instead of the literal "".
string message3 = System.String.Empty;

// Initialize with a regular string literal.
string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

// Initialize with a verbatim string literal.
string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

// Use System.String if you prefer.
System.String greeting = "Hello World!";

// In local variables (i.e. within a method body)
// you can use implicit typing.
var temp = "I'm still a strongly-typed System.String!";

// Use a const string to prevent 'message4' from
// being used to store another string value.
const string message4 = "You can't get rid of me!";

// Use the String constructor only when creating
// a string from a char*, char[], or sbyte*. See
// System.String documentation for details.
char[] letters = { 'A', 'B', 'C' };
string alphabet = new string(letters);
```
- String objects are **immutable**: they cannot be changed after they have been created. 
  - All of the String methods and C# operators that appear to modify a string actually return the results in a new string object.
  - Use [String Builder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-5.0) class top perform operations on the string with better performance.

## [Methods](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods)
- A method is a code block that contains a series of statements.
- A program causes the statements to be executed by calling the method and specifying any required method arguments.
- The **Main method** is the entry point for every C# application and it's called by the common language runtime (CLR) when the program is started.
- Methods are declared in a class, struct, or interface.
- The method specification specifies the names and types of any parameters that are required.
- When calling code calls the method, it provides concrete values called arguments for each parameter.

## [Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/properties)
- Smart fields in C# which are used to expose a private variable outsid the class
- You can use conditionals with your properties.
- properties can be created in 3 ways:
  - read-only - with only get block.
  - write-only - with only set block.
  - read-write property - with both get and set block.

## [Non - Access Modifiers](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/abstract)
- static 
  -  usually used with methods and classes. A static methid need not to be called via instance or obj, it can be called directly by the class name itself. -  Static classes contains only members, they cannot be instantiated instead use single point of entrance which is class itself. Static classes cannot be inherited which mean static classes are sealed by default.
- sealed 
  - usually used with methods and classes. 
  - Sealed class are closed for extension which means it cannot be inherited. 
  - Sealed classes can be instantiated.
  - Sealed methods are closed for overriding.
- partial 
  - usually used with classes and methods.
  - They are used to segrated the logical implememtation in components and on compile it is a single unit.
  - Ex You can create a partial class for design and the other component of that prtial class to handle the logic but when you compile it is compiled as a single class.
  - Same way you can logically separate the method implementation as handling inputs, validating inputs and performing operations on those inputs.
- abstract
- virtual
- new
- override
- this
- base
- async and await.....
## References
- [Learn C# in interactive way](https://docs.microsoft.com/en-us/users/dotnet/collections/yz26f8y64n7k07)
- [Learn C# from video](https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners)
