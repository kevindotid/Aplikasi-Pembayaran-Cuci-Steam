<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanKeseluruhan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanKeseluruhan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTP1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPakhir = New System.Windows.Forms.DateTimePicker()
        Me.DTPawal = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DTPbulandantahun = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.AxCrystalReport1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.DTP1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(28, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 178)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Harian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tanggal"
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(26, 120)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DTP1
        '
        Me.DTP1.Location = New System.Drawing.Point(79, 53)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(158, 27)
        Me.DTP1.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DTPakhir)
        Me.GroupBox2.Controls.Add(Me.DTPawal)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(318, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 178)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Mingguan"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(102, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 34)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "View"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Tanggal Akhir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tanggal Awal"
        '
        'DTPakhir
        '
        Me.DTPakhir.Location = New System.Drawing.Point(135, 86)
        Me.DTPakhir.Name = "DTPakhir"
        Me.DTPakhir.Size = New System.Drawing.Size(162, 27)
        Me.DTPakhir.TabIndex = 1
        '
        'DTPawal
        '
        Me.DTPawal.Location = New System.Drawing.Point(135, 53)
        Me.DTPawal.Name = "DTPawal"
        Me.DTPawal.Size = New System.Drawing.Size(162, 27)
        Me.DTPawal.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.DTPbulandantahun)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(664, 29)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 178)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan Bulanan"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(100, 116)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 34)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "View"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DTPbulandantahun
        '
        Me.DTPbulandantahun.CustomFormat = "MMMM yyyy"
        Me.DTPbulandantahun.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPbulandantahun.Location = New System.Drawing.Point(115, 59)
        Me.DTPbulandantahun.Name = "DTPbulandantahun"
        Me.DTPbulandantahun.Size = New System.Drawing.Size(157, 22)
        Me.DTPbulandantahun.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Bulan/Tahun"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(391, 229)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 37)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Tutup"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FormLaporanKeseluruhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AppCuciSteam.My.Resources.Resources._164103389_bubble_wallpapers
        Me.ClientSize = New System.Drawing.Size(984, 287)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormLaporanKeseluruhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanKeseluruhan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPakhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPawal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DTPbulandantahun As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
