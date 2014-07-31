Imports Rate_my_area.DelphTech 
Public Class Crime

    Private Sub Crime_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen 
    End Sub

Private Sub PicBoxNext_Click( sender As System.Object,  e As System.EventArgs) Handles PicBoxNext.Click
        Dim CSVR As New DT_CSVReader
        If CBoxAreas.Text = "" then
            MsgBox("Choose your location")
        Else
            If CheckUseData.Checked = False
                Globals.UseTraffic = False
            End If
        Me.Hide()
        
        Globals.CrimeScore = 10 - CInt(CSVR.readfile(CBoxareas.Text,"Crime.csv") / 819527 * 10)
        Education.Show()
        End If
End Sub
        Private Sub CheckUseData_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckUseData.CheckedChanged
        If CheckUseData.Checked = False Then
            CBoxAreas.Enabled = False
        Else
            CBoxAreas.Enabled = True
        End If
    End Sub
End Class