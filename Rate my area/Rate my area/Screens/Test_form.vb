Imports System.IO, Rate_my_area.DelphTech
Public Class Test_form
    'ITS JUST A TEST TO SEE IF IT WILL WORK IT DOESN'T NEED THAT YET
    Dim CSVFile() As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ExtFile As New DT_ExtFiles 
        Dim myreader As New StreamReader(ExtFile.ReturnExtFile("Crime.csv").ToString) 'THIS WILL LATER JUST REFERENCE CLASS FILES

        Dim line As String
        Do While myreader.Peek() <> -1
            line = myreader.ReadLine()
            ListBox1.Items.Add(line)
        Loop
        myreader.Close()
        CSVFile = ListBox1.Items.OfType(Of String)().ToArray()
        csvsort()
    End Sub
    Sub csvsort()
        Dim CommaPos As Integer
        Dim TotalLine As Integer
        Dim CurrentLine As Integer

        TotalLine = CSVFile.Length
        Dim Area(TotalLine - 1) As String
        Dim TrafCount(TotalLine - 1) As Integer

        While CurrentLine < TotalLine
            CommaPos = InStr(CSVFile(CurrentLine), ",")
            Area(CurrentLine) = LSet(CSVFile(CurrentLine), CommaPos - 1)
            TrafCount(CurrentLine) = CSVFile(CurrentLine).Substring(CommaPos)
            CurrentLine += 1
        End While
    End Sub
End Class