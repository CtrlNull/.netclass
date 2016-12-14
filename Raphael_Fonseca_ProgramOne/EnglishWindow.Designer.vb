<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnglishWindow
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
        Me.exit3 = New System.Windows.Forms.Button()
        Me.englishHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'exit3
        '
        Me.exit3.Location = New System.Drawing.Point(101, 75)
        Me.exit3.Name = "exit3"
        Me.exit3.Size = New System.Drawing.Size(75, 23)
        Me.exit3.TabIndex = 1
        Me.exit3.Text = "Exit"
        Me.exit3.UseVisualStyleBackColor = True
        '
        'englishHello
        '
        Me.englishHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.englishHello.Location = New System.Drawing.Point(71, 13)
        Me.englishHello.Name = "englishHello"
        Me.englishHello.Size = New System.Drawing.Size(136, 58)
        Me.englishHello.TabIndex = 2
        Me.englishHello.Text = " Hello!!!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click ME"
        Me.englishHello.UseVisualStyleBackColor = True
        '
        'EnglishWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 110)
        Me.Controls.Add(Me.englishHello)
        Me.Controls.Add(Me.exit3)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "EnglishWindow"
        Me.Text = "EnglishWindow"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents exit3 As System.Windows.Forms.Button
    Friend WithEvents englishHello As System.Windows.Forms.Button
End Class
