namespace WinFormsApp5
{
    partial class frmInstructor
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
            txtEmail = new TextBox();
            label6 = new Label();
            label8 = new Label();
            btnclear = new Button();
            btnsave = new Button();
            txtaddress = new TextBox();
            txtcontactno = new TextBox();
            txtlname = new TextBox();
            txtfname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(284, 253);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(386, 31);
            txtEmail.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 256);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 32;
            label6.Text = "Email:*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(184, 28);
            label8.Name = "label8";
            label8.Size = new Size(415, 37);
            label8.TabIndex = 31;
            label8.Text = "Instructor Registration Form";
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.Location = new Point(364, 420);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(152, 54);
            btnclear.TabIndex = 30;
            btnclear.Text = "&Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(540, 420);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(130, 54);
            btnsave.TabIndex = 29;
            btnsave.Text = "&Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(284, 364);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(386, 31);
            txtaddress.TabIndex = 28;
            // 
            // txtcontactno
            // 
            txtcontactno.Location = new Point(284, 310);
            txtcontactno.Name = "txtcontactno";
            txtcontactno.Size = new Size(386, 31);
            txtcontactno.TabIndex = 27;
            txtcontactno.KeyPress += txtcontactno_KeyPress;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(284, 151);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(386, 31);
            txtlname.TabIndex = 25;
            txtlname.KeyPress += txtlname_KeyPress;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(284, 101);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(386, 31);
            txtfname.TabIndex = 24;
            txtfname.KeyPress += txtfname_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 367);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 23;
            label5.Text = "Address: *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(130, 313);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 22;
            label4.Text = "Contact No:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 154);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 21;
            label3.Text = "Last Name: *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 154);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 104);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 19;
            label1.Text = "First Name: *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 210);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 33;
            label7.Text = "Gender:*";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(284, 206);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 34;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(386, 208);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 35;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(495, 208);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 29);
            radioButton3.TabIndex = 36;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // frmInstructor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(797, 486);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(btnclear);
            Controls.Add(btnsave);
            Controls.Add(txtaddress);
            Controls.Add(txtcontactno);
            Controls.Add(txtlname);
            Controls.Add(txtfname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInstructor";
            Text = "frmInstructor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label label6;
        private Label label8;
        private Button btnclear;
        private Button btnsave;
        private TextBox txtaddress;
        private TextBox txtcontactno;
        private TextBox txtlname;
        private TextBox txtfname;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
    }
}