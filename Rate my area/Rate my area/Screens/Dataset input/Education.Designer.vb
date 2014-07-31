<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Education
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Education))
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
        Me.PicBoxAbout.BackgroundImage = Global.Rate_my_area.My.Resources.Resources.Education
        Me.PicBoxAbout.Location = New System.Drawing.Point(7, 57)
        Me.PicBoxAbout.Name = "PicBoxAbout"
        Me.PicBoxAbout.Size = New System.Drawing.Size(220, 240)
        Me.PicBoxAbout.TabIndex = 7
        Me.PicBoxAbout.TabStop = false
        '
        'CBoxAreas
        '
        Me.CBoxAreas.FormattingEnabled = true
        Me.CBoxAreas.Items.AddRange(New Object() {"Anglia Polytechnic University", "Aston University", "Bath Spa University College", "Bell College", "Birkbeck College", "Birmingham College of Food- Tourism and Creative Studies", "Bishop Grosseteste College", "Bolton Institute of Higher Education", "Bournemouth University", "Brunel University", "Buckinghamshire Chilterns University College", "Canterbury Christ Church University College", "Cardiff University", "Central School of Speech and Drama", "City University", "College of St Mark and St John", "Conservatoire for Dance and Drama", "Courtauld Institute of Art", "Coventry University", "Cranfield University", "Cumbria Institute of the Arts", "Dartington College of Arts", "De Montfort University", "Edge Hill College of Higher Education", "Edinburgh College of Art", "Falmouth College of Arts", "Glasgow Caledonian University", "Glasgow School of Art", "Goldsmiths College", "Harper Adams University College", "Heriot-Watt University", "Homerton College", "Imperial College of Science & Technology & Medicine", "Institute of Education", "Kent Institute of Art & Design", "King's College London", "Kingston University", "Leeds Metropolitan University", "Liverpool Hope University College", "Liverpool John Moores University", "London Business School", "London Metropolitan University", "London School of Economics and Political Science", "London School of Hygiene & Tropical Medicine", "London South Bank University", "Loughborough University", "Middlesex University", "Napier University", "Newman College of HE", "Norwich School of Art and Design", "Oxford Brookes University", "Queen Margaret University College- Edinburgh", "Queen Mary and Westfield College", "Ravensbourne College of Design and Communication", "Roehampton University", "Rose Bruford College", "Royal Academy of Music", "Royal Agricultural College", "Royal College of Art", "Royal College of Music", "Royal Holloway and Bedford New College", "Royal Northern College of Music", "Royal Welsh College of Music and Drama", "Scottish Agricultural College", "Sheffield Hallam University", "Southampton Institute", "St George's Hospital Medical School", "St Martin's College", "St Mary's College", "St Mary's University College", "Staffordshire University", "Stranmillis University College", "Swansea Institute of Higher Education", "Thames Valley University", "The Arts Institute at Bournemouth", "The Institute of Cancer Research", "The Manchester Metropolitan University", "The North-East Wales Institute of Higher Education", "The Nottingham Trent University", "The Open University", "The Queen's University of Belfast", "The Robert Gordon University", "The Royal College of Nursing", "The Royal Scottish Academy of Music and Drama", "The Royal Veterinary College", "The School of Oriental and African Studies", "The School of Pharmacy", "The Surrey Institute of Art and Design University College", "The University of Aberdeen", "The University of Bath", "The University of Birmingham", "The University of Bradford", "The University of Brighton", "The University of Bristol", "The University of Cambridge", "The University of Central Lancashire", "The University of Dundee", "The University of East Anglia", "The University of East London", "The University of Edinburgh", "The University of Essex", "The University of Exeter", "The University of Glasgow", "The University of Greenwich", "The University of Huddersfield", "The University of Hull", "The University of Keele", "The University of Kent", "The University of Lancaster", "The University of Leeds", "The University of Leicester", "The University of Lincoln", "The University of Liverpool", "The University of Manchester Institute of Science & Technology", "The University of Newcastle-upon-Tyne", "The University of Northumbria at Newcastle", "The University of Nottingham", "The University of Oxford", "The University of Paisley", "The University of Plymouth", "The University of Portsmouth", "The University of Reading", "The University of Salford", "The University of Sheffield", "The University of Southampton", "The University of St Andrews", "The University of Stirling", "The University of Strathclyde", "The University of Sunderland", "The University of Surrey", "The University of Sussex", "The University of Teesside", "The University of Wales- Lampeter", "The University of Wales- Newport", "The University of Warwick", "The University of Westminster", "The University of Wolverhampton", "The University of York", "Trinity and All Saints College", "Trinity College- Carmarthen", "Trinity College of Music", "UHI Millennium Institute", "University College Chester", "University College Chichester", "University College London", "University College Northampton", "University College Winchester", "University College Worcester", "University of Abertay Dundee", "University of Central England in Birmingham", "University of Derby", "University of Durham", "University of Glamorgan", "University of Gloucestershire", "University of Hertfordshire", "University of London (Institutes and activities)", "University of Luton", "University of Manchester", "University of the Arts- London", "University of the West of England-Bristol", "University of Ulster", "University of Wales- Aberystwyth", "University of Wales- Bangor", "University of Wales College of Medicine", "University of Wales Institute- Cardiff", "University of Wales- Swansea", "Wimbledon School of Art", "Writtle College", "York St John College"})
        Me.CBoxAreas.Location = New System.Drawing.Point(7, 30)
        Me.CBoxAreas.Name = "CBoxAreas"
        Me.CBoxAreas.Size = New System.Drawing.Size(220, 21)
        Me.CBoxAreas.TabIndex = 6
        '
        'PicBoxNext
        '
        Me.PicBoxNext.BackgroundImage = CType(resources.GetObject("PicBoxNext.BackgroundImage"), System.Drawing.Image)
        Me.PicBoxNext.Location = New System.Drawing.Point(7, 305)
        Me.PicBoxNext.Name = "PicBoxNext"
        Me.PicBoxNext.Size = New System.Drawing.Size(220, 50)
        Me.PicBoxNext.TabIndex = 5
        Me.PicBoxNext.TabStop = False
        '
        'CheckUseData
        '
        Me.CheckUseData.AutoSize = True
        Me.CheckUseData.Checked = True
        Me.CheckUseData.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckUseData.Location = New System.Drawing.Point(7, 7)
        Me.CheckUseData.Name = "CheckUseData"
        Me.CheckUseData.Size = New System.Drawing.Size(112, 17)
        Me.CheckUseData.TabIndex = 4
        Me.CheckUseData.Text = "Rate this category"
        Me.CheckUseData.UseVisualStyleBackColor = true
        '
        'Education
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
        Me.Name = "Education"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Education"
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
