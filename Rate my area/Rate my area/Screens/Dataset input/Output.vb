Imports Rate_my_area.DelphTech
Public Class Output
    Dim PicBoxLoc As New Point(0, 0)
    public OutputUI As New DT_Form(Me, "", True, Windows.Forms.FormBorderStyle.FixedSingle, 250, 400)
    public Output As New DT_Render(Me, 250, 400, "", 245, 390, PicBoxLoc, DockStyle.Fill, Color.FromArgb(159, 0, 159))
    Public Gbl As New Globals

    Private Sub Output_Load( sender As System.Object,  e As System.EventArgs) Handles MyBase.Load
        DrawScore(Globals.ResultScore, Globals.ResultArea)
    End Sub

    Public Sub DrawScore(ByVal Score As Integer, ByVal Location As String)
        Dim Rect1 As New Rectangle(10, 10, 100, 300)
        Dim Rect2 As New Rectangle(122, 10, 100, 300)

        Dim TxtFont As New Font("tahoma", 18)

        Dim TxtRect As New RectangleF(25, 240, 200, 360) 
        Dim stringformat As New StringFormat()
        stringformat.Alignment = StringAlignment.Center

        Select Case Score
            Case 0
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._0, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 1
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._1, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 2
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._2, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 3
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._3, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 4
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._4, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 5
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._5, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 6
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._6, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 7
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._7, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 8
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._8, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 09
                Output.Device.DrawImage(My.Resources._0, Rect1)
                Output.Device.DrawImage(My.Resources._9, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.white, TxtRect, stringformat)
            Case 10
                Output.Device.DrawImage(My.Resources._1, Rect1)
                Output.Device.DrawImage(My.Resources._0, Rect2)

                Output.Device.DrawString(Location + " scored the above score!", TxtFont, Brushes.White, TxtRect, stringformat)
            Case Else
                Output.Device.DrawString("Something went wrong", TxtFont, Brushes.White, TxtRect, stringformat)

        End Select
    End Sub

End Class