Namespace DelphTech
    Public Class DT_Render
        Private p_PicBox As PictureBox
        Private p_Device As Graphics
        Private p_Surface As Bitmap
        Private p_Form As Form
        Private p_Font As Font
        Private p_GameOver As Boolean

        Public Sub New(ByRef Form As Form, ByVal Width As Integer, ByVal Height As Integer, ByVal FormTitle As String, ByVal PicBoxWidth As Integer, ByVal PicBoxHeight As Integer, ByVal PicBoxLoc As Point, ByVal PicBoxDoc As DockStyle, ByVal PicBoxBackColour As Color)
            'CREATE GRAPHICS DEVICE
            p_Surface = Nothing
            p_PicBox = Nothing
            p_Device = Nothing
            p_Form = Nothing
            p_GameOver = Nothing

            'SET FORM PROPERTIES
            p_Form = Form
            p_Form.Text = FormTitle
            p_Form.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            p_Form.MaximizeBox = False
            p_Form.Size = New Point(Width + 6, Height + 28)

            'CREATE A PICTURE BOX
            p_PicBox = New PictureBox
            p_PicBox.Parent = p_Form
            p_PicBox.Dock = PicBoxDoc
            p_PicBox.Location = PicBoxLoc
            p_PicBox.Size = New Size(PicBoxWidth, PicBoxHeight)
            p_PicBox.BackColor = PicBoxBackColour

            'CREATE GRAPHICS DEVICE
            p_Surface = New Bitmap(p_Form.Size.Width, p_Form.Size.Height)
            p_PicBox.Image = p_Surface
            p_Device = Graphics.FromImage(p_Surface)
        End Sub

        Protected Overrides Sub Finalize()
            'FREE MEMORY
            p_Device.Dispose()
            p_Surface.Dispose()
            p_PicBox.Dispose()
        End Sub

        Public Sub Update()
            'REFRESH DRAWING SURFACE
            p_PicBox.Image = p_Surface
        End Sub

        Public ReadOnly Property Device() As Graphics
            Get
                Return p_Device
            End Get
        End Property

        '''''''''''''''''''''
        'PRINT TEXT FUNCTION'
        '''''''''''''''''''''
        Public Sub PrintText(ByVal Text As String, ByVal Location As PointF, ByVal Font As Font, ByVal FontColour As Brush)
            p_Device.DrawString(Text, Font, FontColour, Location)
        End Sub

        ''''''''''''''''''''''''''
        'BITMAP SUPPORT FUNCTIONS'
        ''''''''''''''''''''''''''
        Public Function LoadBitMap(ByVal FileName As String)
            Dim bmp As Bitmap = Nothing
            Try
                bmp = New Bitmap(FileName)
            Catch ex As Exception
                bmp = Nothing
            End Try
            Return bmp
        End Function

        Public Sub DrawBitmapCustom(ByVal Filename As String, ByVal Position As PointF, ByVal rect As Rectangle)
            p_Device.DrawImageUnscaledAndClipped(LoadBitMap(Filename), rect)
        End Sub

        Public Sub DrawBitmapFileExact(ByVal Filename As String, ByVal Position As Point)
            p_Device.DrawImageUnscaled(LoadBitMap(Filename), Position)
        End Sub

        ''''''''''''''''
        'LAYER TEXTURES'
        ''''''''''''''''
        'TO REDUCE OR COMPLETELY REMOVE BACKGROUND IMAGE STRETCHING IT IS HIGHLY RECOMMENDED THAT THE BACKGROUND IMG IS THE SAME SIZE AS THE FORM
        'THE IMAGE WILL BE SET TO THE GRAPHICS DEVICE BACK GROUND IMAGE SO FOR BEST QUALITY MAKE THEM THE SAME SIZE

        Public Sub RenderBaseLayer(ByVal Filename As String)
            p_PicBox.BackgroundImage = LoadBitMap(Filename)
        End Sub

        Public Sub RenderMidLayer(ByVal Filename As String, ByVal Rect As Rectangle)
            p_Device.DrawImageUnscaled(LoadBitMap(Filename), Rect)
        End Sub

        Public Sub RenderTopLayer(ByVal Filename As String, ByVal Rect As Rectangle)
            p_Device.DrawImageUnscaled(LoadBitMap(Filename), Rect)
        End Sub

    End Class
End Namespace