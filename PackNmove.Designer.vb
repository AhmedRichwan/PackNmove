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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lavender
        Me.Label3.Location = New System.Drawing.Point(9, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Room case finder v 1.0 Beta"
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
        Me.btnPickFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPickFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnPickFile.BackColor = System.Drawing.Color.DarkCyan
        Me.btnPickFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPickFile.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPickFile.ForeColor = System.Drawing.SystemColors.Window
        Me.btnPickFile.Location = New System.Drawing.Point(397, 12)
        Me.btnPickFile.Name = "btnPickFile"
        Me.btnPickFile.Size = New System.Drawing.Size(131, 33)
        Me.btnPickFile.TabIndex = 12
        Me.btnPickFile.Text = "Pick File"
        Me.btnPickFile.UseVisualStyleBackColor = False
        '
        'tfilepath
        '
        Me.tfilepath.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tfilepath.ForeColor = System.Drawing.Color.Navy
        Me.tfilepath.Location = New System.Drawing.Point(223, 51)
        Me.tfilepath.Multiline = True
        Me.tfilepath.Name = "tfilepath"
        Me.tfilepath.ReadOnly = True
        Me.tfilepath.Size = New System.Drawing.Size(402, 33)
        Me.tfilepath.TabIndex = 27
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(794, 412)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(78, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'findtxt
        '
        Me.findtxt.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.findtxt.ForeColor = System.Drawing.Color.Navy
        Me.findtxt.Location = New System.Drawing.Point(387, 128)
        Me.findtxt.Name = "findtxt"
        Me.findtxt.Size = New System.Drawing.Size(103, 26)
        Me.findtxt.TabIndex = 30
        Me.findtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnfindcase
        '
        Me.btnfindcase.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor
        Me.btnfindcase.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnfindcase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnfindcase.BackColor = System.Drawing.Color.DarkCyan
        Me.btnfindcase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnfindcase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfindcase.ForeColor = System.Drawing.SystemColors.Window
        Me.btnfindcase.Location = New System.Drawing.Point(496, 125)
        Me.btnfindcase.Name = "btnfindcase"
        Me.btnfindcase.Size = New System.Drawing.Size(115, 33)
        Me.btnfindcase.TabIndex = 29
        Me.btnfindcase.Text = "Find Case"
        Me.btnfindcase.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Navy
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 30
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomN, Me.TenantName, Me.CivilID, Me.MoveinDate, Me.DueDate, Me.Authorization, Me.Status})
        Me.DataGridView1.GridColor = System.Drawing.Color.LightSeaGreen
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DataGridView1.Location = New System.Drawing.Point(12, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 60
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(860, 174)
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
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(631, 55)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(212, 20)
        Me.CheckBox1.TabIndex = 32
        Me.CheckBox1.Text = "Remember this file next time"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Ocean
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(884, 461)
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
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(900, 500)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "Ocean"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PackNmove"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnPickFile As Button
    Friend WithEvents tfilepath As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents findtxt As TextBox
    Friend WithEvents btnfindcase As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RoomN As DataGridViewTextBoxColumn
    Friend WithEvents TenantName As DataGridViewTextBoxColumn
    Friend WithEvents CivilID As DataGridViewTextBoxColumn
    Friend WithEvents MoveinDate As DataGridViewTextBoxColumn
    Friend WithEvents DueDate As DataGridViewTextBoxColumn
    Friend WithEvents Authorization As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
End Class
