Namespace DelphTech
    Public Class DT_ExtFiles
        Public Function ReturnExtFile(ByVal Filename As String)
            Dim File As String 
            Try
                File = Application.StartupPath + "\" + Filename
            Catch ex As Exception
                File = Nothing 
            End Try
            Return File.ToString 
        End Function

    End Class
End Namespace