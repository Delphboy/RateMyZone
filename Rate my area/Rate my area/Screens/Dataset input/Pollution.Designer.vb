<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pollution
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pollution))
        Me.PicBoxAbout = New System.Windows.Forms.PictureBox()
        Me.CBoxAreas = New System.Windows.Forms.ComboBox()
        Me.PicBoxNext = New System.Windows.Forms.PictureBox()
        Me.CheckUseData = New System.Windows.Forms.CheckBox()
        CType(Me.PicBoxAbout,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicBoxNext,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PicBoxAbout
        '
        Me.PicBoxAbout.BackgroundImage = Global.Rate_my_area.My.Resources.Resources.Environment
        Me.PicBoxAbout.Location = New System.Drawing.Point(7, 57)
        Me.PicBoxAbout.Name = "PicBoxAbout"
        Me.PicBoxAbout.Size = New System.Drawing.Size(220, 240)
        Me.PicBoxAbout.TabIndex = 7
        Me.PicBoxAbout.TabStop = false
        '
        'CBoxAreas
        '
        Me.CBoxAreas.FormattingEnabled = true
        Me.CBoxAreas.Items.AddRange(New Object() {"Aberdeen", "Armagh Roadside", "Barnstaple A39", "Belfast Centre", "Birmingham Tyburn", "Birmingham Tyburn Roadside", "Bristol St Paul's", "Camden Kerbside", "Cardiff Centre", "Carlisle Roadside", "Chatham Roadside", "Chepstow A48", "Chesterfield", "Chesterfield Roadside", "Derry", "Eastbourne", "Edinburgh St Leonards", "Glasgow Kerbside", "Glasgow Townhead", "Grangemouth", "Haringey Roadside", "Hull Freetown", "Inverness", "Leamington Spa", "Leamington Spa Rugby Road", "Leeds Centre", "Leeds Headingley Kerbside", "Leicester Centre", "Leicester University", "Liverpool Speke", "London Bloomsbury", "London Harlington", "London Marylebone Road", "London N. Kensington", "Middlesbrough", "Newcastle Centre", "Newport", "Norwich Lakenfields", "Nottingham Centre", "Oxford St Ebbes", "Plymouth Centre", "Port Talbot Margam", "Portsmouth", "Reading New Town", "Salford Eccles", "Saltash Callington Road", "Sandy Roadside", "Scunthorpe Town", "Sheffield Centre", "Sheffield Devonshire Green", "Southampton Centre", "Southwark A2 Old Kent Road", "Stanford-le-Hope Roadside", "Stockton-on-Tees Eaglescliffe", "Stoke-on-Trent Centre", "Storrington Roadside", "Swansea Roadside", "Thurrock", "Warrington", "Wrexham", "York Bootham", "York Fishergate", "Aston Hill", "Auchencorth Moss", "Bush Estate", "Charlton Mackrell", "Eskdalemuir", "Great Dun Fell", "Harwell", "High Muffles", "Ladybower", "Lerwick", "Lough Navar", "Lullington Heath", "Market Harborough", "Narberth", "Rochester Stoke", "Sibton", "St Osyth", "Strathvaich", "Weybourne", "Wicken Fen", "Yarner Wood"})
        Me.CBoxAreas.Location = New System.Drawing.Point(7, 30)
        Me.CBoxAreas.Name = "CBoxAreas"
        Me.CBoxAreas.Size = New System.Drawing.Size(220, 21)
        Me.CBoxAreas.TabIndex = 6
        '
        'PicBoxNext
        '
        Me.PicBoxNext.BackgroundImage = CType(resources.GetObject("PicBoxNext.BackgroundImage"),System.Drawing.Image)
        Me.PicBoxNext.Location = New System.Drawing.Point(7, 305)
        Me.PicBoxNext.Name = "PicBoxNext"
        Me.PicBoxNext.Size = New System.Drawing.Size(220, 50)
        Me.PicBoxNext.TabIndex = 5
        Me.PicBoxNext.TabStop = false
        '
        'CheckUseData
        '
        Me.CheckUseData.AutoSize = true
        Me.CheckUseData.Checked = true
        Me.CheckUseData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckUseData.Location = New System.Drawing.Point(7, 7)
        Me.CheckUseData.Name = "CheckUseData"
        Me.CheckUseData.Size = New System.Drawing.Size(112, 17)
        Me.CheckUseData.TabIndex = 4
        Me.CheckUseData.Text = "Rate this category"
        Me.CheckUseData.UseVisualStyleBackColor = true
        '
        'Pollution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 362)
        Me.Controls.Add(Me.PicBoxAbout)
        Me.Controls.Add(Me.CBoxAreas)
        Me.Controls.Add(Me.PicBoxNext)
        Me.Controls.Add(Me.CheckUseData)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Pollution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Environment"
        CType(Me.PicBoxAbout,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicBoxNext,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents PicBoxAbout As System.Windows.Forms.PictureBox
    Friend WithEvents CBoxAreas As System.Windows.Forms.ComboBox
    Friend WithEvents PicBoxNext As System.Windows.Forms.PictureBox
    Friend WithEvents CheckUseData As System.Windows.Forms.CheckBox
End Class
