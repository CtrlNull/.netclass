<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class noMatter
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
        Me.noMatterBttn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'noMatterBttn
        '
        Me.noMatterBttn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noMatterBttn.ForeColor = System.Drawing.Color.DarkRed
        Me.noMatterBttn.Location = New System.Drawing.Point(45, 32)
        Me.noMatterBttn.Name = "noMatterBttn"
        Me.noMatterBttn.Size = New System.Drawing.Size(163, 134)
        Me.noMatterBttn.TabIndex = 0
        Me.noMatterBttn.Text = "No Matter what " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    langauge," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   or time zone." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i hope you are having " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  an ex" & _
    "cellent day!!!"
        Me.noMatterBttn.UseVisualStyleBackColor = True
        '
        'noMatter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 205)
        Me.Controls.Add(Me.noMatterBttn)
        Me.Name = "noMatter"
        Me.Text = "noMatter"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents noMatterBttn As System.Windows.Forms.Button
End Class
