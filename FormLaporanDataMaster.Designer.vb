<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanDataMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanDataMaster))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(72, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(192, 66)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ADMIN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(72, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 63)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "PELANGGAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(72, 212)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(192, 63)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "KENDARAAN"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(13, 117)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 3
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(128, 301)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 35)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Tutup"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FormLaporanDataMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AppCuciSteam.My.Resources.Resources._164103389_bubble_wallpapers
        Me.ClientSize = New System.Drawing.Size(339, 364)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FormLaporanDataMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLaporanDataMaster"
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
