Imports AAJdbController
Public Class frmloqma
    Dim s As New AAJControl(DatabaseType.OleDb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=LOQMA.accdb")

    Sub LoadData()
        DataGridView1.DataSource = s.Table("select * from MENU")
    End Sub
    Private Sub frmloqma_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub ptnclose_Click(sender As Object, e As EventArgs) Handles ptnclose.Click
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        Dim frmmakeorder As New frmmakeorder
        frmmakeorder.Show()
    End Sub
End Class