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
        Me.btn_ll = New System.Windows.Forms.Button()
        Me.ll_text = New System.Windows.Forms.TextBox()
        Me.alas_t = New System.Windows.Forms.TextBox()
        Me.tinggi_t = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_ll
        '
        Me.btn_ll.BackColor = System.Drawing.Color.White
        Me.btn_ll.Location = New System.Drawing.Point(70, 157)
        Me.btn_ll.Name = "btn_ll"
        Me.btn_ll.Size = New System.Drawing.Size(324, 69)
        Me.btn_ll.TabIndex = 0
        Me.btn_ll.Text = "luas lingkaran"
        Me.btn_ll.UseVisualStyleBackColor = False
        '
        'll_text
        '
        Me.ll_text.BackColor = System.Drawing.Color.MintCream
        Me.ll_text.Location = New System.Drawing.Point(70, 232)
        Me.ll_text.Name = "ll_text"
        Me.ll_text.Size = New System.Drawing.Size(324, 26)
        Me.ll_text.TabIndex = 1
        '
        'alas_t
        '
        Me.alas_t.Location = New System.Drawing.Point(89, 63)
        Me.alas_t.Name = "alas_t"
        Me.alas_t.Size = New System.Drawing.Size(100, 26)
        Me.alas_t.TabIndex = 4
        Me.alas_t.Text = "S"
        '
        'tinggi_t
        '
        Me.tinggi_t.Location = New System.Drawing.Point(89, 108)
        Me.tinggi_t.Name = "tinggi_t"
        Me.tinggi_t.Size = New System.Drawing.Size(100, 26)
        Me.tinggi_t.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 398)
        Me.Controls.Add(Me.tinggi_t)
        Me.Controls.Add(Me.alas_t)
        Me.Controls.Add(Me.ll_text)
        Me.Controls.Add(Me.btn_ll)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_ll As System.Windows.Forms.Button
    Friend WithEvents ll_text As System.Windows.Forms.TextBox
    Friend WithEvents alas_t As System.Windows.Forms.TextBox
    Friend WithEvents tinggi_t As System.Windows.Forms.TextBox

End Class
