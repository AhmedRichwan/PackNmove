<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ocean
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ocean))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnPickFile = New System.Windows.Forms.Button()
        Me.tfilepath = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.findtxt = New System.Windows.Forms.TextBox()
        Me.btnfindcase = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RoomN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenantName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MoveinDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DueDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Authorization = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Ladding = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.tbvisitnote = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.dtb1 = New System.Windows.Forms.TextBox()
        Me.dtb7 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dtb6 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.dtb5 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.dtb4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dtb3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtb2 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PrintLog = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(31, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Rcase v 1.3 Beta"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(34, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnPickFile
        '
        Me.btnPickFile.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.btnPickFile.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnPickFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPickFile.BackColor = System.Drawing.Color.DarkCyan
        Me.btnPickFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPickFile.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickFile.ForeColor = System.Drawing.SystemColors.Window
        Me.btnPickFile.Location = New System.Drawing.Point(399, 12)
        Me.btnPickFile.Name = "btnPickFile"
        Me.btnPickFile.Size = New System.Drawing.Size(131, 33)
        Me.btnPickFile.TabIndex = 12
        Me.btnPickFile.Text = "Pick File / اختر ملف"
        Me.btnPickFile.UseVisualStyleBackColor = False
        '
        'tfilepath
        '
        Me.tfilepath.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tfilepath.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfilepath.ForeColor = System.Drawing.Color.Navy
        Me.tfilepath.Location = New System.Drawing.Point(264, 51)
        Me.tfilepath.Multiline = True
        Me.tfilepath.Name = "tfilepath"
        Me.tfilepath.ReadOnly = True
        Me.tfilepath.Size = New System.Drawing.Size(402, 33)
        Me.tfilepath.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(765, 429)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(107, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'findtxt
        '
        Me.findtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.findtxt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.findtxt.ForeColor = System.Drawing.Color.Navy
        Me.findtxt.Location = New System.Drawing.Point(428, 118)
        Me.findtxt.Name = "findtxt"
        Me.findtxt.Size = New System.Drawing.Size(238, 26)
        Me.findtxt.TabIndex = 30
        Me.findtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnfindcase
        '
        Me.btnfindcase.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.btnfindcase.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnfindcase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnfindcase.BackColor = System.Drawing.Color.DarkCyan
        Me.btnfindcase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnfindcase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindcase.ForeColor = System.Drawing.SystemColors.Window
        Me.btnfindcase.Location = New System.Drawing.Point(264, 115)
        Me.btnfindcase.Name = "btnfindcase"
        Me.btnfindcase.Size = New System.Drawing.Size(158, 33)
        Me.btnfindcase.TabIndex = 29
        Me.btnfindcase.Text = "Find Case / ابحث هنا"
        Me.btnfindcase.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomN, Me.TenantName, Me.CivilID, Me.MoveinDate, Me.DueDate, Me.Authorization, Me.Status})
        Me.DataGridView1.GridColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DataGridView1.Location = New System.Drawing.Point(12, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 60
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(854, 266)
        Me.DataGridView1.TabIndex = 31
        '
        'RoomN
        '
        Me.RoomN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.RoomN.DataPropertyName = "RoomN"
        Me.RoomN.HeaderText = "Room N"
        Me.RoomN.Name = "RoomN"
        Me.RoomN.ReadOnly = True
        Me.RoomN.Width = 80
        '
        'TenantName
        '
        Me.TenantName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TenantName.DataPropertyName = "TenantName"
        Me.TenantName.HeaderText = "TenantName"
        Me.TenantName.Name = "TenantName"
        Me.TenantName.ReadOnly = True
        '
        'CivilID
        '
        Me.CivilID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CivilID.DataPropertyName = "CivilID"
        Me.CivilID.HeaderText = "Civil ID"
        Me.CivilID.Name = "CivilID"
        Me.CivilID.ReadOnly = True
        '
        'MoveinDate
        '
        Me.MoveinDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.MoveinDate.DataPropertyName = "MoveinDate"
        Me.MoveinDate.HeaderText = "Move in Date"
        Me.MoveinDate.Name = "MoveinDate"
        Me.MoveinDate.ReadOnly = True
        '
        'DueDate
        '
        Me.DueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DueDate.DataPropertyName = "DueDate"
        Me.DueDate.HeaderText = "Due Date"
        Me.DueDate.Name = "DueDate"
        Me.DueDate.ReadOnly = True
        '
        'Authorization
        '
        Me.Authorization.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Authorization.DataPropertyName = "Authorization"
        Me.Authorization.HeaderText = "Authorization"
        Me.Authorization.Name = "Authorization"
        Me.Authorization.ReadOnly = True
        '
        'Status
        '
        Me.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Width = 73
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(246, 89)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(433, 20)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Remember this file next time. افتح نفس الملف في المرة القادمة."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Ladding)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.tbvisitnote)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.dtb1)
        Me.GroupBox1.Controls.Add(Me.dtb7)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.dtb6)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.dtb5)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.dtb4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.dtb3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtb2)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(860, 280)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details / تفاصيل"
        Me.GroupBox1.Visible = False
        '
        'Button10
        '
        Me.Button10.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button10.BackColor = System.Drawing.Color.OrangeRed
        Me.Button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Transparent
        Me.Button10.Location = New System.Drawing.Point(340, 242)
        Me.Button10.Name = "Button10"
        Me.Button10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button10.Size = New System.Drawing.Size(244, 27)
        Me.Button10.TabIndex = 68
        Me.Button10.TabStop = False
        Me.Button10.Text = "تسجيل خروج زيارة / End visit time"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Ladding
        '
        Me.Ladding.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ladding.AutoSize = True
        Me.Ladding.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ladding.ForeColor = System.Drawing.Color.Yellow
        Me.Ladding.Location = New System.Drawing.Point(160, 250)
        Me.Ladding.Name = "Ladding"
        Me.Ladding.Size = New System.Drawing.Size(172, 16)
        Me.Ladding.TabIndex = 67
        Me.Ladding.Text = "جاري التسجيل / Adding..."
        Me.Ladding.Visible = False
        '
        'CheckBox2
        '
        Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.White
        Me.CheckBox2.Location = New System.Drawing.Point(530, 211)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(324, 20)
        Me.CheckBox2.TabIndex = 34
        Me.CheckBox2.Text = "اضافة ملاحظة الى سجل الزيارة/ Add Visit note"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'tbvisitnote
        '
        Me.tbvisitnote.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.tbvisitnote.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.tbvisitnote.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbvisitnote.ForeColor = System.Drawing.Color.Navy
        Me.tbvisitnote.Location = New System.Drawing.Point(31, 201)
        Me.tbvisitnote.Multiline = True
        Me.tbvisitnote.Name = "tbvisitnote"
        Me.tbvisitnote.ReadOnly = True
        Me.tbvisitnote.Size = New System.Drawing.Size(493, 35)
        Me.tbvisitnote.TabIndex = 66
        Me.tbvisitnote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button4
        '
        Me.Button4.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button4.BackColor = System.Drawing.Color.DarkCyan
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.Window
        Me.Button4.Location = New System.Drawing.Point(6, 242)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(148, 32)
        Me.Button4.TabIndex = 65
        Me.Button4.Text = "Back/رجوع"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Window
        Me.Button3.Location = New System.Drawing.Point(600, 242)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(244, 27)
        Me.Button3.TabIndex = 64
        Me.Button3.Text = "تسجيل دخول زيارة / Start visit time"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'dtb1
        '
        Me.dtb1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtb1.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtb1.ForeColor = System.Drawing.Color.Navy
        Me.dtb1.Location = New System.Drawing.Point(277, 16)
        Me.dtb1.Name = "dtb1"
        Me.dtb1.ReadOnly = True
        Me.dtb1.Size = New System.Drawing.Size(122, 26)
        Me.dtb1.TabIndex = 63
        Me.dtb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dtb7
        '
        Me.dtb7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtb7.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dtb7.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtb7.ForeColor = System.Drawing.Color.Navy
        Me.dtb7.Location = New System.Drawing.Point(605, 164)
        Me.dtb7.Name = "dtb7"
        Me.dtb7.ReadOnly = True
        Me.dtb7.Size = New System.Drawing.Size(151, 26)
        Me.dtb7.TabIndex = 62
        Me.dtb7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button5
        '
        Me.Button5.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button5.BackColor = System.Drawing.Color.DarkCyan
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(405, 163)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(194, 32)
        Me.Button5.TabIndex = 61
        Me.Button5.Text = "Status"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'dtb6
        '
        Me.dtb6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtb6.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dtb6.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtb6.ForeColor = System.Drawing.Color.Navy
        Me.dtb6.Location = New System.Drawing.Point(231, 88)
        Me.dtb6.Name = "dtb6"
        Me.dtb6.ReadOnly = True
        Me.dtb6.Size = New System.Drawing.Size(525, 26)
        Me.dtb6.TabIndex = 60
        Me.dtb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button6
        '
        Me.Button6.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button6.BackColor = System.Drawing.Color.DarkCyan
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.Enabled = False
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(31, 84)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(194, 32)
        Me.Button6.TabIndex = 59
        Me.Button6.Text = "Authorization"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'dtb5
        '
        Me.dtb5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtb5.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dtb5.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtb5.ForeColor = System.Drawing.Color.Navy
        Me.dtb5.Location = New System.Drawing.Point(605, 125)
        Me.dtb5.Name = "dtb5"
        Me.dtb5.ReadOnly = True
        Me.dtb5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtb5.Size = New System.Drawing.Size(151, 26)
        Me.dtb5.TabIndex = 58
        Me.dtb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button7
        '
        Me.Button7.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button7.BackColor = System.Drawing.Color.DarkCyan
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button7.Enabled = False
        Me.Button7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(405, 121)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(194, 32)
        Me.Button7.TabIndex = 57
        Me.Button7.Text = "DueDate"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'dtb4
        '
        Me.dtb4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtb4.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dtb4.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtb4.ForeColor = System.Drawing.Color.Navy
        Me.dtb4.Location = New System.Drawing.Point(231, 125)
        Me.dtb4.Name = "dtb4"
        Me.dtb4.ReadOnly = True
        Me.dtb4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtb4.Size = New System.Drawing.Size(168, 26)
        Me.dtb4.TabIndex = 56
        Me.dtb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.BackColor = System.Drawing.Color.DarkCyan
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(31, 123)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 32)
        Me.Button2.TabIndex = 55
        Me.Button2.Text = "MoveinDate"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dtb3
        '
        Me.dtb3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtb3.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dtb3.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtb3.ForeColor = System.Drawing.Color.Navy
        Me.dtb3.Location = New System.Drawing.Point(231, 165)
        Me.dtb3.Name = "dtb3"
        Me.dtb3.ReadOnly = True
        Me.dtb3.Size = New System.Drawing.Size(168, 26)
        Me.dtb3.TabIndex = 54
        Me.dtb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.DarkCyan
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(31, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 32)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "CivilID"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'dtb2
        '
        Me.dtb2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtb2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dtb2.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtb2.ForeColor = System.Drawing.Color.Navy
        Me.dtb2.Location = New System.Drawing.Point(231, 48)
        Me.dtb2.Name = "dtb2"
        Me.dtb2.ReadOnly = True
        Me.dtb2.Size = New System.Drawing.Size(525, 26)
        Me.dtb2.TabIndex = 52
        Me.dtb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button8
        '
        Me.Button8.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button8.BackColor = System.Drawing.Color.DarkCyan
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button8.Enabled = False
        Me.Button8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(31, 47)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(194, 32)
        Me.Button8.TabIndex = 51
        Me.Button8.Text = "TenantName"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button9.BackColor = System.Drawing.Color.DarkCyan
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button9.Enabled = False
        Me.Button9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(405, 13)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(188, 32)
        Me.Button9.TabIndex = 50
        Me.Button9.Text = "Case details /تفاصيل خزينة"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'PrintLog
        '
        Me.PrintLog.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.PrintLog.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PrintLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PrintLog.BackColor = System.Drawing.Color.DarkCyan
        Me.PrintLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PrintLog.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintLog.ForeColor = System.Drawing.SystemColors.Window
        Me.PrintLog.Location = New System.Drawing.Point(299, 434)
        Me.PrintLog.Name = "PrintLog"
        Me.PrintLog.Size = New System.Drawing.Size(306, 32)
        Me.PrintLog.TabIndex = 65
        Me.PrintLog.Text = "Print Today Visit Log / طباعة سجل زيارات اليوم"
        Me.PrintLog.UseVisualStyleBackColor = False
        '
        'Ocean
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(884, 472)
        Me.Controls.Add(Me.PrintLog)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.findtxt)
        Me.Controls.Add(Me.btnfindcase)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.tfilepath)
        Me.Controls.Add(Me.btnPickFile)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "Ocean"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PackNmove"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Protected WithEvents Label3 As Label
    Protected WithEvents PictureBox1 As PictureBox
    Protected WithEvents btnPickFile As Button
    Protected WithEvents tfilepath As TextBox
    Protected WithEvents PictureBox2 As PictureBox
    Protected WithEvents findtxt As TextBox
    Protected WithEvents btnfindcase As Button
    Protected WithEvents DataGridView1 As DataGridView
    Protected WithEvents RoomN As DataGridViewTextBoxColumn
    Protected WithEvents TenantName As DataGridViewTextBoxColumn
    Protected WithEvents CivilID As DataGridViewTextBoxColumn
    Protected WithEvents MoveinDate As DataGridViewTextBoxColumn
    Protected WithEvents DueDate As DataGridViewTextBoxColumn
    Protected WithEvents Authorization As DataGridViewTextBoxColumn
    Protected WithEvents Status As DataGridViewTextBoxColumn
    Protected WithEvents CheckBox1 As CheckBox
    Protected WithEvents GroupBox1 As GroupBox
    Protected WithEvents Button4 As Button
    Protected WithEvents Button3 As Button
    Protected WithEvents dtb1 As TextBox
    Protected WithEvents dtb7 As TextBox
    Protected WithEvents Button5 As Button
    Protected WithEvents dtb6 As TextBox
    Protected WithEvents Button6 As Button
    Protected WithEvents dtb5 As TextBox
    Protected WithEvents Button7 As Button
    Protected WithEvents dtb4 As TextBox
    Protected WithEvents Button2 As Button
    Protected WithEvents dtb3 As TextBox
    Protected WithEvents Button1 As Button
    Protected WithEvents dtb2 As TextBox
    Protected WithEvents Button8 As Button
    Protected WithEvents Button9 As Button
    Protected WithEvents tbvisitnote As TextBox
    Protected WithEvents CheckBox2 As CheckBox
    Protected WithEvents Ladding As Label
    Protected WithEvents PrintLog As Button
    Protected WithEvents Button10 As Button
End Class
