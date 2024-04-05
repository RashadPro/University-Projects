<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmakeorder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmakeorder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.GunaVSeparator3 = New Guna.UI.WinForms.GunaVSeparator()
        Me.BunifuThinButton21 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.M_ProoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RashadDataSet = New Mylogin.rashadDataSet()
        Me.BunifuMetroTextbox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuMetroTextbox1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.ptnclose = New Guna.UI.WinForms.GunaLabel()
        Me.ptnmenu = New System.Windows.Forms.Button()
        Me.BunifuMetroTextbox3 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.M_ProoTableAdapter = New Mylogin.rashadDataSetTableAdapters.M_ProoTableAdapter()
        Me.TableAdapterManager = New Mylogin.rashadDataSetTableAdapters.TableAdapterManager()
        Me.RashadDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BunifuCustomDataGrid1 = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ResturantNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.M_ProoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RashadDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RashadDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(92, 67)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox5.TabIndex = 39
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(92, 158)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox6.TabIndex = 38
        Me.PictureBox6.TabStop = False
        '
        'GunaVSeparator3
        '
        Me.GunaVSeparator3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator3.LineColor = System.Drawing.Color.Silver
        Me.GunaVSeparator3.Location = New System.Drawing.Point(294, 3)
        Me.GunaVSeparator3.Name = "GunaVSeparator3"
        Me.GunaVSeparator3.Size = New System.Drawing.Size(8, 446)
        Me.GunaVSeparator3.TabIndex = 37
        '
        'BunifuThinButton21
        '
        Me.BunifuThinButton21.ActiveBorderThickness = 1
        Me.BunifuThinButton21.ActiveCornerRadius = 35
        Me.BunifuThinButton21.ActiveFillColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton21.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.ActiveLineColor = System.Drawing.Color.Maroon
        Me.BunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.BunifuThinButton21.BackgroundImage = CType(resources.GetObject("BunifuThinButton21.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton21.ButtonText = "add"
        Me.BunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton21.ForeColor = System.Drawing.Color.Snow
        Me.BunifuThinButton21.IdleBorderThickness = 1
        Me.BunifuThinButton21.IdleCornerRadius = 20
        Me.BunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuThinButton21.IdleForecolor = System.Drawing.Color.White
        Me.BunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuThinButton21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BunifuThinButton21.Location = New System.Drawing.Point(92, 337)
        Me.BunifuThinButton21.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton21.Name = "BunifuThinButton21"
        Me.BunifuThinButton21.Size = New System.Drawing.Size(98, 41)
        Me.BunifuThinButton21.TabIndex = 36
        Me.BunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Air Strip Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(147, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 26)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "اسم الوجبة"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Air Strip Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(127, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 26)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "اسم المطعم"
        '
        'M_ProoBindingSource
        '
        Me.M_ProoBindingSource.DataMember = "M_Proo"
        Me.M_ProoBindingSource.DataSource = Me.RashadDataSet
        '
        'RashadDataSet
        '
        Me.RashadDataSet.DataSetName = "rashadDataSet"
        Me.RashadDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BunifuMetroTextbox2
        '
        Me.BunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuMetroTextbox2.BorderThickness = 3
        Me.BunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox2.isPassword = False
        Me.BunifuMetroTextbox2.Location = New System.Drawing.Point(7, 203)
        Me.BunifuMetroTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox2.Name = "BunifuMetroTextbox2"
        Me.BunifuMetroTextbox2.Size = New System.Drawing.Size(269, 35)
        Me.BunifuMetroTextbox2.TabIndex = 28
        Me.BunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMetroTextbox1
        '
        Me.BunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuMetroTextbox1.BorderThickness = 3
        Me.BunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox1.isPassword = False
        Me.BunifuMetroTextbox1.Location = New System.Drawing.Point(10, 106)
        Me.BunifuMetroTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox1.Name = "BunifuMetroTextbox1"
        Me.BunifuMetroTextbox1.Size = New System.Drawing.Size(269, 36)
        Me.BunifuMetroTextbox1.TabIndex = 29
        Me.BunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button8
        '
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(39, 3)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(237, 61)
        Me.Button8.TabIndex = 27
        Me.Button8.Text = "Make Order"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ptnclose
        '
        Me.ptnclose.AutoSize = True
        Me.ptnclose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptnclose.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ptnclose.Location = New System.Drawing.Point(638, 3)
        Me.ptnclose.Name = "ptnclose"
        Me.ptnclose.Size = New System.Drawing.Size(19, 21)
        Me.ptnclose.TabIndex = 40
        Me.ptnclose.Text = "X"
        '
        'ptnmenu
        '
        Me.ptnmenu.FlatAppearance.BorderSize = 0
        Me.ptnmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ptnmenu.Font = New System.Drawing.Font("Grobuck Med", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ptnmenu.ForeColor = System.Drawing.Color.White
        Me.ptnmenu.Image = CType(resources.GetObject("ptnmenu.Image"), System.Drawing.Image)
        Me.ptnmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ptnmenu.Location = New System.Drawing.Point(39, 386)
        Me.ptnmenu.Name = "ptnmenu"
        Me.ptnmenu.Size = New System.Drawing.Size(250, 52)
        Me.ptnmenu.TabIndex = 41
        Me.ptnmenu.Text = "Restaurants Menu"
        Me.ptnmenu.UseVisualStyleBackColor = True
        '
        'BunifuMetroTextbox3
        '
        Me.BunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.White
        Me.BunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuMetroTextbox3.BorderThickness = 3
        Me.BunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMetroTextbox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMetroTextbox3.ForeColor = System.Drawing.Color.White
        Me.BunifuMetroTextbox3.isPassword = False
        Me.BunifuMetroTextbox3.Location = New System.Drawing.Point(10, 293)
        Me.BunifuMetroTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMetroTextbox3.Name = "BunifuMetroTextbox3"
        Me.BunifuMetroTextbox3.Size = New System.Drawing.Size(269, 35)
        Me.BunifuMetroTextbox3.TabIndex = 42
        Me.BunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Air Strip Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(133, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 26)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "عدد الطلبات"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(92, 252)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'M_ProoTableAdapter
        '
        Me.M_ProoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.M_ProoTableAdapter = Me.M_ProoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Mylogin.rashadDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RashadDataSetBindingSource
        '
        Me.RashadDataSetBindingSource.DataSource = Me.RashadDataSet
        Me.RashadDataSetBindingSource.Position = 0
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.BunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.BunifuCustomDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ResturantNameDataGridViewTextBoxColumn1, Me.FoodNameDataGridViewTextBoxColumn1, Me.AmountDataGridViewTextBoxColumn1})
        Me.BunifuCustomDataGrid1.DataSource = Me.M_ProoBindingSource
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(308, 3)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(349, 446)
        Me.BunifuCustomDataGrid1.TabIndex = 45
        '
        'ResturantNameDataGridViewTextBoxColumn1
        '
        Me.ResturantNameDataGridViewTextBoxColumn1.DataPropertyName = "Resturant_Name"
        Me.ResturantNameDataGridViewTextBoxColumn1.HeaderText = "Resturant_Name"
        Me.ResturantNameDataGridViewTextBoxColumn1.Name = "ResturantNameDataGridViewTextBoxColumn1"
        Me.ResturantNameDataGridViewTextBoxColumn1.Width = 129
        '
        'FoodNameDataGridViewTextBoxColumn1
        '
        Me.FoodNameDataGridViewTextBoxColumn1.DataPropertyName = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn1.HeaderText = "Food_Name"
        Me.FoodNameDataGridViewTextBoxColumn1.Name = "FoodNameDataGridViewTextBoxColumn1"
        Me.FoodNameDataGridViewTextBoxColumn1.Width = 103
        '
        'AmountDataGridViewTextBoxColumn1
        '
        Me.AmountDataGridViewTextBoxColumn1.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn1.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn1.Name = "AmountDataGridViewTextBoxColumn1"
        Me.AmountDataGridViewTextBoxColumn1.Width = 77
        '
        'frmmakeorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(656, 469)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BunifuMetroTextbox3)
        Me.Controls.Add(Me.ptnmenu)
        Me.Controls.Add(Me.ptnclose)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.GunaVSeparator3)
        Me.Controls.Add(Me.BunifuThinButton21)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BunifuMetroTextbox2)
        Me.Controls.Add(Me.BunifuMetroTextbox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.Name = "frmmakeorder"
        Me.Text = "frmmakeorder"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.M_ProoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RashadDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RashadDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents GunaVSeparator3 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuMetroTextbox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuMetroTextbox1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Button8 As Button
    Friend WithEvents ptnclose As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ptnmenu As Button
    Friend WithEvents BunifuMetroTextbox3 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RashadDataSet As rashadDataSet
    Friend WithEvents M_ProoBindingSource As BindingSource
    Friend WithEvents M_ProoTableAdapter As rashadDataSetTableAdapters.M_ProoTableAdapter
    Friend WithEvents TableAdapterManager As rashadDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RashadDataSetBindingSource As BindingSource
    Friend WithEvents BunifuCustomDataGrid1 As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ResturantNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
