<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btn_psj = New System.Windows.Forms.Button()
        Me.tb_pl = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_psj
        '
        Me.btn_psj.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btn_psj.Location = New System.Drawing.Point(120, 77)
        Me.btn_psj.Name = "btn_psj"
        Me.btn_psj.Size = New System.Drawing.Size(205, 83)
        Me.btn_psj.TabIndex = 0
        Me.btn_psj.Text = "inisialisi persegi panjang  "
        Me.btn_psj.UseVisualStyleBackColor = False
        '
        'tb_pl
        '
        Me.tb_pl.BackColor = System.Drawing.Color.White
        Me.tb_pl.ForeColor = System.Drawing.Color.Black
        Me.tb_pl.Location = New System.Drawing.Point(120, 179)
        Me.tb_pl.Name = "tb_pl"
        Me.tb_pl.Size = New System.Drawing.Size(205, 26)
        Me.tb_pl.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(475, 363)
        Me.Controls.Add(Me.tb_pl)
        Me.Controls.Add(Me.btn_psj)
        Me.Name = "Form1"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_psj As System.Windows.Forms.Button
    Friend WithEvents tb_pl As System.Windows.Forms.TextBox

End Class
