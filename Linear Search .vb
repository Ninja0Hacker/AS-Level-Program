Module Module1
    Dim stnames() = {"Ali", "Sam", "Gabriel", "Santa Maria", "Gabby", "Josh"}
   
  Sub Main()
        linearSearch()
        Console.ReadKey()
    End Sub
  
  Sub linearSearch()
        Dim x As Integer
        Dim Found As Boolean
        Dim NameToSearch As String
        Dim Choice As Char
        Found = False
        x = 0
        Console.WriteLine("Press Y to Start, N to Exit:")
        Choice = Console.ReadLine()
        While Choice = "Y" Or Choice = "y"
            Console.Write("Enter The Name To Search: ")
            NameToSearch = Console.ReadLine()
            While x <= 5 And Found = False
                If NameToSearch = stnames(x) Then
                    Found = True
                End If
                x = x + 1
            End While
            If Found = True Then
                Console.WriteLine("The Name" & NameToSearch & "has been found and is at the location " & x - 1)
            Else
                Console.WriteLine("The Name has not been found")
            End If
            Console.WriteLine("Press Y to Continue, N to Exit:")
            Choice = Console.ReadLine()
        End While
  End Sub
End Module
