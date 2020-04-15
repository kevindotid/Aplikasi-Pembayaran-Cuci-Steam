Imports System.Data.Odbc
Public Class FormTransaksi
    Dim TglMySQL As String
    Sub KondisiAwal()
        LBLNamaplg.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLabel4.Text
        LBLKembali.Text = ""
        LBLHargaCuci.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox1.Items.Clear()
        Call MunculKodePelanggan()
        Call NomorOtomatis()
        Call BuatKolom()
        Label9.Text = "0"
        LBLTipeKendaraan.Text = ""
        TextBox1.Text = ""
    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles LBLNoTransaksi.Click, LBLTelepon.Click, LBLNamaplg.Click, LBLAlamat.Click, LBLKembali.Click

    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub
    Sub MunculKodePelanggan()
        Call koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call koneksi()
        Cmd = New OdbcCommand("Select * from tbl_pelanggan where kodepelanggan ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaplg.Text = Rd!NamaPelanggan
            LBLAlamat.Text = Rd!AlamatPelanggan
            LBLTelepon.Text = Rd!TelpPelanggan
        End If
    End Sub
    Sub NomorOtomatis()
        Call koneksi()
        Cmd = New OdbcCommand("Select * from tbl_jual where notransaksi in (select max(notransaksi)from tbl_jual)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "C" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "C" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoTransaksi.Text = UrutanKode
    End Sub
    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode")
        DataGridView1.Columns.Add("Tipekendaraan", "Tipe Kendaraan")
        DataGridView1.Columns.Add("Hargacuci", "Harga Cuci")
        DataGridView1.Columns.Add("Subtotal", "Subtotal")
        DataGridView1.Columns.Add("Pembayaran", "Pembayaran")
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New OdbcCommand("Select * From tbl_kendaraan where kodekendaraan='" & TextBox2.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Nomor Polisi Kendaraan Tidak Ada")
            Else
                TextBox2.Text = Rd.Item("kodekendaraan")
                LBLTipeKendaraan.Text = Rd.Item("tipekendaraan")
                LBLHargaCuci.Text = Rd.Item("hargacuci")
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If LBLTipeKendaraan.Text = "" Or TextBox2.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("Silahkan Masukkan Kode lalu Tekan ENTER! dan Pilih Metode Pembayaran")
        Else
            DataGridView1.Rows.Add(New String() {TextBox2.Text, LBLTipeKendaraan.Text, LBLHargaCuci.Text, Val(LBLHargaCuci.Text), ComboBox2.Text})
            Call subtotal()
            TextBox2.Text = ""
            LBLHargaCuci.Text = ""
        End If
    End Sub
    Sub subtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(3).Value
            Label9.Text = hitung

        Next
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TextBox1.Text) < Val(Label9.Text) Then
                MsgBox("Pembayaran Kurang!")
            ElseIf Val(TextBox1.Text) = Val(Label9.Text) Then
                LBLKembali.Text = 0
            ElseIf Val(TextBox1.Text) > Val(Label9.Text) Then
                LBLKembali.Text = Val(TextBox1.Text) - Val(Label9.Text)
                Button1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LBLKembali.Text = "" Or LBLNamaplg.Text = "" Or Label9.Text = "" Then
            MsgBox("Transaksi Belum Dilakukan, Silahkan Masukkan Semua Field Untuk Melakukan Transaksi!")

        Else

            TglMySQL = Format(Today, "yyyy-MM-dd")
            Dim SimpanTransaksi As String = "Insert into tbl_jual values ('" & LBLNoTransaksi.Text & "','" & TglMySQL & "','" & LBLJam.Text & "','" & LBLTipeKendaraan.Text & "','" & Label9.Text & "','" & TextBox1.Text & "','" & LBLKembali.Text & "','" & ComboBox2.Text & "','" & ComboBox1.Text & "','" & FormMenuUtama.STLabel2.Text & "')"
            Cmd = New OdbcCommand(SimpanTransaksi, Conn)
            Cmd.ExecuteNonQuery()
            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Dim SimpanDetail As String = "Insert into tbl_detailjual values('" & LBLNoTransaksi.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(1).Value & "','" & DataGridView1.Rows(Baris).Cells(2).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "','" & DataGridView1.Rows(Baris).Cells(4).Value & "')"
                Cmd = New OdbcCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
            Next
            If MessageBox.Show("Apakah Anda Ingin Mencetak Struk Transaksi?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                AxCrystalReport1.SelectionFormula = "totext({tbl_jual.notransaksi})='" & LBLNoTransaksi.Text & "'"
                AxCrystalReport1.ReportFileName = "struktransaksi.rpt"
                AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                AxCrystalReport1.RetrieveDataFiles()
                AxCrystalReport1.Action = 1

                Call KondisiAwal()
            Else


                Call KondisiAwal()
                MsgBox("Transaksi Berhasil Disimpan")
            End If
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call KondisiAwal()
    End Sub
End Class