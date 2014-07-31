Namespace DelphTech
    Public Class DT_CSVReader
        'Split into 2 arrays
        'Search array 1 for area name, return index
        'Use index to return value

        Public Function ReadFile(ByVal AreaName As String, ByVal Filename As String)
            Dim CSVFile() As String
            Dim areacounter As Integer = 0
            Dim currentarea As String = ""
            Dim ExtFile As New DT_ExtFiles
            Dim myreader As New System.IO.StreamReader(ExtFile.ReturnExtFile(Filename).ToString)

            ReDim CSVFile(IO.File.ReadAllLines(Filename).Length)

            Dim line As String
            Dim counter As Integer = 0
            Do While myreader.Peek() <> -1
                line = myreader.ReadLine()
                CSVFile(counter) = line
                counter += 1
            Loop
            myreader.Close()
            Dim CommaPos As Integer
            Dim TotalLine As Integer
            Dim CurrentLine As Integer

            TotalLine = CSVFile.Length - 1
            Dim Area(TotalLine) As String
            Dim Result(TotalLine) As String

            While CurrentLine < TotalLine
                CommaPos = InStr(CSVFile(CurrentLine), ",")
                Area(CurrentLine) = LSet(CSVFile(CurrentLine), CommaPos - 1)
                Result(CurrentLine) = CSVFile(CurrentLine).Substring(CommaPos)
                CurrentLine += 1
            End While

            Do Until currentarea = AreaName
                'LOOP THROUGH AND READ EACH VALUE OF THE ARRAY
                'BREAK LOOP WHEN THE CURRENT AREA = USER SELECTED AREA NAME
                'RETURN INDEX
                currentarea = Area(areacounter)
                areacounter += 1
            Loop

            Return Result(areacounter).ToString 
        End Function
    End Class
End Namespace