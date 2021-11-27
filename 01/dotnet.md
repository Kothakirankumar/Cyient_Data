# Welcome to .NET

## What is .NET?
- .NET is an open source developer platform created by Microsoft. It's for building many different types of apps, such as web apps, desktop apps, games, api, smart phones apps....
- In short, .NET Platform is a collection of **languages**, **libraries**, and **frameworks** to make various applications, developed under one common standard.
- With .Net platform you can build your app, test app, deploy the app and maintain. This is why .Net caters mostly all phases of SDLC.

## Supported Programming Languages
- Dozens of programming languages are supported by .Net provided they are compatible with the platform. [List](https://en.wikipedia.org/wiki/List_of_CLI_languages)
- 3 different languages which are by default supported by .Net are
- C#: Object oriented, type safe language
    - object oriented means, that everything is an object. These objects are further organized with classes
    - Type-safe means that once you declare a type of a variable, you can't really change it. 
- Visual Basic : Supports UI and component oriented language.
- F#: F# is a functional programming language supported by .NET
- All .Net compliant languages ahve to follow a Standard. These standard are defined by CLS (Common Language Specification).
  - CLS gives a set of rules and regulation a .Net compliant language should follow. Ex all .Net compliant languages should be OOP languages, Array index should start from 0 etc...

## Technologies we'll be using during this training
- .NET 6 
- C#
- VB.Net

## [History of .Net](https://docs.microsoft.com/en-us/dotnet/core/porting/versioning-sdk-msbuild-vs)
- Microsoft introduced .Net 1.0 (deprecated) in 2002. It was known as .Net Framework
  
## .NET Implementation
4 main implementation of .NET 
- **.NET Framework**: first implementation of .NET, only works on windows, and it is shipped with every windows.
- **.NET / .NET Core**: .NET Core is the cross-platform implemtation of .NET, and is a successor of .NET Framework. 
    - This is a primary implementation of .NET and is the focus of ongoing development effort. This what we'll be using.
    -.NET 6
- **Mono**
    - .NET runtime that power Xamarin application. 
    - useful when small footprint is needed
    - also powers games built with Unity
- **Universal Windows Platform (UWP)**
    - Used for building modern, touch-enabled Windows applications and software for the Internet of Things (IoT). 
    - It's designed to unify the different types of devices that you may want to target, including PCs, tablets, phones, and even the Xbox.

## Components of .NET Implementation
- One or more runtime: Example, .NET Framework CLR, .NET 5 CLR
     - [CLR](https://docs.microsoft.com/en-us/dotnet/standard/clr) stands for *Common Language Runtime* and it's a runtime environment provided by .NET.
     - Compilers and tools expose the common language runtime's functionality and enable you to write code that benefits from this [managed execution environment](https://docs.microsoft.com/en-us/dotnet/standard/managed-execution-process).
- A class library, for example, .NET Framework Base Class Library, or .NET 5 Base Class Library.
- Optionally, we have one or more application frameworks, such as ASP.NET Core for web application development, Windows Forms, etc.
- Optionally, development tools. Some are shared among multiple implementations.

#### CLR? SDK?
- CLR Stands for Common Language Runtime, and it's runtime environment. It is also know as main execution Engine and is used to run any .Net application.
- SDK stands for Software Development Kit.
- CLR comes included in SDK

## .NET Standard
- .NET Standard is a base set of API's that are common to all .NET implementation.

### Additional Frameworks
These are frameworks that extend .NET platform to provide additional functionalities.
- **ASP.NET Core**: Open source framework for building web apps and web services
    - it's a redesign on ASP.NET 4.x with architectural changes that result in a lener, more modular framework
- **Unity**: Real-time 3D development platform
- **UWP (Universal Windows Platform)**: for developing various windows applications
- **Xamarin**: for mobile development
- **ML.NET**: machine learning
- and more..
## Types of Applications
- CUI (Character User Interface) - command line interface. Ex console app in .Net
- GUI (with user friendly UI) - Desktop app, web apps
- Smart UIs - Android or IOS
- APIs - REST Api
- Cloud application : Azure, GCP, AWS
### Other Niceties..
- **Nuget**: a package manager for .NET

### Anatomy of C# code
```
Namespace
    Types (class, structs, enums, delegates, interface)
        Type members (variables, methods, events)
```
## [Namespaces](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/using-namespaces)
- They organize large code projects.
- They're delimited by using the . operator.
- The using directive obviates the requirement to specify the name of the namespace for every class.
- The global namespace is the "root" namespace: global::System will always refer to the .NET System namespace.

## [Type conversions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions)
- Conversion of one datatype from to another. There are various ways to do such conversions:
  - **Implicit**
  - **Explicit**

## [Expressions, operators and operands](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)
- Expressions are made of operators and operands.
- C# has many operators :
  - **Arithmatic operators** - Binary (*, /, %), Unary (++, --, +, -)
    - **Unary**
      -  +4, -4, -(-4)
      -  a++ (post fix - after read) => a = a + 1, ++a (prefix -> before read)
     - **Binary** 
       - (a+b)
       - a + b * c
   - **Comparison operators** - <, >, <=, >=
   - **Boolean logical operators** -  ! (NOT), && (AND), || (OR)
   - **Equality operator** - == , !=
   - **Assignment** - =
   - **Ternary operator** - ?:
     - condition ? consequent : alternative
     - temp  < 25 ? "cold" : "warm"
## [Statements]
- **Selection statements**
  - **If** - selects a statement to execute based on the value of a boolean expression.
  - **Switch** - selects a statement list to execute based on a pattern match with an expression
    - the switch statement uses the following patterns:
      - A relational pattern: to compare an expression result with a constant.
      - A constant pattern: to test if an expression result equals a constant.
- **Iteration statements** - iteration means repetition based on the conditions
  - **do**
  - **while**
  - **for**
  - **foreach**
### Additional Resources
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/core/introduction)
- [.NET Glossary](https://docs.microsoft.com/en-us/dotnet/standard/glossary)
- [Introducing .NET 5](https://devblogs.microsoft.com/dotnet/introducing-net-5/)
- [What is .NET?](https://www.codecademy.com/articles/what-is-net)
- [Learn C# in interactive way](https://docs.microsoft.com/en-us/users/dotnet/collections/yz26f8y64n7k07)
- [Learn C# from video](https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners)
- [Learn basics of Vb](https://www.tutorialspoint.com/vb.net/index.htm)
- [Structure of Vb program](https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/program-structure/structure-of-a-visual-basic-program)
- [Type conversions VB](https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/data-types/type-conversions)
- [Boxing and unboxing](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/boxing-and-unboxing)