<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
        Button10 = New Button()
        btnPlus = New Button()
        btnMins = New Button()
        btnDivid = New Button()
        btnMult = New Button()
        TextBox1 = New TextBox()
        btnEq = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(31, 201)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(149, 201)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 1
        Button2.Text = "2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(267, 201)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 2
        Button3.Text = "3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(31, 241)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 3
        Button4.Text = "4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(149, 241)
        Button5.Name = "Button5"
        Button5.Size = New Size(112, 34)
        Button5.TabIndex = 4
        Button5.Text = "5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(267, 241)
        Button6.Name = "Button6"
        Button6.Size = New Size(112, 34)
        Button6.TabIndex = 5
        Button6.Text = "6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(31, 281)
        Button7.Name = "Button7"
        Button7.Size = New Size(112, 34)
        Button7.TabIndex = 6
        Button7.Text = "7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(149, 281)
        Button8.Name = "Button8"
        Button8.Size = New Size(112, 34)
        Button8.TabIndex = 7
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(267, 281)
        Button9.Name = "Button9"
        Button9.Size = New Size(112, 34)
        Button9.TabIndex = 8
        Button9.Text = "9"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Button10
        ' 
        Button10.Location = New Point(149, 321)
        Button10.Name = "Button10"
        Button10.Size = New Size(112, 34)
        Button10.TabIndex = 9
        Button10.Text = "0"
        Button10.UseVisualStyleBackColor = True
        ' 
        ' btnPlus
        ' 
        btnPlus.Location = New Point(414, 161)
        btnPlus.Name = "btnPlus"
        btnPlus.Size = New Size(112, 34)
        btnPlus.TabIndex = 10
        btnPlus.Text = "+"
        btnPlus.UseVisualStyleBackColor = True
        ' 
        ' btnMins
        ' 
        btnMins.Location = New Point(414, 201)
        btnMins.Name = "btnMins"
        btnMins.Size = New Size(112, 34)
        btnMins.TabIndex = 11
        btnMins.Text = "-"
        btnMins.UseVisualStyleBackColor = True
        ' 
        ' btnDivid
        ' 
        btnDivid.Location = New Point(414, 241)
        btnDivid.Name = "btnDivid"
        btnDivid.Size = New Size(112, 34)
        btnDivid.TabIndex = 12
        btnDivid.Text = "/"
        btnDivid.UseVisualStyleBackColor = True
        ' 
        ' btnMult
        ' 
        btnMult.Location = New Point(414, 281)
        btnMult.Name = "btnMult"
        btnMult.Size = New Size(112, 34)
        btnMult.TabIndex = 13
        btnMult.Text = "*"
        btnMult.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(31, 143)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(348, 46)
        TextBox1.TabIndex = 14
        ' 
        ' btnEq
        ' 
        btnEq.Location = New Point(414, 321)
        btnEq.Name = "btnEq"
        btnEq.Size = New Size(112, 34)
        btnEq.TabIndex = 15
        btnEq.Text = "="
        btnEq.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnEq)
        Controls.Add(TextBox1)
        Controls.Add(btnMult)
        Controls.Add(btnDivid)
        Controls.Add(btnMins)
        Controls.Add(btnPlus)
        Controls.Add(Button10)
        Controls.Add(Button9)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMins As Button
    Friend WithEvents btnDivid As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnEq As Button
End Class
