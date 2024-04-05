Imports AAJdbController
Public Class frmtablya
    Dim s As New AAJControl(DatabaseType.OleDb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Tabliah.accdb")

    Sub LoadData()
        BunifuCustomDataGrid1.DataSource = s.Table("select * from Menu")
    End Sub
    Private Sub frmtablya_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs)
        s.Insert("Item", Sub(p)

                         End Sub)
        LoadData()
    End Sub

    Private Sub BunifuMetroTextbox3_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox5_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BunifuMetroTextbox4_OnValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub
End Class