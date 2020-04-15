Public Class FormLaporanKeseluruhan

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxCrystalReport1.SelectionFormula = "{tbl_jual.tgltransaksi} in date ('" & DTP1.Value & "') to date ('" & DTP1.Value & "')"
        AxCrystalReport1.ReportFileName = "lap-data-harian.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxCrystalReport1.SelectionFormula = "{tbl_jual.tgltransaksi} in date ('" & DTPawal.Value & "') to date ('" & DTPakhir.Value & "')"
        AxCrystalReport1.ReportFileName = "lap-data-mingguan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub DTP1_ValueChanged(sender As Object, e As EventArgs) Handles DTP1.ValueChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxCrystalReport1.SelectionFormula = "{tbl_jual.tgltransaksi} in date ('" & DTPbulandantahun.Value & "') to date ('" & DTPbulandantahun.Value & "')"
        AxCrystalReport1.ReportFileName = "lap-data-bulanan.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub DTPbulandantahun_ValueChanged(sender As Object, e As EventArgs) Handles DTPbulandantahun.ValueChanged

    End Sub
End Class