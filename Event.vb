Module Module1

    Sub Main()
        Dim Evnt As String
        Dim Choice As Char
        Console.WriteLine(" Press Y to continue, N to exit ")
        Choice = Console.ReadLine()
        While Choice = "Y" Or Choice = "y"

            Console.WriteLine("Enter The Evnt Name: ")
            Evnt = Console.ReadLine
            If Evnt = "Funeral" Then
                Console.WriteLine(" Wear White ")
            ElseIf Evnt = "Bachelors Party" Then
                Console.WriteLine(" Wear Classic ")
            End If
            Console.WriteLine(" Press Y to continue, N to exit ")
            Choice = Console.ReadLine
        End While

        Console.ReadKey()

    End Sub

End Module
