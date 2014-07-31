Imports Rate_my_area.DelphTech
Public Class Health

Private Sub PicBoxNext_Click( sender As System.Object,  e As System.EventArgs) Handles PicBoxNext.Click
        Dim CSVR As New DT_CSVReader
        If CBoxAreas.Text = "" then
            MsgBox("Choose your location")
        Else
            If CheckUseData.Checked = False
                Globals.UseTraffic = False
            End If
        Me.Hide()
        
        Globals.HealthScore = 10 - CInt(CSVR.readfile(CBoxareas.Text,"Obesity.csv") / 2760 * 10)
        Crime.Show()
        End If
End Sub

Private Sub Health_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
Me.StartPosition = FormStartPosition.CenterScreen 
End Sub
        Private Sub CheckUseData_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckUseData.CheckedChanged
        If CheckUseData.Checked = False Then
            CBoxAreas.Enabled = False
        Else
            CBoxAreas.Enabled = True
        End If
    End Sub
End Class