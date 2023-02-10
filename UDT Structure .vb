Module Module1

    Structure strec
        Dim name As String
        Dim Rollno As Integer
        Dim DoB As Integer
        Dim Pass As Boolean
    End Structure

    Sub Main()
        Dim Student(0 To 5) As strec

        Student(0).name = "Ali"
        Student(0).Rollno = 1079
        Student(0).DoB = 15122005
        Student(0).Pass = True
    End Sub
