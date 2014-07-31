Imports Rate_my_area.DelphTech 

Public Class Form1
    Dim FormLoader As New DT_Form(Me, "Rate my area", False, Windows.Forms.FormBorderStyle.FixedSingle, 300, 500)

    Private Sub Button1_Click( sender As System.Object,  e As System.EventArgs) Handles Button1.Click
        'CSV READER
        Test_form.Show()
    End Sub

    Private Sub Button2_Click( sender As System.Object,  e As System.EventArgs) Handles Button2.Click
        'USER INPUT UI
        Test_UI.Show()
    End Sub

    Private Sub Button3_Click( sender As System.Object,  e As System.EventArgs) Handles Button3.Click
        'OUTPUT UI
        Output.Show()
    End Sub

    Private Sub Button4_Click( sender As System.Object,  e As System.EventArgs) Handles Button4.Click
        Dim TrafficF as New Traffic
        TrafficF.Show()
    End Sub
End Class