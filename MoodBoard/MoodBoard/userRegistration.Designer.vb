<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userRegistration
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
        Button1 = New Button()
        Button2 = New Button()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        AddStudentToolStripMenuItem1 = New ToolStripMenuItem()
        AddToolStripMenuItem = New ToolStripMenuItem()
        EToolStripMenuItem = New ToolStripMenuItem()
        EditDeleteInstructorToolStripMenuItem = New ToolStripMenuItem()
        SearchStudentToolStripMenuItem = New ToolStripMenuItem()
        SearchInstructorToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(289, 433)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 56)
        Button1.TabIndex = 0
        Button1.Text = "&Register"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(105, 433)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 56)
        Button2.TabIndex = 1
        Button2.Text = "&Login"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(518, 33)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddStudentToolStripMenuItem1, AddToolStripMenuItem, SearchStudentToolStripMenuItem, SearchInstructorToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(77, 29)
        FileToolStripMenuItem.Text = "Home"
        ' 
        ' AddStudentToolStripMenuItem1
        ' 
        AddStudentToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {EToolStripMenuItem})
        AddStudentToolStripMenuItem1.Name = "AddStudentToolStripMenuItem1"
        AddStudentToolStripMenuItem1.Size = New Size(270, 34)
        AddStudentToolStripMenuItem1.Text = "Add Student"
        ' 
        ' AddToolStripMenuItem
        ' 
        AddToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EditDeleteInstructorToolStripMenuItem})
        AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        AddToolStripMenuItem.Size = New Size(270, 34)
        AddToolStripMenuItem.Text = "Add Instructor"
        ' 
        ' EToolStripMenuItem
        ' 
        EToolStripMenuItem.Name = "EToolStripMenuItem"
        EToolStripMenuItem.Size = New Size(270, 34)
        EToolStripMenuItem.Text = "Edit/Delete Student"
        ' 
        ' EditDeleteInstructorToolStripMenuItem
        ' 
        EditDeleteInstructorToolStripMenuItem.Name = "EditDeleteInstructorToolStripMenuItem"
        EditDeleteInstructorToolStripMenuItem.Size = New Size(282, 34)
        EditDeleteInstructorToolStripMenuItem.Text = "Edit/Delete Instructor"
        ' 
        ' SearchStudentToolStripMenuItem
        ' 
        SearchStudentToolStripMenuItem.Name = "SearchStudentToolStripMenuItem"
        SearchStudentToolStripMenuItem.Size = New Size(247, 34)
        SearchStudentToolStripMenuItem.Text = "Search Student"
        ' 
        ' SearchInstructorToolStripMenuItem
        ' 
        SearchInstructorToolStripMenuItem.Name = "SearchInstructorToolStripMenuItem"
        SearchInstructorToolStripMenuItem.Size = New Size(247, 34)
        SearchInstructorToolStripMenuItem.Text = "Search Instructor"
        ' 
        ' userRegistration
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        BackgroundImage = My.Resources.Resources.Add_a_heading
        ClientSize = New Size(518, 565)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "userRegistration"
        Text = "Main Form"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditDeleteInstructorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchInstructorToolStripMenuItem As ToolStripMenuItem
End Class
