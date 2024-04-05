Public Class Form1
    Private Sub linkaccnt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkaccnt.LinkClicked
        anima1.HideSync(p2)
        anima1.ShowSync(p3)
        l3.Text = "Create Account"
    End Sub

    Private Sub btnx_Click(sender As Object, e As EventArgs) Handles btnx.Click
        anima1.HideSync(p3)
        anima1.ShowSync(p2)
        l3.Text = "Welcome Back"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        anima1.ShowSync(l1)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(l2)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizBlind
        anima1.ShowSync(l3)
        anima1.AnimationType = Guna.UI.Animation.AnimationType.HorizSlide
        anima1.ShowSync(p2)
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If BunifuMaterialTextbox1.Text = "admin" And BunifuMaterialTextbox2.Text = "admin" Then
            MsgBox("Log in Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            frmresto.Show()
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub l2_Click(sender As Object, e As EventArgs) Handles l2.Click

    End Sub

    Private Sub p2_Paint(sender As Object, e As PaintEventArgs) Handles p2.Paint

    End Sub
End Class