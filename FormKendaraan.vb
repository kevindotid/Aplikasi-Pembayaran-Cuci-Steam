Imports System.Data.Odbc
Public Class FormMasterKendaraan
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Items.Clear()
        ComboBox1.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        ComboBox1.Enabled = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button1.Text = "Input"
        Button2.Text = "Edit"
        Button3.Text = "Hapus"
        Button4.Text = "Tutup"
        Call koneksi()
        Da = New OdbcDataAdapter("Select * From tbl_kendaraan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_kendaraan")
        DataGridView1.DataSource = Ds.Tables("tbl_kendaraan")
        DataGridView1.ReadOnly = True
    End Sub
    Sub SiapIsi()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        ComboBox1.Enabled = True
        ComboBox1.Items.Add("UNIT")
    End Sub
    Sub MunculSatuan()
        Call koneksi()
        Cmd = New OdbcCommand("select distinct jenissatuan from tbl_kendaraan", Conn)
        Rd = Cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item("jenissatuan"))
        Loop
    End Sub
    Private Sub FormKendaraan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Input" Then
            Button1.Text = "Simpan"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field")
            Else
                Call koneksi()
                Dim InputData As String = "Insert into tbl_kendaraan values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
                Cmd = New OdbcCommand(InputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Edit" Then
            Button2.Text = "Simpan"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field")
            Else
                Call koneksi()
                Dim UpdateData As String = "Update tbl_kendaraan set tipekendaraan='" & TextBox2.Text & "',hargacuci='" & TextBox3.Text & "',jenissatuan='" & ComboBox1.Text & "' where kodekendaraan='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(UpdateData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Update Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New OdbcCommand("Select * From tbl_kendaraan where kodekendaraan='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Kendaraan Tidak Tersedia")
            Else
                TextBox1.Text = Rd.Item("kodekendaraan")
                TextBox2.Text = Rd.Item("tipekendaraan")
                TextBox3.Text = Rd.Item("hargacuci")
                ComboBox1.Text = Rd.Item("jenissatuan")
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "Hapus" Then
            Button3.Text = "Delete"
            Button1.Enabled = False
            Button2.Enabled = False
            Button4.Text = "Batal"
            Call SiapIsi()
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
                MsgBox("Silahkan Isi Semua Field")
            Else
                Call koneksi()
                Dim HapusData As String = "Delete from tbl_kendaraan where kodekendaraan='" & TextBox1.Text & "'"
                Cmd = New OdbcCommand(HapusData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Hapus Data Berhasil")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "Tutup" Then
            Me.Close()
        Else
            Call KondisiAwal()
        End If
    End Sub
End Class