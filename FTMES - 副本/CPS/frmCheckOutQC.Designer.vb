﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOutQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCheckOutQC))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_wqty = New System.Windows.Forms.TextBox()
        Me.txt_clot = New System.Windows.Forms.TextBox()
        Me.txt_ilot = New System.Windows.Forms.TextBox()
        Me.txt_prod = New System.Windows.Forms.TextBox()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGV_WaferList = New System.Windows.Forms.DataGridView()
        Me.w1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w13 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w17 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w18 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w19 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w20 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w21 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w22 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w23 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w24 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w25 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_flowid = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_nextrecipeid = New System.Windows.Forms.TextBox()
        Me.txt_nextstep = New System.Windows.Forms.TextBox()
        Me.txt_currstatus = New System.Windows.Forms.TextBox()
        Me.txt_currrecipeid = New System.Windows.Forms.TextBox()
        Me.txt_currstep = New System.Windows.Forms.TextBox()
        Me.txt_lastrecipeid = New System.Windows.Forms.TextBox()
        Me.txt_laststep = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.DGV_ParaInput = New System.Windows.Forms.DataGridView()
        Me.Parameters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Values = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGV_InspRecord = New System.Windows.Forms.DataGridView()
        Me.WaferNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WaferOCR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QCSelect = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ERF = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ERFItem = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_all = New System.Windows.Forms.Button()
        Me.DGV_waferselect = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn13 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn17 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn18 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn19 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn20 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn21 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn22 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn23 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn24 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn25 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_WaferList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DGV_ParaInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGV_InspRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DGV_waferselect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_wqty)
        Me.GroupBox1.Controls.Add(Me.txt_clot)
        Me.GroupBox1.Controls.Add(Me.txt_ilot)
        Me.GroupBox1.Controls.Add(Me.txt_prod)
        Me.GroupBox1.Controls.Add(Me.txt_cust)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.DGV_WaferList)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1223, 116)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "产品信息"
        '
        'txt_wqty
        '
        Me.txt_wqty.BackColor = System.Drawing.SystemColors.Control
        Me.txt_wqty.Location = New System.Drawing.Point(87, 65)
        Me.txt_wqty.Name = "txt_wqty"
        Me.txt_wqty.ReadOnly = True
        Me.txt_wqty.Size = New System.Drawing.Size(177, 21)
        Me.txt_wqty.TabIndex = 21
        '
        'txt_clot
        '
        Me.txt_clot.Location = New System.Drawing.Point(895, 20)
        Me.txt_clot.Name = "txt_clot"
        Me.txt_clot.ReadOnly = True
        Me.txt_clot.Size = New System.Drawing.Size(177, 21)
        Me.txt_clot.TabIndex = 20
        '
        'txt_ilot
        '
        Me.txt_ilot.Location = New System.Drawing.Point(627, 20)
        Me.txt_ilot.Name = "txt_ilot"
        Me.txt_ilot.ReadOnly = True
        Me.txt_ilot.Size = New System.Drawing.Size(177, 21)
        Me.txt_ilot.TabIndex = 19
        '
        'txt_prod
        '
        Me.txt_prod.Location = New System.Drawing.Point(357, 20)
        Me.txt_prod.Name = "txt_prod"
        Me.txt_prod.ReadOnly = True
        Me.txt_prod.Size = New System.Drawing.Size(177, 21)
        Me.txt_prod.TabIndex = 18
        '
        'txt_cust
        '
        Me.txt_cust.Location = New System.Drawing.Point(87, 20)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.ReadOnly = True
        Me.txt_cust.Size = New System.Drawing.Size(177, 21)
        Me.txt_cust.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "片号信息："
        '
        'DGV_WaferList
        '
        Me.DGV_WaferList.AllowUserToDeleteRows = False
        Me.DGV_WaferList.AllowUserToResizeColumns = False
        Me.DGV_WaferList.AllowUserToResizeRows = False
        Me.DGV_WaferList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_WaferList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGV_WaferList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_WaferList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.w1, Me.w2, Me.w3, Me.w4, Me.w5, Me.w6, Me.w7, Me.w8, Me.w9, Me.w10, Me.w11, Me.w12, Me.w13, Me.w14, Me.w15, Me.w16, Me.w17, Me.w18, Me.w19, Me.w20, Me.w21, Me.w22, Me.w23, Me.w24, Me.w25, Me.w26})
        Me.DGV_WaferList.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_WaferList.Location = New System.Drawing.Point(357, 52)
        Me.DGV_WaferList.Name = "DGV_WaferList"
        Me.DGV_WaferList.ReadOnly = True
        Me.DGV_WaferList.RowHeadersWidth = 10
        Me.DGV_WaferList.RowTemplate.Height = 23
        Me.DGV_WaferList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_WaferList.Size = New System.Drawing.Size(522, 48)
        Me.DGV_WaferList.TabIndex = 10
        '
        'w1
        '
        Me.w1.HeaderText = "1"
        Me.w1.Name = "w1"
        Me.w1.ReadOnly = True
        Me.w1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.w1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.w1.Width = 20
        '
        'w2
        '
        Me.w2.HeaderText = "2"
        Me.w2.Name = "w2"
        Me.w2.ReadOnly = True
        Me.w2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.w2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.w2.Width = 20
        '
        'w3
        '
        Me.w3.HeaderText = "3"
        Me.w3.Name = "w3"
        Me.w3.ReadOnly = True
        Me.w3.Width = 20
        '
        'w4
        '
        Me.w4.HeaderText = "4"
        Me.w4.Name = "w4"
        Me.w4.ReadOnly = True
        Me.w4.Width = 20
        '
        'w5
        '
        Me.w5.HeaderText = "5"
        Me.w5.Name = "w5"
        Me.w5.ReadOnly = True
        Me.w5.Width = 20
        '
        'w6
        '
        Me.w6.HeaderText = "6"
        Me.w6.Name = "w6"
        Me.w6.ReadOnly = True
        Me.w6.Width = 20
        '
        'w7
        '
        Me.w7.HeaderText = "7"
        Me.w7.Name = "w7"
        Me.w7.ReadOnly = True
        Me.w7.Width = 20
        '
        'w8
        '
        Me.w8.HeaderText = "8"
        Me.w8.Name = "w8"
        Me.w8.ReadOnly = True
        Me.w8.Width = 20
        '
        'w9
        '
        Me.w9.HeaderText = "9"
        Me.w9.Name = "w9"
        Me.w9.ReadOnly = True
        Me.w9.Width = 20
        '
        'w10
        '
        Me.w10.HeaderText = "10"
        Me.w10.Name = "w10"
        Me.w10.ReadOnly = True
        Me.w10.Width = 20
        '
        'w11
        '
        Me.w11.HeaderText = "11"
        Me.w11.Name = "w11"
        Me.w11.ReadOnly = True
        Me.w11.Width = 20
        '
        'w12
        '
        Me.w12.HeaderText = "12"
        Me.w12.Name = "w12"
        Me.w12.ReadOnly = True
        Me.w12.Width = 20
        '
        'w13
        '
        Me.w13.HeaderText = "13"
        Me.w13.Name = "w13"
        Me.w13.ReadOnly = True
        Me.w13.Width = 20
        '
        'w14
        '
        Me.w14.HeaderText = "14"
        Me.w14.Name = "w14"
        Me.w14.ReadOnly = True
        Me.w14.Width = 20
        '
        'w15
        '
        Me.w15.HeaderText = "15"
        Me.w15.Name = "w15"
        Me.w15.ReadOnly = True
        Me.w15.Width = 20
        '
        'w16
        '
        Me.w16.HeaderText = "16"
        Me.w16.Name = "w16"
        Me.w16.ReadOnly = True
        Me.w16.Width = 20
        '
        'w17
        '
        Me.w17.HeaderText = "17"
        Me.w17.Name = "w17"
        Me.w17.ReadOnly = True
        Me.w17.Width = 20
        '
        'w18
        '
        Me.w18.HeaderText = "18"
        Me.w18.Name = "w18"
        Me.w18.ReadOnly = True
        Me.w18.Width = 20
        '
        'w19
        '
        Me.w19.HeaderText = "19"
        Me.w19.Name = "w19"
        Me.w19.ReadOnly = True
        Me.w19.Width = 20
        '
        'w20
        '
        Me.w20.HeaderText = "20"
        Me.w20.Name = "w20"
        Me.w20.ReadOnly = True
        Me.w20.Width = 20
        '
        'w21
        '
        Me.w21.HeaderText = "21"
        Me.w21.Name = "w21"
        Me.w21.ReadOnly = True
        Me.w21.Width = 20
        '
        'w22
        '
        Me.w22.HeaderText = "22"
        Me.w22.Name = "w22"
        Me.w22.ReadOnly = True
        Me.w22.Width = 20
        '
        'w23
        '
        Me.w23.HeaderText = "23"
        Me.w23.Name = "w23"
        Me.w23.ReadOnly = True
        Me.w23.Width = 20
        '
        'w24
        '
        Me.w24.HeaderText = "24"
        Me.w24.Name = "w24"
        Me.w24.ReadOnly = True
        Me.w24.Width = 20
        '
        'w25
        '
        Me.w25.HeaderText = "25"
        Me.w25.Name = "w25"
        Me.w25.ReadOnly = True
        Me.w25.Width = 20
        '
        'w26
        '
        Me.w26.HeaderText = ""
        Me.w26.Name = "w26"
        Me.w26.ReadOnly = True
        Me.w26.Width = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "投入片数："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(286, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "产品型号："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(824, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "客户批号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "客户名称："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(556, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "生产批号："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_flowid)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_nextrecipeid)
        Me.GroupBox2.Controls.Add(Me.txt_nextstep)
        Me.GroupBox2.Controls.Add(Me.txt_currstatus)
        Me.GroupBox2.Controls.Add(Me.txt_currrecipeid)
        Me.GroupBox2.Controls.Add(Me.txt_currstep)
        Me.GroupBox2.Controls.Add(Me.txt_lastrecipeid)
        Me.GroupBox2.Controls.Add(Me.txt_laststep)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1223, 114)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "站别信息"
        '
        'txt_flowid
        '
        Me.txt_flowid.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_flowid.ForeColor = System.Drawing.Color.Indigo
        Me.txt_flowid.Location = New System.Drawing.Point(332, 26)
        Me.txt_flowid.Name = "txt_flowid"
        Me.txt_flowid.Size = New System.Drawing.Size(93, 19)
        Me.txt_flowid.TabIndex = 47
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Indigo
        Me.Label18.Location = New System.Drawing.Point(285, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 19)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "FlowID:"
        '
        'txt_nextrecipeid
        '
        Me.txt_nextrecipeid.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nextrecipeid.Location = New System.Drawing.Point(980, 56)
        Me.txt_nextrecipeid.Name = "txt_nextrecipeid"
        Me.txt_nextrecipeid.ReadOnly = True
        Me.txt_nextrecipeid.Size = New System.Drawing.Size(177, 21)
        Me.txt_nextrecipeid.TabIndex = 42
        '
        'txt_nextstep
        '
        Me.txt_nextstep.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nextstep.Location = New System.Drawing.Point(980, 21)
        Me.txt_nextstep.Name = "txt_nextstep"
        Me.txt_nextstep.ReadOnly = True
        Me.txt_nextstep.Size = New System.Drawing.Size(177, 21)
        Me.txt_nextstep.TabIndex = 41
        '
        'txt_currstatus
        '
        Me.txt_currstatus.BackColor = System.Drawing.Color.LawnGreen
        Me.txt_currstatus.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_currstatus.ForeColor = System.Drawing.Color.Blue
        Me.txt_currstatus.Location = New System.Drawing.Point(533, 82)
        Me.txt_currstatus.Name = "txt_currstatus"
        Me.txt_currstatus.ReadOnly = True
        Me.txt_currstatus.Size = New System.Drawing.Size(177, 21)
        Me.txt_currstatus.TabIndex = 40
        '
        'txt_currrecipeid
        '
        Me.txt_currrecipeid.BackColor = System.Drawing.Color.LawnGreen
        Me.txt_currrecipeid.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_currrecipeid.ForeColor = System.Drawing.Color.Blue
        Me.txt_currrecipeid.Location = New System.Drawing.Point(533, 50)
        Me.txt_currrecipeid.Name = "txt_currrecipeid"
        Me.txt_currrecipeid.ReadOnly = True
        Me.txt_currrecipeid.Size = New System.Drawing.Size(177, 21)
        Me.txt_currrecipeid.TabIndex = 39
        '
        'txt_currstep
        '
        Me.txt_currstep.BackColor = System.Drawing.Color.LawnGreen
        Me.txt_currstep.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_currstep.ForeColor = System.Drawing.Color.Blue
        Me.txt_currstep.Location = New System.Drawing.Point(533, 17)
        Me.txt_currstep.Name = "txt_currstep"
        Me.txt_currstep.ReadOnly = True
        Me.txt_currstep.Size = New System.Drawing.Size(177, 21)
        Me.txt_currstep.TabIndex = 38
        '
        'txt_lastrecipeid
        '
        Me.txt_lastrecipeid.BackColor = System.Drawing.SystemColors.Control
        Me.txt_lastrecipeid.Location = New System.Drawing.Point(87, 55)
        Me.txt_lastrecipeid.Name = "txt_lastrecipeid"
        Me.txt_lastrecipeid.ReadOnly = True
        Me.txt_lastrecipeid.Size = New System.Drawing.Size(177, 21)
        Me.txt_lastrecipeid.TabIndex = 37
        '
        'txt_laststep
        '
        Me.txt_laststep.BackColor = System.Drawing.SystemColors.Control
        Me.txt_laststep.Location = New System.Drawing.Point(87, 21)
        Me.txt_laststep.Name = "txt_laststep"
        Me.txt_laststep.ReadOnly = True
        Me.txt_laststep.Size = New System.Drawing.Size(177, 21)
        Me.txt_laststep.TabIndex = 36
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(896, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 12)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "RecipeID："
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(896, 29)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(65, 12)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "下一站别："
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 12)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "RecipeID："
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(10, 30)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 12)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "上一站别："
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(760, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(321, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(446, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 12)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "RecipeID："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(445, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 12)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "当前状态："
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(446, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 12)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "当前站别："
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TabControl1)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 230)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1223, 571)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "作业信息"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(600, 20)
        Me.TabControl1.Location = New System.Drawing.Point(3, 17)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1217, 551)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1209, 523)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "          作业内容          "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox9)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(598, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(604, 513)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "资料采集"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DGV_ParaInput)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(598, 493)
        Me.GroupBox9.TabIndex = 17
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "1. 参数填写"
        '
        'DGV_ParaInput
        '
        Me.DGV_ParaInput.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_ParaInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ParaInput.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Parameters, Me.Values})
        Me.DGV_ParaInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_ParaInput.Location = New System.Drawing.Point(3, 17)
        Me.DGV_ParaInput.Name = "DGV_ParaInput"
        Me.DGV_ParaInput.RowHeadersVisible = False
        Me.DGV_ParaInput.RowTemplate.Height = 23
        Me.DGV_ParaInput.Size = New System.Drawing.Size(592, 473)
        Me.DGV_ParaInput.TabIndex = 15
        '
        'Parameters
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Parameters.DefaultCellStyle = DataGridViewCellStyle1
        Me.Parameters.HeaderText = "参数"
        Me.Parameters.Name = "Parameters"
        Me.Parameters.Width = 220
        '
        'Values
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Values.DefaultCellStyle = DataGridViewCellStyle2
        Me.Values.HeaderText = "值"
        Me.Values.Name = "Values"
        Me.Values.Width = 220
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(595, 513)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "检验记录"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.DGV_InspRecord)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(3, 145)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(589, 365)
        Me.GroupBox6.TabIndex = 18
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "2. 检验结果"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(65, 137)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(420, 16)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "检验结果后续需要建立专门的DataBase对应，暂未开发"
        '
        'DGV_InspRecord
        '
        Me.DGV_InspRecord.AllowUserToAddRows = False
        Me.DGV_InspRecord.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_InspRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_InspRecord.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.WaferNo, Me.WaferOCR, Me.QCSelect, Me.ERF, Me.ERFItem})
        Me.DGV_InspRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_InspRecord.Location = New System.Drawing.Point(3, 17)
        Me.DGV_InspRecord.Name = "DGV_InspRecord"
        Me.DGV_InspRecord.RowHeadersVisible = False
        Me.DGV_InspRecord.RowTemplate.Height = 23
        Me.DGV_InspRecord.Size = New System.Drawing.Size(583, 345)
        Me.DGV_InspRecord.TabIndex = 15
        '
        'WaferNo
        '
        Me.WaferNo.HeaderText = "WaferNo"
        Me.WaferNo.Name = "WaferNo"
        Me.WaferNo.ReadOnly = True
        '
        'WaferOCR
        '
        Me.WaferOCR.HeaderText = "WaferOCR"
        Me.WaferOCR.Name = "WaferOCR"
        Me.WaferOCR.Width = 200
        '
        'QCSelect
        '
        Me.QCSelect.HeaderText = "抽检"
        Me.QCSelect.Name = "QCSelect"
        '
        'ERF
        '
        Me.ERF.HeaderText = "异常"
        Me.ERF.Name = "ERF"
        '
        'ERFItem
        '
        Me.ERFItem.HeaderText = "异常原因"
        Me.ERFItem.Items.AddRange(New Object() {"1-刮伤", "2-脏污", "3-资料不符"})
        Me.ERFItem.Name = "ERFItem"
        Me.ERFItem.Width = 200
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.btn_clear)
        Me.GroupBox8.Controls.Add(Me.btn_all)
        Me.GroupBox8.Controls.Add(Me.DGV_waferselect)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(589, 128)
        Me.GroupBox8.TabIndex = 15
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "1. 片号修正"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.HotPink
        Me.btn_clear.Image = Global.CPS.My.Resources.Resources.cls
        Me.btn_clear.Location = New System.Drawing.Point(324, 87)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(90, 32)
        Me.btn_clear.TabIndex = 13
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_all
        '
        Me.btn_all.BackColor = System.Drawing.Color.HotPink
        Me.btn_all.Image = Global.CPS.My.Resources.Resources.all
        Me.btn_all.Location = New System.Drawing.Point(113, 87)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(90, 32)
        Me.btn_all.TabIndex = 12
        Me.btn_all.UseVisualStyleBackColor = False
        '
        'DGV_waferselect
        '
        Me.DGV_waferselect.AllowUserToAddRows = False
        Me.DGV_waferselect.AllowUserToDeleteRows = False
        Me.DGV_waferselect.AllowUserToResizeColumns = False
        Me.DGV_waferselect.AllowUserToResizeRows = False
        Me.DGV_waferselect.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_waferselect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGV_waferselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_waferselect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewCheckBoxColumn9, Me.DataGridViewCheckBoxColumn10, Me.DataGridViewCheckBoxColumn11, Me.DataGridViewCheckBoxColumn12, Me.DataGridViewCheckBoxColumn13, Me.DataGridViewCheckBoxColumn14, Me.DataGridViewCheckBoxColumn15, Me.DataGridViewCheckBoxColumn16, Me.DataGridViewCheckBoxColumn17, Me.DataGridViewCheckBoxColumn18, Me.DataGridViewCheckBoxColumn19, Me.DataGridViewCheckBoxColumn20, Me.DataGridViewCheckBoxColumn21, Me.DataGridViewCheckBoxColumn22, Me.DataGridViewCheckBoxColumn23, Me.DataGridViewCheckBoxColumn24, Me.DataGridViewCheckBoxColumn25, Me.DataGridViewTextBoxColumn1})
        Me.DGV_waferselect.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_waferselect.Location = New System.Drawing.Point(35, 26)
        Me.DGV_waferselect.Name = "DGV_waferselect"
        Me.DGV_waferselect.RowHeadersWidth = 10
        Me.DGV_waferselect.RowTemplate.Height = 23
        Me.DGV_waferselect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_waferselect.Size = New System.Drawing.Size(523, 56)
        Me.DGV_waferselect.TabIndex = 11
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "1"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 20
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "2"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn2.Width = 20
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.HeaderText = "3"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 20
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.HeaderText = "4"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 20
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.HeaderText = "5"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.Width = 20
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.HeaderText = "6"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.Width = 20
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.HeaderText = "7"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        Me.DataGridViewCheckBoxColumn7.Width = 20
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.HeaderText = "8"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.Width = 20
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.HeaderText = "9"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        Me.DataGridViewCheckBoxColumn9.Width = 20
        '
        'DataGridViewCheckBoxColumn10
        '
        Me.DataGridViewCheckBoxColumn10.HeaderText = "10"
        Me.DataGridViewCheckBoxColumn10.Name = "DataGridViewCheckBoxColumn10"
        Me.DataGridViewCheckBoxColumn10.Width = 20
        '
        'DataGridViewCheckBoxColumn11
        '
        Me.DataGridViewCheckBoxColumn11.HeaderText = "11"
        Me.DataGridViewCheckBoxColumn11.Name = "DataGridViewCheckBoxColumn11"
        Me.DataGridViewCheckBoxColumn11.Width = 20
        '
        'DataGridViewCheckBoxColumn12
        '
        Me.DataGridViewCheckBoxColumn12.HeaderText = "12"
        Me.DataGridViewCheckBoxColumn12.Name = "DataGridViewCheckBoxColumn12"
        Me.DataGridViewCheckBoxColumn12.Width = 20
        '
        'DataGridViewCheckBoxColumn13
        '
        Me.DataGridViewCheckBoxColumn13.HeaderText = "13"
        Me.DataGridViewCheckBoxColumn13.Name = "DataGridViewCheckBoxColumn13"
        Me.DataGridViewCheckBoxColumn13.Width = 20
        '
        'DataGridViewCheckBoxColumn14
        '
        Me.DataGridViewCheckBoxColumn14.HeaderText = "14"
        Me.DataGridViewCheckBoxColumn14.Name = "DataGridViewCheckBoxColumn14"
        Me.DataGridViewCheckBoxColumn14.Width = 20
        '
        'DataGridViewCheckBoxColumn15
        '
        Me.DataGridViewCheckBoxColumn15.HeaderText = "15"
        Me.DataGridViewCheckBoxColumn15.Name = "DataGridViewCheckBoxColumn15"
        Me.DataGridViewCheckBoxColumn15.Width = 20
        '
        'DataGridViewCheckBoxColumn16
        '
        Me.DataGridViewCheckBoxColumn16.HeaderText = "16"
        Me.DataGridViewCheckBoxColumn16.Name = "DataGridViewCheckBoxColumn16"
        Me.DataGridViewCheckBoxColumn16.Width = 20
        '
        'DataGridViewCheckBoxColumn17
        '
        Me.DataGridViewCheckBoxColumn17.HeaderText = "17"
        Me.DataGridViewCheckBoxColumn17.Name = "DataGridViewCheckBoxColumn17"
        Me.DataGridViewCheckBoxColumn17.Width = 20
        '
        'DataGridViewCheckBoxColumn18
        '
        Me.DataGridViewCheckBoxColumn18.HeaderText = "18"
        Me.DataGridViewCheckBoxColumn18.Name = "DataGridViewCheckBoxColumn18"
        Me.DataGridViewCheckBoxColumn18.Width = 20
        '
        'DataGridViewCheckBoxColumn19
        '
        Me.DataGridViewCheckBoxColumn19.HeaderText = "19"
        Me.DataGridViewCheckBoxColumn19.Name = "DataGridViewCheckBoxColumn19"
        Me.DataGridViewCheckBoxColumn19.Width = 20
        '
        'DataGridViewCheckBoxColumn20
        '
        Me.DataGridViewCheckBoxColumn20.HeaderText = "20"
        Me.DataGridViewCheckBoxColumn20.Name = "DataGridViewCheckBoxColumn20"
        Me.DataGridViewCheckBoxColumn20.Width = 20
        '
        'DataGridViewCheckBoxColumn21
        '
        Me.DataGridViewCheckBoxColumn21.HeaderText = "21"
        Me.DataGridViewCheckBoxColumn21.Name = "DataGridViewCheckBoxColumn21"
        Me.DataGridViewCheckBoxColumn21.Width = 20
        '
        'DataGridViewCheckBoxColumn22
        '
        Me.DataGridViewCheckBoxColumn22.HeaderText = "22"
        Me.DataGridViewCheckBoxColumn22.Name = "DataGridViewCheckBoxColumn22"
        Me.DataGridViewCheckBoxColumn22.Width = 20
        '
        'DataGridViewCheckBoxColumn23
        '
        Me.DataGridViewCheckBoxColumn23.HeaderText = "23"
        Me.DataGridViewCheckBoxColumn23.Name = "DataGridViewCheckBoxColumn23"
        Me.DataGridViewCheckBoxColumn23.Width = 20
        '
        'DataGridViewCheckBoxColumn24
        '
        Me.DataGridViewCheckBoxColumn24.HeaderText = "24"
        Me.DataGridViewCheckBoxColumn24.Name = "DataGridViewCheckBoxColumn24"
        Me.DataGridViewCheckBoxColumn24.Width = 20
        '
        'DataGridViewCheckBoxColumn25
        '
        Me.DataGridViewCheckBoxColumn25.HeaderText = "25"
        Me.DataGridViewCheckBoxColumn25.Name = "DataGridViewCheckBoxColumn25"
        Me.DataGridViewCheckBoxColumn25.Width = 20
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 10
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1209, 523)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "          流程定义          "
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.IndianRed
        Me.btn_exit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(710, 827)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.SystemColors.Desktop
        Me.btn_confirm.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(383, 827)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 5
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'frmCheckOutQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 908)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmCheckOutQC"
        Me.Text = "frmCheckOutQC"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_WaferList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DGV_ParaInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.DGV_InspRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DGV_waferselect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_wqty As TextBox
    Friend WithEvents txt_clot As TextBox
    Friend WithEvents txt_ilot As TextBox
    Friend WithEvents txt_prod As TextBox
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DGV_WaferList As DataGridView
    Friend WithEvents w1 As DataGridViewCheckBoxColumn
    Friend WithEvents w2 As DataGridViewCheckBoxColumn
    Friend WithEvents w3 As DataGridViewCheckBoxColumn
    Friend WithEvents w4 As DataGridViewCheckBoxColumn
    Friend WithEvents w5 As DataGridViewCheckBoxColumn
    Friend WithEvents w6 As DataGridViewCheckBoxColumn
    Friend WithEvents w7 As DataGridViewCheckBoxColumn
    Friend WithEvents w8 As DataGridViewCheckBoxColumn
    Friend WithEvents w9 As DataGridViewCheckBoxColumn
    Friend WithEvents w10 As DataGridViewCheckBoxColumn
    Friend WithEvents w11 As DataGridViewCheckBoxColumn
    Friend WithEvents w12 As DataGridViewCheckBoxColumn
    Friend WithEvents w13 As DataGridViewCheckBoxColumn
    Friend WithEvents w14 As DataGridViewCheckBoxColumn
    Friend WithEvents w15 As DataGridViewCheckBoxColumn
    Friend WithEvents w16 As DataGridViewCheckBoxColumn
    Friend WithEvents w17 As DataGridViewCheckBoxColumn
    Friend WithEvents w18 As DataGridViewCheckBoxColumn
    Friend WithEvents w19 As DataGridViewCheckBoxColumn
    Friend WithEvents w20 As DataGridViewCheckBoxColumn
    Friend WithEvents w21 As DataGridViewCheckBoxColumn
    Friend WithEvents w22 As DataGridViewCheckBoxColumn
    Friend WithEvents w23 As DataGridViewCheckBoxColumn
    Friend WithEvents w24 As DataGridViewCheckBoxColumn
    Friend WithEvents w25 As DataGridViewCheckBoxColumn
    Friend WithEvents w26 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_nextrecipeid As TextBox
    Friend WithEvents txt_nextstep As TextBox
    Friend WithEvents txt_currstatus As TextBox
    Friend WithEvents txt_currrecipeid As TextBox
    Friend WithEvents txt_currstep As TextBox
    Friend WithEvents txt_lastrecipeid As TextBox
    Friend WithEvents txt_laststep As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_all As Button
    Friend WithEvents DGV_waferselect As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn10 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn11 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn12 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn13 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn14 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn15 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn16 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn17 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn18 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn19 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn20 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn21 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn22 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn23 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn24 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn25 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DGV_InspRecord As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents DGV_ParaInput As DataGridView
    Friend WithEvents Parameters As DataGridViewTextBoxColumn
    Friend WithEvents Values As DataGridViewTextBoxColumn
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents WaferNo As DataGridViewTextBoxColumn
    Friend WithEvents WaferOCR As DataGridViewTextBoxColumn
    Friend WithEvents QCSelect As DataGridViewCheckBoxColumn
    Friend WithEvents ERF As DataGridViewCheckBoxColumn
    Friend WithEvents ERFItem As DataGridViewComboBoxColumn
    Friend WithEvents txt_flowid As Label
    Friend WithEvents Label18 As Label
End Class
