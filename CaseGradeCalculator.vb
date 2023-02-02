Module Module1
    'Input Marks of a student
    'Display His Grade with respect to his/hers marks
    'Set your own criteria
    Sub Main()
        Dim marks As Integer
        Dim choice As Char
        Console.WriteLine(" Press Y to continue, N to exit ")
        choice = Console.ReadLine()
        While choice = "Y" Or choice = "y"
            Console.Write("Enter marks to get grades : ")
            marks = Console.ReadLine
            Select Case marks
                Case Is > 80 And marks <= 100 : Console.WriteLine(" You got an A* ")
                Case Is > 70 And marks < 80 : Console.WriteLine(" You got an A ")
                Case Is > 60 And marks < 70 : Console.WriteLine(" You got a B ")
                Case Is > 50 And marks < 60 : Console.WriteLine(" You got a C ")
                Case Is > 40 And marks < 50 : Console.WriteLine(" You got a D ")
                Case Is > 30 And marks < 40 : Console.WriteLine(" YOu got an E ")
                Case Is > 0 And marks < 30 : Console.WriteLine(" You Have Failed ")
                Case Else
                    Console.WriteLine(" I'm with you in every thick and thin ")
            End Select
            Console.WriteLine(" Press Y to continue, N to exit ")
            choice = Console.ReadLine
        End While

    End Sub

End Module
