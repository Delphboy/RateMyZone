Namespace DelphTech
    Public Class DT_Form
        Private p_Form As Form

        Public Sub New(ByRef Form As Form, ByVal Name As String, ByVal CanMaximise As Boolean, ByVal BorderStyle As FormBorderStyle, ByVal Width As Integer, ByVal Height As Integer)
            p_Form = Form
            p_Form.Text = Name
            p_Form.Size = New Point(Width, Height)
            p_Form.MaximizeBox = CanMaximise
            p_Form.FormBorderStyle = BorderStyle
        End Sub
    End Class
End Namespace