<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpanishWindow
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
        Me.exit2 = New System.Windows.Forms.Button()
        Me.spanishHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'exit2
        '
        Me.exit2.Location = New System.Drawing.Point(94, 91)
        Me.exit2.Name = "exit2"
        Me.exit2.Size = New System.Drawing.Size(75, 23)
        Me.exit2.TabIndex = 1
        Me.exit2.Text = "Adios"
        Me.exit2.UseVisualStyleBackColor = True
        '
        'spanishHello
        '
        Me.spanishHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spanishHello.ForeColor = System.Drawing.Color.Lime
        Me.spanishHello.Location = New System.Drawing.Point(71, 12)
        Me.spanishHello.Name = "spanishHello"
        Me.spanishHello.Size = New System.Drawing.Size(120, 73)
        Me.spanishHello.TabIndex = 2
        Me.spanishHello.Text = " Holla!!!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "click me"
        Me.spanishHello.UseVisualStyleBackColor = True
        '
        'SpanishWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 141)
        Me.Controls.Add(Me.spanishHello)
        Me.Controls.Add(Me.exit2)
        Me.Name = "SpanishWindow"
        Me.Text = "SpanishWindow"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exit2 As System.Windows.Forms.Button
    Friend WithEvents spanishHello As System.Windows.Forms.Button
End Class
