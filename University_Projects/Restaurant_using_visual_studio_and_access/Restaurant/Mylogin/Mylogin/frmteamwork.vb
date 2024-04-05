Imports AAJdbController
Public Class frmteamwork
    Dim s As New AAJControl(DatabaseType.OleDb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Pizza.accdb")

    Sub LoadData()
        DataGridView1.DataSource = s.Table("select * from Customer")
    End Sub
    Private Sub ptnclose_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub

    Private Sub frmteamwork_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub GunaLabel1_Click(sender As Object, e As EventArgs) Handles GunaLabel1.Click
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub
End Class