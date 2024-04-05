Imports AAJdbController
Public Class frmmakeorder
    Dim s As New AAJControl(DatabaseType.OleDb, "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=rashad.accdb")

    Sub LoadData()
        BunifuCustomDataGrid1.DataSource = s.Table("select * from M_Proo")
    End Sub
    Private Sub frmmakeorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RashadDataSet.M_Proo' table. You can move, or remove it, as needed.
        Me.M_ProoTableAdapter.Fill(Me.RashadDataSet.M_Proo)
        LoadData()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim frmteamwork As New frmteamwork
        frmteamwork.Show()

    End Sub

    Private Sub BunifuThinButton21_Click(sender As Object, e As EventArgs) Handles BunifuThinButton21.Click
        s.Insert("M_Proo", Sub(p)
                               p.Add("Resturant_Name", BunifuMetroTextbox1.Text)
                               p.Add("Food_Name", BunifuMetroTextbox2.Text)
                               p.Add("amount", BunifuMetroTextbox3.Text)
                           End Sub)
        LoadData()
    End Sub

    Private Sub BunifuMetroTextbox1_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox1.OnValueChanged

    End Sub

    Private Sub BunifuMetroTextbox2_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox2.OnValueChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub ptnclose_Click(sender As Object, e As EventArgs) Handles ptnclose.Click
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub

    Private Sub ptnmenu_Click(sender As Object, e As EventArgs) Handles ptnmenu.Click
        Me.Hide()
        Dim frmresto As New frmresto
        frmresto.Show()
    End Sub

    Private Sub BunifuMetroTextbox3_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMetroTextbox3.OnValueChanged

    End Sub

    Private Sub BunifuCustomDataGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles BunifuCustomDataGrid1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class