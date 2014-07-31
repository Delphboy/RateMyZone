<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test_UI
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Items.AddRange(New Object() {"Aberdeen City", "Aberdeenshire", "Angus", "Argyll", "Barking and Dagenham", "Barnet", "Barnsley", "Bath and North East Somerset", "Bedford", "Bexley", "Birmingham", "Blackburn with Darwen", "Blackpool", "Blaenau Gwent", "Bolton", "Bournemouth", "Bracknell Forest", "Bradford", "Brent", "Bridgend", "Brighton and Hove", "Bromley", "Buckinghamshire", "Bury", "Caerphilly", "Calderdale", "Cambridgeshire", "Camden", "Cardiff", "Carmarthenshire", "Central Bedfordshire", "Ceredigion", "City of Bristol", "City of Edinburgh", "City of Kingston upon Hull", "City of London", "Clackmannanshire", "Comhairle nan Eilean Siar", "Conwy", "Cornwall excluding Isles of Scilly", "County of Herefordshire", "Coventry", "Croydon", "Cumbria", "Darlington", "Denbighshire", "Derby", "Derbyshire", "Devon", "Doncaster", "Dorset", "Dudley", "Dumfries", "Dundee City", "Durham", "Ealing", "East Ayrshire", "East Cheshire", "East Dunbartonshire", "East Lothian", "East Renfrewshire", "East Riding of Yorkshire", "East Sussex", "Enfield", "Essex", "Falkirk", "Fife", "Flintshire", "Gateshead", "Glasgow City", "Gloucestershire", "Greenwich", "Gwynedd", "Hackney", "Halton", "Hammersmith and Fulham", "Hampshire", "Haringey", "Harrow", "Hartlepool", "Havering", "Hertfordshire", "Highland", "Hillingdon", "Hounslow", "Inverclyde", "Isle of Anglesey", "Isle of Wight", "Isles of Scilly", "Islington", "Kensington and Chelsea", "Kent", "Kingston upon Thames", "Kirklees", "Knowsley", "Lambeth", "Lancashire", "Leeds", "Leicester", "Leicestershire", "Lewisham", "Lincolnshire", "Liverpool", "Luton", "Manchester", "Medway", "Merthyr Tydfil", "Merton", "Middlesbrough", "Midlothian", "Milton Keynes", "Monmouthshire", "Moray", "Neath Port Talbot", "Newcastle upon Tyne", "Newham", "Newport", "Norfolk", "North Ayrshire", "North East Lincolnshire", "North Lanarkshire", "North Lincolnshire", "North Somerset", "North Tyneside", "North Yorkshire", "Northamptonshire", "Northumberland", "Nottingham", "Nottinghamshire", "Oldham", "Orkney Islands", "Oxfordshire", "Pembrokeshire", "Perth", "Peterborough", "Plymouth", "Poole", "Portsmouth", "Powys", "Reading", "Redbridge", "Redcar and Cleveland", "Renfrewshire", "Rhondda/Cynon/Taff", "Richmond upon Thames", "Rochdale", "Rotherham", "Rutland", "Salford", "Sandwell", "Scottish Borders", "Sefton", "Sheffield", "Shetland Islands", "Shropshire", "Slough", "Solihull", "Somerset", "South Ayrshire", "South Gloucestershire", "South Lanarkshire", "South Tyneside", "Southampton", "Southend-on-Sea", "Southwark", "St. Helens", "Staffordshire", "Stirling", "Stockport", "Stockton-on-Tees", "Stoke-on-Trent", "Suffolk", "Sunderland", "Surrey", "Sutton", "Swansea", "Swindon", "Tameside", "Telford and Wrekin", "The Vale of Glamorgan", "Thurrock", "Torbay", "Torfaen", "Tower Hamlets", "Trafford", "Wakefield", "Walsall", "Waltham Forest", "Wandsworth", "Warrington", "Warwickshire", "West Berkshire", "West Cheshire", "West Dunbartonshire", "West Lothian", "West Sussex", "Westminster", "Wigan", "Wiltshire", "Windsor and Maidenhead", "Wirral", "Wokingham", "Wolverhampton", "Worcestershire", "Wrexham", "York"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(260, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 39)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Test_UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Test_UI"
        Me.Text = "Test_UI"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
