namespace WinFormsApp6
{
    partial class mdiParent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiParent));
            menuStrip1 = new MenuStrip();
            addStudentToolStripMenuItem1 = new ToolStripMenuItem();
            addInstructorToolStripMenuItem1 = new ToolStripMenuItem();
            addCarToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            whatsNewToolStripMenuItem = new ToolStripMenuItem();
            technicalSupportToolStripMenuItem = new ToolStripMenuItem();
            viewHelpToolStripMenuItem = new ToolStripMenuItem();
            lblUser = new Label();
            label1 = new Label();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem1, addInstructorToolStripMenuItem1, addCarToolStripMenuItem1, helpToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(775, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // addStudentToolStripMenuItem1
            // 
            addStudentToolStripMenuItem1.Name = "addStudentToolStripMenuItem1";
            addStudentToolStripMenuItem1.Size = new Size(128, 29);
            addStudentToolStripMenuItem1.Text = "Add &Student";
            addStudentToolStripMenuItem1.Click += addStudentToolStripMenuItem1_Click;
            // 
            // addInstructorToolStripMenuItem1
            // 
            addInstructorToolStripMenuItem1.Name = "addInstructorToolStripMenuItem1";
            addInstructorToolStripMenuItem1.Size = new Size(143, 29);
            addInstructorToolStripMenuItem1.Text = "Add &Instructor";
            addInstructorToolStripMenuItem1.Click += addInstructorToolStripMenuItem1_Click;
            // 
            // addCarToolStripMenuItem1
            // 
            addCarToolStripMenuItem1.Name = "addCarToolStripMenuItem1";
            addCarToolStripMenuItem1.Size = new Size(93, 29);
            addCarToolStripMenuItem1.Text = "Add &Car";
            addCarToolStripMenuItem1.Click += addCarToolStripMenuItem1_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whatsNewToolStripMenuItem, technicalSupportToolStripMenuItem, viewHelpToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(65, 29);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // whatsNewToolStripMenuItem
            // 
            whatsNewToolStripMenuItem.Name = "whatsNewToolStripMenuItem";
            whatsNewToolStripMenuItem.Size = new Size(253, 34);
            whatsNewToolStripMenuItem.Text = "What's New?";
            // 
            // technicalSupportToolStripMenuItem
            // 
            technicalSupportToolStripMenuItem.Name = "technicalSupportToolStripMenuItem";
            technicalSupportToolStripMenuItem.Size = new Size(253, 34);
            technicalSupportToolStripMenuItem.Text = "Technical Support";
            // 
            // viewHelpToolStripMenuItem
            // 
            viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            viewHelpToolStripMenuItem.Size = new Size(253, 34);
            viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(201, 67);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(204, 46);
            lblUser.TabIndex = 8;
            lblUser.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(195, 46);
            label1.TabIndex = 10;
            label1.Text = "Welcome";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(85, 29);
            logoutToolStripMenuItem.Text = "&Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // mdiParent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2023_11_19_190100;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 508);
            Controls.Add(label1);
            Controls.Add(lblUser);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "mdiParent";
            Text = "Main Form";
            WindowState = FormWindowState.Maximized;
            Load += mdiParent_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem whatsNewToolStripMenuItem;
        private ToolStripMenuItem technicalSupportToolStripMenuItem;
        private ToolStripMenuItem viewHelpToolStripMenuItem;
        private Label lblUser;
        private Label label1;
        private ToolStripMenuItem addStudentToolStripMenuItem1;
        private ToolStripMenuItem addInstructorToolStripMenuItem1;
        private ToolStripMenuItem addCarToolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}



