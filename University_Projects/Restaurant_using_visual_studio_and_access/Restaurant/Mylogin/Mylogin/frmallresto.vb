Public Class frmallresto
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Dim frmSeahorse As New frmSeahorse
        frmSeahorse.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim frmtablya As New frmtablya
        frmtablya.Show()
    End Sub

    Private Sub frmallresto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ptnclose_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim frmaltakht As New frmaltakht
        frmaltakht.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Dim frmElnakhel As New frmElnakhel
        frmElnakhel.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Dim frmloqma As New frmloqma
        frmloqma.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Dim frmpizza As New frmpizza
        frmpizza.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dim frmcafe As New frmcafe
        frmcafe.Show()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub
End Class