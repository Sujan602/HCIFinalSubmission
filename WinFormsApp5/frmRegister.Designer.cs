namespace WinFormsApp5
{
    partial class frmRegister
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            cmbRole = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(229, 40);
            label1.Name = "label1";
            label1.Size = new Size(518, 48);
            label1.TabIndex = 0;
            label1.Text = "New Admin User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(154, 158);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "First Name:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(154, 204);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Name:*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(154, 244);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 3;
            label4.Text = "Email:*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(154, 288);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 4;
            label5.Text = "Phone Number:*";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(295, 151);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(387, 31);
            txtFname.TabIndex = 5;
            txtFname.KeyPress += textBox1_KeyPress;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(295, 197);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(387, 31);
            txtLname.TabIndex = 6;
            txtLname.TextChanged += textBox2_TextChanged;
            txtLname.KeyPress += textBox2_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(295, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(387, 31);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(295, 281);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(387, 31);
            txtPhone.TabIndex = 8;
            txtPhone.TextChanged += textBox4_TextChanged;
            txtPhone.KeyPress += textBox4_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(536, 406);
            button1.Name = "button1";
            button1.Size = new Size(146, 53);
            button1.TabIndex = 13;
            button1.Text = "&Create User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(385, 406);
            button2.Name = "button2";
            button2.Size = new Size(123, 53);
            button2.TabIndex = 14;
            button2.Text = "&Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(154, 345);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 11;
            label6.Text = "Role:*";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Administrator", "Employee1", "Employee2" });
            cmbRole.Location = new Point(295, 338);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(387, 33);
            cmbRole.TabIndex = 12;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(949, 495);
            Controls.Add(cmbRole);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Button button1;
        private Button button2;
        private Label label6;
        private ComboBox cmbRole;
    }
}