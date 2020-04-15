Public Class FormMenuUtama
    Sub Terkunci()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        STLabel2.Text = ""
        STLabel4.Text = ""
        STLabel6.Text = ""
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
        STLabel10.Text = Today
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Terkunci()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        FormMasterAdmin.ShowDialog()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PelangganToolStripMenuItem.Click
        FormMasterPelanggan.ShowDialog()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        STLabel8.Text = TimeOfDay
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        FormTransaksi.ShowDialog()
    End Sub

    Private Sub KendaraanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KendaraanToolStripMenuItem.Click
        FormMasterKendaraan.ShowDialog()
    End Sub

    Private Sub PembayaranToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LaporanDataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataMasterToolStripMenuItem.Click
        FormLaporanDataMaster.ShowDialog()
    End Sub

    Private Sub LaporanOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanOrderToolStripMenuItem.Click
        FormLaporanKeseluruhan.ShowDialog()
    End Sub
End Class
