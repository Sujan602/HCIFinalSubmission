<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnMove = New Button()
        txt1 = New RichTextBox()
        txt2 = New RichTextBox()
        SuspendLayout()
        ' 
        ' btnMove
        ' 
        btnMove.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnMove.Location = New Point(407, 258)
        btnMove.Name = "btnMove"
        btnMove.Size = New Size(160, 65)
        btnMove.TabIndex = 0
        btnMove.Text = "Transfer"
        btnMove.UseVisualStyleBackColor = True
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(107, 12)
        txt1.Name = "txt1"
        txt1.Size = New Size(192, 232)
        txt1.TabIndex = 1
        txt1.Text = ""
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(664, 12)
        txt2.Name = "txt2"
        txt2.Size = New Size(196, 232)
        txt2.TabIndex = 2
        txt2.Text = ""
        ' 
        ' frm1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1128, 450)
        Controls.Add(txt2)
        Controls.Add(txt1)
        Controls.Add(btnMove)
        Name = "frm1"
        Text = "First Design"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnMove As Button
    Friend WithEvents txt1 As RichTextBox
    Friend WithEvents txt2 As RichTextBox
End Class
