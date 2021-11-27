'predefined namespace
Imports System

'Module is like a class but it has only one instance
Module Program
    Sub Main(args As String())
        Dim name as String
        Dim age as Integer
        Console.Write("Please enter your name ")
        name = Console.Readline()
        Console.WriteLine("Hello {0}! \n Command Line Argument - {1}",name ,args(0))'using commandline arguements
    End Sub
End Module
