<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInstructor
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtFname = New TextBox()
        txtLname = New TextBox()
        txtPhone = New TextBox()
        txtAddress = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label6 = New Label()
        cmbClassType = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(43, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 0
        Label1.Text = "First Name: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 154)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 25)
        Label2.TabIndex = 1
        Label2.Text = "Last Name: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 2
        Label3.Text = "Phone No.:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 3
        Label4.Text = "Address: "
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(170, 106)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(278, 31)
        txtFname.TabIndex = 4
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(170, 151)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(278, 31)
        txtLname.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(170, 197)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(278, 31)
        txtPhone.TabIndex = 6
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(170, 242)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(278, 31)
        txtAddress.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F, FontStyle.Underline, GraphicsUnit.Point)
        Label5.Location = New Point(88, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(387, 54)
        Label5.TabIndex = 8
        Label5.Text = "New Instructor Form"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(336, 347)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 50)
        Button1.TabIndex = 9
        Button1.Text = "&Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(186, 347)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 50)
        Button2.TabIndex = 10
        Button2.Text = "&Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 293)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 25)
        Label6.TabIndex = 11
        Label6.Text = "Class Type:"
        ' 
        ' cmbClassType
        ' 
        cmbClassType.FormattingEnabled = True
        cmbClassType.Location = New Point(170, 290)
        cmbClassType.Name = "cmbClassType"
        cmbClassType.Size = New Size(278, 33)
        cmbClassType.TabIndex = 12
        ' 
        ' frmInstructor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lime
        ClientSize = New Size(554, 425)
        Controls.Add(cmbClassType)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(txtAddress)
        Controls.Add(txtPhone)
        Controls.Add(txtLname)
        Controls.Add(txtFname)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmInstructor"
        Text = "Add Instructor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbClassType As ComboBox
End Class
