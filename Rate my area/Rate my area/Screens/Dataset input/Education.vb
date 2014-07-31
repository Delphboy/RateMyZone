Imports Rate_my_area.DelphTech
Public Class Education

    Private Sub PicBoxNext_Click( sender As System.Object,  e As System.EventArgs) Handles PicBoxNext.Click
        'CALCULATE FUNCTION
        Dim CSVR As New DT_CSVReader
        If CBoxAreas.Text = "" then
            MsgBox("Choose your location")
        Else
            If CheckUseData.Checked = False
                Globals.UseTraffic = False
            End If
        Me.Hide()
            Globals.EducationScore = CInt(CSVR.readfile(CBoxareas.Text,"University.csv") / 169220 * 10)
        Globals.ResultScore = CInt(Globals.EducationScore + Globals.EnvironmentScore + Globals.CrimeScore + Globals.HealthScore + Globals.TrafficScore) / 5
            Output.Show()
        End If
    End Sub

Private Sub Education_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
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