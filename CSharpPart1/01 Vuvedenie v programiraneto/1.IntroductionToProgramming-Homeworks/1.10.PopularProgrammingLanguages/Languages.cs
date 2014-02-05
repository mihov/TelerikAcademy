//1.10.	Provide a short list with information about the most popular programming languages. How do they differ from C#?
using System;
class Languages
{
    static void Main()
    {
        Console.WriteLine(@"
                        Modern Programming Languages
###############################################################################    
    [D 2.0] is like C/C++ a system-level language, but with garbage collection 
and integrates imperative object oriented programming with functional and 
concurrent programming (actor model).

    [Erlang] is a concurrent programming language with a functional language 
as it's core, strict evaluation and dynamic typing. It was designed by 
Ericsson to support distributed, fault-tolerant, soft-real-time, concurrent 
systems and has been used esp. in the telecommunications area.

    [Groovy] is an agile dynamically typed language extension of Java.
    
    [Fortress] is brand new specification of a next generation programming 
language specifically designed for high performance computing (HPC). 
It is very innovative, but not yet ready for practice.

    [Haskell] is a purely functional programming language. I wrote my diploma 
thesis about the implementation of geometrical algorithms in this language.

    [Python] is a multi-paradigm programming language that incorporates 
imperative, functional and object-oriented features. Python has a dynamic 
type system.

    [Ruby] is a reflective, dynamic, object-oriented language and often used 
in web development.

    [Scala] is a statically typed multi-paradigm programming language, that 
integrates features of object-oriented and functional languages. It is 
integrated into Java and .NET.

###############################################################################

    [C#] is a multi-paradigm programming language encompassing strong typing, 
imperative, declarative, functional, procedural, generic, object-oriented 
(class-based), and component-oriented programming disciplines.

    C# is intended to be a simple, modern, general-purpose, object-oriented 
programming language.
###############################################################################");
        Console.ReadKey();
    }
}