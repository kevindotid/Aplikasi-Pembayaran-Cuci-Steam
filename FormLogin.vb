Imports System.Data.Odbc
Public Class FormLogin

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
    End Sub
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Kode Admin dan Password Tidak Boleh Kosong!")
        Else
            Call koneksi()
            Cmd = New OdbcCommand("Select * From tbl_admin where kodeadmin='" & TextBox1.Text & "' and passwordadmin = '" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Terbuka()
                FormMenuUtama.STLabel2.Text = Rd!KodeAdmin
                FormMenuUtama.STLabel4.Text = Rd!NamaAdmin
                FormMenuUtama.STLabel6.Text = Rd!LevelAdmin
                If FormMenuUtama.STLabel6.Text = "USER" Then
                    FormMenuUtama.AdminToolStripMenuItem.Enabled = False
                    FormMenuUtama.KendaraanToolStripMenuItem.Enabled = False
                    FormMenuUtama.LaporanOrderToolStripMenuItem.Enabled = False
                ElseIf FormMenuUtama.STLabel6.Text = "ADMIN" Then
                    FormMenuUtama.AdminToolStripMenuItem.Enabled = True
                    FormMenuUtama.KendaraanToolStripMenuItem.Enabled = True
                End If
            Else
                MsgBox("Kodeadmin atau Password Salah!")
            End If
            End If
    End Sub
End Class