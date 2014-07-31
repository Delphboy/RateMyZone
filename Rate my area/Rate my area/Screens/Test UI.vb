Imports Rate_my_area.DelphTech 
Public Class Test_UI

    Private Sub Button2_Click( sender As System.Object,  e As System.EventArgs) Handles Button2.Click
        Dim CSVR As New DT_CSVReader
        TextBox1.Text = 10 - CInt(CSVR.ReadFile(ComboBox1.Text, "Traffic-major-roads-miles.csv").ToString / 10900 * 10)
    End Sub
End Class