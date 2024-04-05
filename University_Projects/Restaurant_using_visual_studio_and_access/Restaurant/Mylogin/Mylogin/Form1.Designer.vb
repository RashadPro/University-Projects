<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Me.p1 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.l2 = New Guna.UI.WinForms.GunaLabel()
        Me.l3 = New Guna.UI.WinForms.GunaLabel()
        Me.l1 = New Guna.UI.WinForms.GunaLabel()
        Me.p2 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GunaCheckBox1 = New Guna.UI.WinForms.GunaCheckBox()
        Me.linkaccnt = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.p3 = New Guna.UI.WinForms.GunaPanel()
        Me.btnx = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuMaterialTextbox5 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.GunaCheckBox2 = New Guna.UI.WinForms.GunaCheckBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.BunifuMaterialTextbox3 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox4 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.anima1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.p1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p3.SuspendLayout()
        Me.SuspendLayout()
        '
        'p1
        '
        Me.p1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.p1.Controls.Add(Me.PictureBox1)
        Me.p1.Controls.Add(Me.l2)
        Me.p1.Controls.Add(Me.l3)
        Me.p1.Controls.Add(Me.l1)
        Me.anima1.SetDecoration(Me.p1, Guna.UI.Animation.DecorationType.None)
        Me.p1.Location = New System.Drawing.Point(39, 23)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(327, 488)
        Me.p1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.anima1.SetDecoration(Me.PictureBox1, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 94)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.anima1.SetDecoration(Me.l2, Guna.UI.Animation.DecorationType.None)
        Me.l2.Font = New System.Drawing.Font("Astral Sisters", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.White
        Me.l2.Location = New System.Drawing.Point(120, 202)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(200, 70)
        Me.l2.TabIndex = 7
        Me.l2.Text = "University "
        Me.l2.Visible = False
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.anima1.SetDecoration(Me.l3, Guna.UI.Animation.DecorationType.None)
        Me.l3.Font = New System.Drawing.Font("Astral Sisters", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l3.ForeColor = System.Drawing.Color.White
        Me.l3.Location = New System.Drawing.Point(36, 272)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(218, 70)
        Me.l3.TabIndex = 6
        Me.l3.Text = "Restaurants"
        Me.l3.Visible = False
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.anima1.SetDecoration(Me.l1, Guna.UI.Animation.DecorationType.None)
        Me.l1.Font = New System.Drawing.Font("Astral Sisters", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.White
        Me.l1.Location = New System.Drawing.Point(6, 202)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(127, 70)
        Me.l1.TabIndex = 5
        Me.l1.Text = "Sinai "
        Me.l1.Visible = False
        '
        'p2
        '
        Me.p2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p2.Controls.Add(Me.PictureBox3)
        Me.p2.Controls.Add(Me.PictureBox2)
        Me.p2.Controls.Add(Me.GunaCheckBox1)
        Me.p2.Controls.Add(Me.linkaccnt)
        Me.p2.Controls.Add(Me.GunaButton1)
        Me.p2.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.p2.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.anima1.SetDecoration(Me.p2, Guna.UI.Animation.DecorationType.None)
        Me.p2.Location = New System.Drawing.Point(365, 23)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(327, 488)
        Me.p2.TabIndex = 1
        Me.p2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.anima1.SetDecoration(Me.PictureBox3, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox3.Location = New System.Drawing.Point(261, 143)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.anima1.SetDecoration(Me.PictureBox2, Guna.UI.Animation.DecorationType.None)
        Me.PictureBox2.Location = New System.Drawing.Point(261, 91)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 34)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'GunaCheckBox1
        '
        Me.GunaCheckBox1.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox1.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaCheckBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.anima1.SetDecoration(Me.GunaCheckBox1, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox1.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox1.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox1.Location = New System.Drawing.Point(41, 189)
        Me.GunaCheckBox1.Name = "GunaCheckBox1"
        Me.GunaCheckBox1.Size = New System.Drawing.Size(111, 20)
        Me.GunaCheckBox1.TabIndex = 4
        Me.GunaCheckBox1.Text = "Show Password"
        '
        'linkaccnt
        '
        Me.linkaccnt.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.linkaccnt.AutoSize = True
        Me.anima1.SetDecoration(Me.linkaccnt, Guna.UI.Animation.DecorationType.None)
        Me.linkaccnt.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.linkaccnt.LinkColor = System.Drawing.Color.Silver
        Me.linkaccnt.Location = New System.Drawing.Point(121, 344)
        Me.linkaccnt.Name = "linkaccnt"
        Me.linkaccnt.Size = New System.Drawing.Size(89, 15)
        Me.linkaccnt.TabIndex = 3
        Me.linkaccnt.TabStop = True
        Me.linkaccnt.Text = "Create Account"
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.GunaButton1, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(41, 261)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Maroon
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(252, 42)
        Me.GunaButton1.TabIndex = 2
        Me.GunaButton1.Text = "Sign in"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox2, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox2.HintText = "Password"
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(41, 138)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(252, 44)
        Me.BunifuMaterialTextbox2.TabIndex = 1
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox1, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox1.HintText = "Username"
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(41, 86)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(252, 44)
        Me.BunifuMaterialTextbox1.TabIndex = 0
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'p3
        '
        Me.p3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.p3.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.p3.Controls.Add(Me.btnx)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox5)
        Me.p3.Controls.Add(Me.GunaCheckBox2)
        Me.p3.Controls.Add(Me.GunaButton2)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox3)
        Me.p3.Controls.Add(Me.BunifuMaterialTextbox4)
        Me.anima1.SetDecoration(Me.p3, Guna.UI.Animation.DecorationType.None)
        Me.p3.Location = New System.Drawing.Point(365, 23)
        Me.p3.Name = "p3"
        Me.p3.Size = New System.Drawing.Size(327, 488)
        Me.p3.TabIndex = 2
        Me.p3.Visible = False
        '
        'btnx
        '
        Me.btnx.AutoSize = True
        Me.anima1.SetDecoration(Me.btnx, Guna.UI.Animation.DecorationType.None)
        Me.btnx.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.btnx.ForeColor = System.Drawing.Color.Silver
        Me.btnx.Location = New System.Drawing.Point(307, 3)
        Me.btnx.Name = "btnx"
        Me.btnx.Size = New System.Drawing.Size(18, 20)
        Me.btnx.TabIndex = 6
        Me.btnx.Text = "X"
        '
        'BunifuMaterialTextbox5
        '
        Me.BunifuMaterialTextbox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox5, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox5.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox5.HintText = "Re-Enter Password"
        Me.BunifuMaterialTextbox5.isPassword = False
        Me.BunifuMaterialTextbox5.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox5.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox5.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox5.LineThickness = 3
        Me.BunifuMaterialTextbox5.Location = New System.Drawing.Point(34, 201)
        Me.BunifuMaterialTextbox5.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox5.Name = "BunifuMaterialTextbox5"
        Me.BunifuMaterialTextbox5.Size = New System.Drawing.Size(252, 44)
        Me.BunifuMaterialTextbox5.TabIndex = 5
        Me.BunifuMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaCheckBox2
        '
        Me.GunaCheckBox2.BaseColor = System.Drawing.Color.White
        Me.GunaCheckBox2.CheckedOffColor = System.Drawing.Color.Gray
        Me.GunaCheckBox2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaCheckBox2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.anima1.SetDecoration(Me.GunaCheckBox2, Guna.UI.Animation.DecorationType.None)
        Me.GunaCheckBox2.FillColor = System.Drawing.Color.White
        Me.GunaCheckBox2.ForeColor = System.Drawing.Color.Silver
        Me.GunaCheckBox2.Location = New System.Drawing.Point(34, 252)
        Me.GunaCheckBox2.Name = "GunaCheckBox2"
        Me.GunaCheckBox2.Size = New System.Drawing.Size(111, 20)
        Me.GunaCheckBox2.TabIndex = 4
        Me.GunaCheckBox2.Text = "Show Password"
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.anima1.SetDecoration(Me.GunaButton2, Guna.UI.Animation.DecorationType.None)
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(34, 396)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.SpringGreen
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(252, 42)
        Me.GunaButton2.TabIndex = 2
        Me.GunaButton2.Text = "Save"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox3
        '
        Me.BunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox3, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox3.HintText = "Password"
        Me.BunifuMaterialTextbox3.isPassword = False
        Me.BunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox3.LineThickness = 3
        Me.BunifuMaterialTextbox3.Location = New System.Drawing.Point(34, 143)
        Me.BunifuMaterialTextbox3.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox3.Name = "BunifuMaterialTextbox3"
        Me.BunifuMaterialTextbox3.Size = New System.Drawing.Size(252, 44)
        Me.BunifuMaterialTextbox3.TabIndex = 1
        Me.BunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox4
        '
        Me.BunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.anima1.SetDecoration(Me.BunifuMaterialTextbox4, Guna.UI.Animation.DecorationType.None)
        Me.BunifuMaterialTextbox4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox4.HintText = "Username"
        Me.BunifuMaterialTextbox4.isPassword = False
        Me.BunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.BunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray
        Me.BunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.BunifuMaterialTextbox4.LineThickness = 3
        Me.BunifuMaterialTextbox4.Location = New System.Drawing.Point(34, 91)
        Me.BunifuMaterialTextbox4.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox4.Name = "BunifuMaterialTextbox4"
        Me.BunifuMaterialTextbox4.Size = New System.Drawing.Size(252, 44)
        Me.BunifuMaterialTextbox4.TabIndex = 0
        Me.BunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'anima1
        '
        Me.anima1.AnimationType = Guna.UI.Animation.AnimationType.Scale
        Me.anima1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.anima1.DefaultAnimation = Animation1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(735, 537)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.p3)
        Me.anima1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.p1.ResumeLayout(False)
        Me.p1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p3.ResumeLayout(False)
        Me.p3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents p1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents p2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaCheckBox1 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents linkaccnt As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents p3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnx As Guna.UI.WinForms.GunaLabel
    Friend WithEvents BunifuMaterialTextbox5 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GunaCheckBox2 As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuMaterialTextbox3 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox4 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents anima1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents l2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents l1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
