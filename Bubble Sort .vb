Module Module1
    Dim height() = {170, 168, 201, 202, 150, 181, 165, 172}
    
    Sub Main()
        BubbleSort()
        Console.WriteLine()
        OutputArray()
        Console.ReadKey()
    End Sub
    
    Sub BubbleSort()
        Dim Temp As Integer
        Dim swap As Boolean
        Do
            swap = False
            For index = 0 To 6
                If height(index) > height(index + 1) Then
                    Temp = height(index)
                    height(index) = height(index + 1)
                    height(index + 1) = Temp
                    swap = True
                End If
            Next
        Loop Until swap = False
    End Sub
    
    Sub OutputArray()
        For x = 0 To 7
            Console.WriteLine(height(x))
        Next
    End Sub
End Module
