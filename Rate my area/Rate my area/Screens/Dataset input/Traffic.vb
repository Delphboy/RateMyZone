Imports Rate_my_area.DelphTech
Public Class Traffic

    Private Sub PicBoxNext_Click( sender As System.Object,  e As System.EventArgs) Handles PicBoxNext.Click
        Dim Gbl As New Globals
        Dim CSVR As New DT_CSVReader
        If CBoxAreas.Text = "" then
            MsgBox("Choose your location")
        Else
            If CheckUseData.Checked = False
            Globals.UseTraffic = False
            End If
        Me.Hide()
        
        Globals.TrafficScore = 10 - CInt(CSVR.readfile(CBoxareas.Text,"Traffic-major-roads-miles.csv") / 10900 * 10)
        Globals.ResultArea = CBoxAreas.Text
        pollution.Location = New Point(100, 100)
        Pollution.Show()
        End If
    End Sub

    Private Sub Traffic_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
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