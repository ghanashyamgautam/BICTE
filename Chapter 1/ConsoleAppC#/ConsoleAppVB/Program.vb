Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Enter the first number:")
        Dim num1 As Integer = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Enter the second number:")
        Dim num2 As Integer = Convert.ToInt32(Console.ReadLine())

        Dim sum As Integer = num1 + num2

        Console.WriteLine("The sum of {0} and {1} is {2}.", num1, num2, sum)
        Console.ReadKey()
    End Sub
End Module
