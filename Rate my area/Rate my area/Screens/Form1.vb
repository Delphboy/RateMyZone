Imports Rate_my_area.DelphTech 

Public Class Form1
    Dim FormLoader As New DT_Form(Me, "Rate my area", False, Windows.Forms.FormBorderStyle.FixedSingle, 300, 500)

    Private Sub Button3_Click( sender As System.Object,  e As System.EventArgs) 
        'OUTPUT UI
        Output.Show()
    End Sub

    Private Sub Button4_Click( sender As System.Object,  e As System.EventArgs) 
        Dim TrafficF as New Traffic
        TrafficF.Show()
    End Sub

Private Sub PicBoxNext_Click( sender As System.Object,  e As System.EventArgs) Handles PicBoxNext.Click
    Me.Hide()    
    Traffic.Show()
End Sub
End Class