Module Module1

    Sub Main()
        ''create five objects and add them to a list...
        'Dim n As Integer, list As New ArrayList()
        'For n = 1 To 5
        '    list.Add(New MyObject())
        'Next

        ''now delete the list, the objects now 
        ''have no references...
        'list.Clear()

        ''wait for the user to press return...
        'MsgBox("The Main procedure is starting the application.")
        'Console.WriteLine("Press Return to collect the garbage...")
        'Console.WriteLine()

        ''force a collect...
        'GC.Collect()

        ''wait for the user to quit...
        'Console.WriteLine("Press Return to quit...")
        'Console.WriteLine()

        '' Insert call to appropriate starting place in your code.  
        'MsgBox("The application is terminating.")

        'create a file and write to it...
        Dim file As New MyFile("C:\Users\field\source\repos\WindowsApp1\ConsoleApp1\files\FinalizeDemo.txt")
        file.AddText("Hello, world!")

        'now, clear the reference to the object...
        file = Nothing

        'wait for the user to press return...
        Console.WriteLine("Press Return to collect the garbage...")
        Console.ReadLine()

        'force a collect...
        GC.Collect()

        'wait for the user to quit...
        Console.WriteLine("Press Return to quit...")
        Console.ReadLine()
        MsgBox("The application is terminating.")
    End Sub

End Module

