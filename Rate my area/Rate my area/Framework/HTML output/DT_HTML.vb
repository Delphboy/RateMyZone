Namespace DelphTech
    Public Class DT_HTML
        Public Function CreateHTML(ByVal OutputLoc As String, ByVal TitleData As String, ByVal BodyData As String)
            Try
                 Dim Filename = OutputLoc
                 Dim fs As New System.IO.FileStream(OutputLoc, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                 Dim Writer As New System.IO.StreamWriter(fs)

                 Writer.WriteLine("<!DOCTYPE HTML>")
                 Writer.WriteLine("  <HTML>")

                 Writer.WriteLine("      <HEAD>")
                 Writer.WriteLine("      <TITLE>")
                 Writer.WriteLine("          " + TitleData)
                 Writer.WriteLine("      </TITLE>")
                 Writer.WriteLine("      </HEAD>")

                 Writer.WriteLine("      <BODY>")
                 Writer.WriteLine("          " + BodyData)
                 Writer.WriteLine("      </BODY>")

                 Writer.WriteLine("  </HTML>")

                 Writer.Close()
                 fs.Close()

                 Return OutputLoc + ".HTML"
            
            Catch ex As Exception
                Return MsgBox(ex.Message)
            End Try
        End Function

        Public Function CreateHTMLWithCSS(ByVal OutputLoc As String, ByVal CSSLocation As String ,ByVal TitleData As String, ByVal BodyData As String)
            Try
                 Dim Filename = OutputLoc
                 Dim fs As New System.IO.FileStream(OutputLoc, System.IO.FileMode.Create, System.IO.FileAccess.Write)
                 Dim Writer As New System.IO.StreamWriter(fs)

                 Writer.WriteLine("<!DOCTYPE HTML>")
                 Writer.WriteLine("  <HTML>")
                 
                 Writer.WriteLine("      <HEAD>")
                 Writer.WriteLine("         " + CSSLocation)
                 Writer.WriteLine("      <TITLE>")
                 Writer.WriteLine("          " + TitleData)
                 Writer.WriteLine("      </TITLE>")
                 Writer.WriteLine("      </HEAD>")

                 Writer.WriteLine("      <BODY>")
                 Writer.WriteLine("          " + BodyData)
                 Writer.WriteLine("      </BODY>")

                 Writer.WriteLine("  </HTML>")

                 Writer.Close()
                 fs.Close()

                 Return OutputLoc + ".HTML"
            
            Catch ex As Exception
                Return MsgBox(ex.Message)
            End Try
        End Function

    End Class
End Namespace