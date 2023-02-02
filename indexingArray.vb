Module Module1

    Sub Main()
        Dim name1(0 To 8) As String
        Dim marks1(0 To 8) As Integer
        Dim Total1 As Integer

        For index1 = 1 To 8
            Console.WriteLine("Enter Name : ", index1)
            name1(index1) = Console.ReadLine()

            Console.WriteLine("Enter marks  : ", index1)
            marks1(index1) = Console.ReadLine()

            Total1 = Total1 + marks1(index1)
        Next

        Console.WriteLine("| NAME    |  MARKS   |")
        For x = 1 To 8
            Console.WriteLine(name1(x) + "  |  " + Str(marks1(x)))
        Next

        Console.WriteLine("---------------------")
        Console.WriteLine("Total marks : " + Str(Total1))

        Console.ReadKey()


    End Sub
