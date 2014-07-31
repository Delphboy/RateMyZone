<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crime))
        Me.CheckUseData = New System.Windows.Forms.CheckBox()
        Me.PicBoxNext = New System.Windows.Forms.PictureBox()
        Me.CBoxAreas = New System.Windows.Forms.ComboBox()
        Me.PicBoxAbout = New System.Windows.Forms.PictureBox()
        CType(Me.PicBoxNext,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PicBoxAbout,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'CheckUseData
        '
        Me.CheckUseData.AutoSize = true
        Me.CheckUseData.Checked = true
        Me.CheckUseData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckUseData.Location = New System.Drawing.Point(12, 12)
        Me.CheckUseData.Name = "CheckUseData"
        Me.CheckUseData.Size = New System.Drawing.Size(112, 17)
        Me.CheckUseData.TabIndex = 0
        Me.CheckUseData.Text = "Rate this category"
        Me.CheckUseData.UseVisualStyleBackColor = true
        '
        'PicBoxNext
        '
        Me.PicBoxNext.BackgroundImage = CType(resources.GetObject("PicBoxNext.BackgroundImage"),System.Drawing.Image)
        Me.PicBoxNext.Location = New System.Drawing.Point(12, 310)
        Me.PicBoxNext.Name = "PicBoxNext"
        Me.PicBoxNext.Size = New System.Drawing.Size(220, 50)
        Me.PicBoxNext.TabIndex = 1
        Me.PicBoxNext.TabStop = false
        '
        'CBoxAreas
        '
        Me.CBoxAreas.FormattingEnabled = true
        Me.CBoxAreas.Items.AddRange(New Object() {"Derbyshire", "Leicestershire", "Lincolnshire", "Northamptonshire", "Nottinghamshire", "Bedfordshire", "Cambridgeshire", "Essex", "Hertfordshire", "Norfolk", "Suffolk", "London City of", "Metropolitan Police", "British Transport Police(2006)", "Cleveland", "Durham", "Northumbria", "Cheshire", "Cumbria", "Greater Manchester", "Lancashire", "Merseyside", "Hampshire", "Hampshire", "Kent", "Surrey", "Sussex", "Thames Valley", "Avon & Somerset", "Devon & Cornwall", "Dorset", "Gloucestershire", "Wiltshire", "Dyfed-Powys", "Gwent", "North Wales", "South Wales", "Staffordshire", "Warwickshire", "West Mercia", "West Midlands", "Humberside", "North Yorkshire", "South Yorkshire", "West Yorkshire", "Wiltshire", "Derbyshire", "Leicestershire", "Lincolnshire", "Northamptonshire", "Nottinghamshire", "Bedfordshire", "Cambridgeshire", "Essex", "Hertfordshire", "Norfolk", "Suffolk", "London City of", "Metropolitan Police", "British Transport Police(2006)", "Cleveland", "Durham", "Northumbria", "Cheshire", "Cumbria", "Greater Manchester", "Lancashire", "Merseyside", "Hampshire", "Merseyside", "Hampshire", "Kent", "Surrey", "Sussex", "Thames Valley", "Avon & Somerset", "Devon & Cornwall", "Dorset", "Gloucestershire", "Wiltshire", "Dyfed-Powys", "Gwent", "North Wales", "South Wales", "Staffordshire", "Warwickshire", "West Mercia", "West Midlands", "Humberside", "North Yorkshire", "South Yorkshire", "West Yorkshire", "Durham", "Wiltshire"})
        Me.CBoxAreas.Location = New System.Drawing.Point(12, 35)
        Me.CBoxAreas.Name = "CBoxAreas"
        Me.CBoxAreas.Size = New System.Drawing.Size(220, 21)
        Me.CBoxAreas.TabIndex = 2
        '
        'PicBoxAbout
        '
        Me.PicBoxAbout.BackgroundImage = Global.Rate_my_area.My.Resources.Resources.Crime
        Me.PicBoxAbout.Location = New System.Drawing.Point(12, 62)
        Me.PicBoxAbout.Name = "PicBoxAbout"
        Me.PicBoxAbout.Size = New System.Drawing.Size(220, 240)
        Me.PicBoxAbout.TabIndex = 3
        Me.PicBoxAbout.TabStop = false
        '
        'Crime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 372)
        Me.Controls.Add(Me.PicBoxAbout)
        Me.Controls.Add(Me.CBoxAreas)
        Me.Controls.Add(Me.PicBoxNext)
        Me.Controls.Add(Me.CheckUseData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "Crime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crime"
        CType(Me.PicBoxNext,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PicBoxAbout,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents CheckUseData As System.Windows.Forms.CheckBox
    Friend WithEvents PicBoxNext As System.Windows.Forms.PictureBox
    Friend WithEvents CBoxAreas As System.Windows.Forms.ComboBox
    Friend WithEvents PicBoxAbout As System.Windows.Forms.PictureBox
End Class
