Namespace DelphTech
    Public Class DT_IO

        'THIS WILL COMPLETELY REWRITE THE FILE IF IT EXISTS ALREADY
        Public Sub Write(ByVal FileLoc As String, ByVal Content As String)
            Dim Filename = FileLoc
            Dim fs As New System.IO.FileStream(FileLoc, System.IO.FileMode.Create, System.IO.FileAccess.Write)
            Dim Writer As New System.IO.StreamWriter(fs)

            Writer.WriteLine(Content)

            Writer.Close()
            fs.Close()
        End Sub

        'THIS WILL READ ALL OF A FILE AND STORE IT AS A STRING. THAT STRING WILL THEN BE RETURNED
        Public Function ReadAll(ByVal FileLoc As String)
            Dim FileContents As String = ""
            Dim fs As New System.IO.FileStream(FileLoc, System.IO.FileMode.Open, System.IO.FileAccess.Read)
            Dim d As New System.IO.StreamReader(fs)
            d.BaseStream.Seek(0, System.IO.SeekOrigin.Begin)
            While d.Peek() > -1
                FileContents = d.ReadToEnd()
            End While
            Return FileContents
        End Function

        'THIS WILL CREATE A FOLDER AT THE SPECIFIED LOCATION
        Public Sub CreateDir(ByVal Location As String)
            System.IO.Directory.CreateDirectory(Location)
        End Sub
    End Class
End Namespace