namespace WinFormsApp5
{
    partial class frmMainform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainform));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            addAdminsToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            addInstructorToolStripMenuItem = new ToolStripMenuItem();
            addCarToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            editStudentToolStripMenuItem = new ToolStripMenuItem();
            editInstructorToolStripMenuItem = new ToolStripMenuItem();
            editCarToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            studentToolStripMenuItem1 = new ToolStripMenuItem();
            instructorToolStripMenuItem1 = new ToolStripMenuItem();
            carToolStripMenuItem = new ToolStripMenuItem();
            btnUserName = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1438, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAdminsToolStripMenuItem, addStudentToolStripMenuItem, addInstructorToolStripMenuItem, addCarToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "&File";
            fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // addAdminsToolStripMenuItem
            // 
            addAdminsToolStripMenuItem.Name = "addAdminsToolStripMenuItem";
            addAdminsToolStripMenuItem.Size = new Size(270, 34);
            addAdminsToolStripMenuItem.Text = "Register &Admins";
            addAdminsToolStripMenuItem.Click += addAdminsToolStripMenuItem_Click;
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(270, 34);
            addStudentToolStripMenuItem.Text = "Add &Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // addInstructorToolStripMenuItem
            // 
            addInstructorToolStripMenuItem.Name = "addInstructorToolStripMenuItem";
            addInstructorToolStripMenuItem.Size = new Size(270, 34);
            addInstructorToolStripMenuItem.Text = "Add &Instructor";
            addInstructorToolStripMenuItem.Click += addInstructorToolStripMenuItem_Click;
            // 
            // addCarToolStripMenuItem
            // 
            addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            addCarToolStripMenuItem.Size = new Size(270, 34);
            addCarToolStripMenuItem.Text = "Add &Car";
            addCarToolStripMenuItem.Click += addCarToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editStudentToolStripMenuItem, editInstructorToolStripMenuItem, editCarToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(58, 29);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // editStudentToolStripMenuItem
            // 
            editStudentToolStripMenuItem.Name = "editStudentToolStripMenuItem";
            editStudentToolStripMenuItem.Size = new Size(225, 34);
            editStudentToolStripMenuItem.Text = "Edit &Student";
            editStudentToolStripMenuItem.Click += editStudentToolStripMenuItem_Click;
            // 
            // editInstructorToolStripMenuItem
            // 
            editInstructorToolStripMenuItem.Name = "editInstructorToolStripMenuItem";
            editInstructorToolStripMenuItem.Size = new Size(225, 34);
            editInstructorToolStripMenuItem.Text = "Edit &Instructor";
            // 
            // editCarToolStripMenuItem
            // 
            editCarToolStripMenuItem.Name = "editCarToolStripMenuItem";
            editCarToolStripMenuItem.Size = new Size(225, 34);
            editCarToolStripMenuItem.Text = "Edit &Car";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { studentToolStripMenuItem1, instructorToolStripMenuItem1, carToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(65, 29);
            viewToolStripMenuItem.Text = "&View";
            // 
            // studentToolStripMenuItem1
            // 
            studentToolStripMenuItem1.Name = "studentToolStripMenuItem1";
            studentToolStripMenuItem1.Size = new Size(190, 34);
            studentToolStripMenuItem1.Text = "&Student";
            studentToolStripMenuItem1.Click += studentToolStripMenuItem1_Click;
            // 
            // instructorToolStripMenuItem1
            // 
            instructorToolStripMenuItem1.Name = "instructorToolStripMenuItem1";
            instructorToolStripMenuItem1.Size = new Size(190, 34);
            instructorToolStripMenuItem1.Text = "&Instructor";
            // 
            // carToolStripMenuItem
            // 
            carToolStripMenuItem.Name = "carToolStripMenuItem";
            carToolStripMenuItem.Size = new Size(190, 34);
            carToolStripMenuItem.Text = "&Car";
            // 
            // btnUserName
            // 
            btnUserName.Location = new Point(0, 58);
            btnUserName.Margin = new Padding(4);
            btnUserName.Name = "btnUserName";
            btnUserName.Size = new Size(1438, 70);
            btnUserName.TabIndex = 1;
            btnUserName.Text = "button1";
            btnUserName.UseVisualStyleBackColor = true;
            // 
            // frmMainform
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1438, 724);
            Controls.Add(btnUserName);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmMainform";
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            Load += frmMainform_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem addInstructorToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem editStudentToolStripMenuItem;
        private ToolStripMenuItem editInstructorToolStripMenuItem;
        private ToolStripMenuItem addCarToolStripMenuItem;
        private ToolStripMenuItem editCarToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem studentToolStripMenuItem1;
        private ToolStripMenuItem instructorToolStripMenuItem1;
        private ToolStripMenuItem carToolStripMenuItem;
        private ToolStripMenuItem addAdminsToolStripMenuItem;
        private Button btnUserName;
    }
}