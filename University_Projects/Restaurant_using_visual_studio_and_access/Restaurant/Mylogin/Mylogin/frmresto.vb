Imports AAJdbController
Public Class frmresto

    Private Sub frmresto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ptnadd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ptnclose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim frmtablya As New frmtablya
        frmtablya.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim frmmakeorder As New frmmakeorder
        frmmakeorder.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim frmSeahorse As New frmSeahorse
        frmSeahorse.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim frmElnakhel As New frmElnakhel
        frmElnakhel.Show()
    End Sub

    Private Sub GunaNumeric1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim frmloqma As New frmloqma
        frmloqma.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim frmcafe As New frmcafe
        frmcafe.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim frmaltakht As New frmaltakht
        frmaltakht.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim frmpizza As New frmpizza
        frmpizza.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim frmteamwork As New frmteamwork
        frmteamwork.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        Dim frmteamwork As New frmteamwork
        frmteamwork.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Dim frmallresto As New frmallresto
        frmallresto.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Dim frmsu As New frmsu
        frmsu.Show()
    End Sub
End Class