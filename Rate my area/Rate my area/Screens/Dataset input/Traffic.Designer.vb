<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Traffic
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Traffic))
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
        Me.PicBoxAbout.BackgroundImage = CType(resources.GetObject("PicBoxAbout.BackgroundImage"),System.Drawing.Image)
        Me.PicBoxAbout.Location = New System.Drawing.Point(7, 57)
        Me.PicBoxAbout.Name = "PicBoxAbout"
        Me.PicBoxAbout.Size = New System.Drawing.Size(220, 240)
        Me.PicBoxAbout.TabIndex = 7
        Me.PicBoxAbout.TabStop = false
        '
        'CBoxAreas
        '
        Me.CBoxAreas.FormattingEnabled = true
        Me.CBoxAreas.Items.AddRange(New Object() {"Aberdeen City", "Aberdeenshire", "Angus", "Argyll", "Barking and Dagenham", "Barnet", "Barnsley", "Bath and North East Somerset", "Bedford", "Bexley", "Birmingham", "Blackburn with Darwen", "Blackpool", "Blaenau Gwent", "Bolton", "Bournemouth", "Bracknell Forest", "Bradford", "Brent", "Bridgend", "Brighton and Hove", "Bromley", "Buckinghamshire", "Bury", "Caerphilly", "Calderdale", "Cambridgeshire", "Camden", "Cardiff", "Carmarthenshire", "Central Bedfordshire", "Ceredigion", "City of Bristol", "City of Edinburgh", "City of Kingston upon Hull", "City of London", "Clackmannanshire", "Comhairle nan Eilean Siar", "Conwy", "Cornwall excluding Isles of Scilly", "County of Herefordshire", "Coventry", "Croydon", "Cumbria", "Darlington", "Denbighshire", "Derby", "Derbyshire", "Devon", "Doncaster", "Dorset", "Dudley", "Dumfries", "Dundee City", "Durham", "Ealing", "East Ayrshire", "East Cheshire", "East Dunbartonshire", "East Lothian", "East Renfrewshire", "East Riding of Yorkshire", "East Sussex", "Enfield", "Essex", "Falkirk", "Fife", "Flintshire", "Gateshead", "Glasgow City", "Gloucestershire", "Greenwich", "Gwynedd", "Hackney", "Halton", "Hammersmith and Fulham", "Hampshire", "Haringey", "Harrow", "Hartlepool", "Havering", "Hertfordshire", "Highland", "Hillingdon", "Hounslow", "Inverclyde", "Isle of Anglesey", "Isle of Wight", "Isles of Scilly", "Islington", "Kensington and Chelsea", "Kent", "Kingston upon Thames", "Kirklees", "Knowsley", "Lambeth", "Lancashire", "Leeds", "Leicester", "Leicestershire", "Lewisham", "Lincolnshire", "Liverpool", "Luton", "Manchester", "Medway", "Merthyr Tydfil", "Merton", "Middlesbrough", "Midlothian", "Milton Keynes", "Monmouthshire", "Moray", "Neath Port Talbot", "Newcastle upon Tyne", "Newham", "Newport", "Norfolk", "North Ayrshire", "North East Lincolnshire", "North Lanarkshire", "North Lincolnshire", "North Somerset", "North Tyneside", "North Yorkshire", "Northamptonshire", "Northumberland", "Nottingham", "Nottinghamshire", "Oldham", "Orkney Islands", "Oxfordshire", "Pembrokeshire", "Perth", "Peterborough", "Plymouth", "Poole", "Portsmouth", "Powys", "Reading", "Redbridge", "Redcar and Cleveland", "Renfrewshire", "Rhondda/Cynon/Taff", "Richmond upon Thames", "Rochdale", "Rotherham", "Rutland", "Salford", "Sandwell", "Scottish Borders", "Sefton", "Sheffield", "Shetland Islands", "Shropshire", "Slough", "Solihull", "Somerset", "South Ayrshire", "South Gloucestershire", "South Lanarkshire", "South Tyneside", "Southampton", "Southend-on-Sea", "Southwark", "St. Helens", "Staffordshire", "Stirling", "Stockport", "Stockton-on-Tees", "Stoke-on-Trent", "Suffolk", "Sunderland", "Surrey", "Sutton", "Swansea", "Swindon", "Tameside", "Telford and Wrekin", "The Vale of Glamorgan", "Thurrock", "Torbay", "Torfaen", "Tower Hamlets", "Trafford", "Wakefield", "Walsall", "Waltham Forest", "Wandsworth", "Warrington", "Warwickshire", "West Berkshire", "West Cheshire", "West Dunbartonshire", "West Lothian", "West Sussex", "Westminster", "Wigan", "Wiltshire", "Windsor and Maidenhead", "Wirral", "Wokingham", "Wolverhampton", "Worcestershire", "Wrexham", "York"})
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
        'Traffic
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
        Me.Name = "Traffic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Traffic"
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
