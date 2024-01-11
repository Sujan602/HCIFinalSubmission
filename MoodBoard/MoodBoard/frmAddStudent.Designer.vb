<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddStudent
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
        cmbClassType = New ComboBox()
        Label6 = New Label()
        Button2 = New Button()
        Button1 = New Button()
        Label5 = New Label()
        txtAddress = New TextBox()
        txtPhone = New TextBox()
        txtLname = New TextBox()
        txtFname = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        dtnStartDate = New DateTimePicker()
        Label8 = New Label()
        txtClassTime = New TextBox()
        Label9 = New Label()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' cmbClassType
        ' 
        cmbClassType.FormattingEnabled = True
        cmbClassType.Items.AddRange(New Object() {"Introductory", "Standard", "Pass Plus"})
        cmbClassType.Location = New Point(233, 303)
        cmbClassType.Name = "cmbClassType"
        cmbClassType.Size = New Size(471, 33)
        cmbClassType.TabIndex = 25
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(105, 306)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 25)
        Label6.TabIndex = 24
        Label6.Text = "Course Type:"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(442, 504)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 50)
        Button2.TabIndex = 23
        Button2.Text = "&Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(592, 504)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 50)
        Button1.TabIndex = 22
        Button1.Text = "&Save"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 20F, FontStyle.Underline, GraphicsUnit.Point)
        Label5.Location = New Point(92, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(579, 54)
        Label5.TabIndex = 21
        Label5.Text = "New Student Registration Form"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(233, 255)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(471, 31)
        txtAddress.TabIndex = 20
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(233, 210)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(471, 31)
        txtPhone.TabIndex = 19
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(233, 164)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(471, 31)
        txtLname.TabIndex = 18
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(233, 119)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(471, 31)
        txtFname.TabIndex = 17
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(105, 258)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 25)
        Label4.TabIndex = 16
        Label4.Text = "Address: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(105, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 25)
        Label3.TabIndex = 15
        Label3.Text = "Phone No.:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(105, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 25)
        Label2.TabIndex = 14
        Label2.Text = "Last Name: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(105, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 25)
        Label1.TabIndex = 13
        Label1.Text = "First Name: "
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(105, 403)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 25)
        Label7.TabIndex = 26
        Label7.Text = "Start Date: "
        ' 
        ' dtnStartDate
        ' 
        dtnStartDate.Location = New Point(233, 403)
        dtnStartDate.Name = "dtnStartDate"
        dtnStartDate.Size = New Size(471, 31)
        dtnStartDate.TabIndex = 27
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(105, 448)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 25)
        Label8.TabIndex = 28
        Label8.Text = "Class Time:"
        ' 
        ' txtClassTime
        ' 
        txtClassTime.Location = New Point(233, 445)
        txtClassTime.Name = "txtClassTime"
        txtClassTime.Size = New Size(471, 31)
        txtClassTime.TabIndex = 29
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(105, 355)
        Label9.Name = "Label9"
        Label9.Size = New Size(103, 25)
        Label9.TabIndex = 30
        Label9.Text = "Course Fee:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(233, 349)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(471, 31)
        TextBox1.TabIndex = 31
        ' 
        ' frmAddStudent
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lime
        ClientSize = New Size(800, 581)
        Controls.Add(TextBox1)
        Controls.Add(Label9)
        Controls.Add(txtClassTime)
        Controls.Add(Label8)
        Controls.Add(dtnStartDate)
        Controls.Add(Label7)
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
        Name = "frmAddStudent"
        Text = "Add Student"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmbClassType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLname As TextBox
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtnStartDate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtClassTime As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
