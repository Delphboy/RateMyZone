<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Health
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Health))
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
        Me.PicBoxAbout.BackgroundImage = Global.Rate_my_area.My.Resources.Resources.Health
        Me.PicBoxAbout.Location = New System.Drawing.Point(7, 57)
        Me.PicBoxAbout.Name = "PicBoxAbout"
        Me.PicBoxAbout.Size = New System.Drawing.Size(220, 240)
        Me.PicBoxAbout.TabIndex = 7
        Me.PicBoxAbout.TabStop = false
        '
        'CBoxAreas
        '
        Me.CBoxAreas.FormattingEnabled = true
        Me.CBoxAreas.Items.AddRange(New Object() {"Ashton & Leigh & Wigan", "Barking & Dagenham", "Barnet", "Barnsley", "Bassetlaw", "Bath & North East Somerset", "Bedfordshire", "Berkshire East", "Berkshire West", "Bexley Care Trust", "Birmingham East & North", "Blackburn", "Blackpool", "Bolton", "Bournemouth & Poole", "Bradford & Airedale", "Brent Teaching", "Brighton & Hove City", "Bristol", "Bromley", "Buckinghamshire", "Bury", "Calderdale", "Cambridgeshire", "Camden", "Central & Eastern Cheshire", "Central Lancashire", "City & Hackney Teaching", "Cornwall & Isles Of Scilly", "County Durham", "Coventry Teaching", "Croydon", "Cumbria", "Darlington", "Derby City", "Derbyshire County", "Devon", "Doncaster", "Dorset", "Dudley", "Ealing", "East Lancashire", "East Midlands", "East of England", "East Riding of Yorkshire", "East Sussex Downs & Weald", "Eastern & Coastal Kent", "Enfield", "Gateshead", "Gloucestershire", "Great Yarmouth & Waveney", "Greenwich Teaching", "Halton & St. Helens", "Hammersmith & Fulham", "Hampshire", "Haringey Teaching", "Harrow", "Hartlepool", "Hastings & Rother", "Havering", "Heart of Birmingham Teaching", "Herefordshire", "Hertfordshire", "Heywood & Middleton & Rochdale", "Hillingdon", "Hounslow", "Hull", "Isle of Wight", "Islington", "Kensington & Chelsea", "Kingston", "Kirklees", "Knowsley", "Lambeth", "Leeds", "Leicester City", "Leicestershire County & Rutland", "Lewisham", "Lincolnshire", "Liverpool", "London", "London", "Luton", "Manchester", "Medway", "Mid Essex", "Middlesbrough", "Milton Keynes", "Newcastle", "Newham", "Norfolk", "North East", "North East Essex", "North East Lincolnshire", "North Lancashire", "North Lincolnshire", "North Somerset", "North Staffordshire", "North Tyneside", "North West", "North Yorkshire & York", "Northampton", "Northumberland Care Trust", "Nottingham City", "Nottinghamshire County", "Oldham", "Oxfordshire", "Peterborough", "Plymouth Teaching", "Portsmouth City Teaching", "Redbridge", "Redcar & Cleveland", "Richmond & Twickenham", "Rotherham", "Salford", "Sandwell", "Sefton", "Sheffield", "Shropshire County", "Solihull", "Somerset", "South Birmingham", "South Central", "South East", "South East Coast", "South East Essex", "South Gloucestershire", "South Staffordshire", "South Tyneside", "South West", "South West Essex", "Southampton City", "Southwark", "Stockport", "Stockton-On-Tees Teaching", "Stoke on Trent", "Suffolk", "Sunderland Teaching", "Surrey", "Sutton & Merton", "Swindon", "Tameside & Glossop", "Telford & Wrekin", "Torbay Care Trust", "Tower Hamlets", "Trafford", "Wakefield District", "Walsall Teaching", "Waltham Forest", "Wandsworth", "Warrington", "Warwickshire", "West Essex", "West Kent", "West Midlands", "West Midlands", "West Sussex", "Western Cheshire", "Westminster", "Wiltshire", "Wirral", "Wolverhampton City", "Worcestershire", "Yorkshire and the Humber"})
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
        'Health
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
        Me.Name = "Health"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Health"
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
