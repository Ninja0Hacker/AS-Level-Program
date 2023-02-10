Module Module1

    Sub Main()
        Dim x As Integer
        x = 4
        Call myproc(x)
        Console.WriteLine(x)
        Console.ReadKey()
    End Sub

    Sub myproc(ByVal x As Integer)
        Dim z As Integer
        x = x + 1
        z = z + 3
    End Sub

End Module
