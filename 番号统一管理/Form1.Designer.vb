<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPlayer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboResoure = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dudAI = New System.Windows.Forms.DomainUpDown()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.dudBQ = New System.Windows.Forms.DomainUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtFan = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.status1 = New System.Windows.Forms.StatusStrip()
        Me.tsslblNowNum = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblReEdit = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslblAllNum = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.pbDisplay = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBView = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.fbdImports = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.status1.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRemark
        '
        Me.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRemark.Location = New System.Drawing.Point(0, 329)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(296, 324)
        Me.txtRemark.TabIndex = 7
        '
        'txtNum
        '
        Me.txtNum.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtNum.Location = New System.Drawing.Point(831, 18)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(120, 30)
        Me.txtNum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "主演："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(716, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "收录次数："
        '
        'txtPlayer
        '
        Me.txtPlayer.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtPlayer.Location = New System.Drawing.Point(329, 18)
        Me.txtPlayer.Name = "txtPlayer"
        Me.txtPlayer.Size = New System.Drawing.Size(120, 30)
        Me.txtPlayer.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(509, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "ID："
        '
        'cboResoure
        '
        Me.cboResoure.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cboResoure.FormattingEnabled = True
        Me.cboResoure.Location = New System.Drawing.Point(106, 57)
        Me.cboResoure.Name = "cboResoure"
        Me.cboResoure.Size = New System.Drawing.Size(120, 28)
        Me.cboResoure.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(254, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "类型："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "资源："
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtID.Location = New System.Drawing.Point(564, 18)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(120, 30)
        Me.txtID.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "番号："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(706, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "步兵|骑兵："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(477, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "AV|IV："
        '
        'dudAI
        '
        Me.dudAI.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dudAI.Location = New System.Drawing.Point(564, 56)
        Me.dudAI.Name = "dudAI"
        Me.dudAI.Size = New System.Drawing.Size(120, 30)
        Me.dudAI.TabIndex = 15
        '
        'cboType
        '
        Me.cboType.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(329, 57)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(120, 28)
        Me.cboType.TabIndex = 12
        '
        'dudBQ
        '
        Me.dudBQ.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dudBQ.Location = New System.Drawing.Point(831, 56)
        Me.dudBQ.Name = "dudBQ"
        Me.dudBQ.Size = New System.Drawing.Size(120, 30)
        Me.dudBQ.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.txtFan)
        Me.GroupBox2.Controls.Add(Me.dudBQ)
        Me.GroupBox2.Controls.Add(Me.cboType)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.dudAI)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNum)
        Me.GroupBox2.Controls.Add(Me.txtID)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cboResoure)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPlayer)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(982, 100)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'txtFan
        '
        Me.txtFan.Location = New System.Drawing.Point(106, 21)
        Me.txtFan.Name = "txtFan"
        Me.txtFan.Size = New System.Drawing.Size(120, 25)
        Me.txtFan.TabIndex = 19
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 100)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.status1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvList)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pbDisplay)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtRemark)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(982, 653)
        Me.SplitContainer1.SplitterDistance = 682
        Me.SplitContainer1.TabIndex = 21
        '
        'status1
        '
        Me.status1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.status1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslblNowNum, Me.tsslblReEdit, Me.tsslblAllNum})
        Me.status1.Location = New System.Drawing.Point(0, 624)
        Me.status1.Name = "status1"
        Me.status1.Size = New System.Drawing.Size(682, 29)
        Me.status1.TabIndex = 2
        Me.status1.Text = "StatusStrip1"
        '
        'tsslblNowNum
        '
        Me.tsslblNowNum.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslblNowNum.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tsslblNowNum.Name = "tsslblNowNum"
        Me.tsslblNowNum.Size = New System.Drawing.Size(222, 24)
        Me.tsslblNowNum.Spring = True
        Me.tsslblNowNum.Text = "本次输入个番号"
        '
        'tsslblReEdit
        '
        Me.tsslblReEdit.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslblReEdit.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tsslblReEdit.Name = "tsslblReEdit"
        Me.tsslblReEdit.Size = New System.Drawing.Size(222, 24)
        Me.tsslblReEdit.Spring = True
        Me.tsslblReEdit.Text = "重复输入个番号"
        '
        'tsslblAllNum
        '
        Me.tsslblAllNum.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslblAllNum.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.tsslblAllNum.Name = "tsslblAllNum"
        Me.tsslblAllNum.Size = New System.Drawing.Size(222, 24)
        Me.tsslblAllNum.Spring = True
        Me.tsslblAllNum.Text = "数据共有个番号"
        '
        'dgvList
        '
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvList.Location = New System.Drawing.Point(0, 0)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.RowTemplate.Height = 27
        Me.dgvList.Size = New System.Drawing.Size(682, 653)
        Me.dgvList.TabIndex = 0
        '
        'pbDisplay
        '
        Me.pbDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbDisplay.Location = New System.Drawing.Point(0, 0)
        Me.pbDisplay.Name = "pbDisplay"
        Me.pbDisplay.Size = New System.Drawing.Size(682, 653)
        Me.pbDisplay.TabIndex = 1
        Me.pbDisplay.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNext)
        Me.GroupBox1.Controls.Add(Me.btnPrevious)
        Me.GroupBox1.Controls.Add(Me.lblInfo)
        Me.GroupBox1.Controls.Add(Me.btnImport)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnBView)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Size = New System.Drawing.Size(296, 329)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnNext.Location = New System.Drawing.Point(203, 222)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(50, 50)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(43, 222)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(50, 50)
        Me.btnPrevious.TabIndex = 14
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Info
        Me.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblInfo.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(123, 222)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(50, 50)
        Me.lblInfo.TabIndex = 13
        Me.lblInfo.Text = "1"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImport
        '
        Me.btnImport.AutoSize = True
        Me.btnImport.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnImport.Location = New System.Drawing.Point(3, 3)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(0)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(145, 100)
        Me.btnImport.TabIndex = 2
        Me.btnImport.Text = "批量导入"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "备注："
        '
        'btnBView
        '
        Me.btnBView.AutoSize = True
        Me.btnBView.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnBView.Location = New System.Drawing.Point(3, 101)
        Me.btnBView.Name = "btnBView"
        Me.btnBView.Size = New System.Drawing.Size(145, 100)
        Me.btnBView.TabIndex = 12
        Me.btnBView.Text = "批量查看"
        Me.btnBView.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.AutoSize = True
        Me.btnEdit.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(148, 101)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(145, 100)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "修改"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Font = New System.Drawing.Font("幼圆", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Button1.Location = New System.Drawing.Point(148, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 100)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "统计说明"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 753)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMain"
        Me.Text = "番号管理软件"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.status1.ResumeLayout(False)
        Me.status1.PerformLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboResoure As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dudAI As DomainUpDown
    Friend WithEvents cboType As ComboBox
    Friend WithEvents dudBQ As DomainUpDown
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents pbDisplay As PictureBox
    Friend WithEvents status1 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnImport As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBView As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFan As TextBox
    Friend WithEvents txtPlayer As TextBox
    Friend WithEvents tsslblNowNum As ToolStripStatusLabel
    Friend WithEvents tsslblReEdit As ToolStripStatusLabel
    Friend WithEvents tsslblAllNum As ToolStripStatusLabel
    Friend WithEvents fbdImports As FolderBrowserDialog
End Class
