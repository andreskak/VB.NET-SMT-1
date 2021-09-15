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
        Me.components = New System.ComponentModel.Container()
        Me.btn_luas = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tb_luas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_luas
        '
        Me.btn_luas.BackColor = System.Drawing.Color.GreenYellow
        Me.btn_luas.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_luas.Location = New System.Drawing.Point(24, 49)
        Me.btn_luas.Name = "btn_luas"
        Me.btn_luas.Size = New System.Drawing.Size(136, 91)
        Me.btn_luas.TabIndex = 0
        Me.btn_luas.Text = "INISIALISASI LUAS"
        Me.btn_luas.UseVisualStyleBackColor = False
        '
        'tb_luas
        '
        Me.tb_luas.BackColor = System.Drawing.Color.Ivory
        Me.tb_luas.ForeColor = System.Drawing.Color.Black
        Me.tb_luas.Location = New System.Drawing.Point(24, 196)
        Me.tb_luas.Name = "tb_luas"
        Me.tb_luas.Size = New System.Drawing.Size(402, 26)
        Me.tb_luas.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 308)
        Me.Controls.Add(Me.tb_luas)
        Me.Controls.Add(Me.btn_luas)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_luas As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents tb_luas As System.Windows.Forms.TextBox

End Class
