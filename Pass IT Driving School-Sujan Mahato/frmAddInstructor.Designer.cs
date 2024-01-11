namespace WinFormsApp6
{
    partial class frmAddInstructor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddInstructor));
            panel1 = new Panel();
            cmbGender = new ComboBox();
            txtEmail = new TextBox();
            label6 = new Label();
            txtAddress = new TextBox();
            label5 = new Label();
            txtContact = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtLname = new TextBox();
            label2 = new Label();
            txtFname = new TextBox();
            label1 = new Label();
            listView1 = new ListView();
            panel2 = new Panel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(cmbGender);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtContact);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtLname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtFname);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 233);
            panel1.TabIndex = 1;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(184, 106);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(253, 37);
            cmbGender.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(632, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(276, 35);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(465, 170);
            label6.Name = "label6";
            label6.Size = new Size(90, 29);
            label6.TabIndex = 12;
            label6.Text = "Email:*";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(184, 167);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(253, 35);
            txtAddress.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(17, 170);
            label5.Name = "label5";
            label5.Size = new Size(118, 29);
            label5.TabIndex = 10;
            label5.Text = "Address:*";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContact.Location = new Point(632, 106);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(276, 35);
            txtContact.TabIndex = 4;
            txtContact.KeyPress += txtContact_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(465, 109);
            label4.Name = "label4";
            label4.Size = new Size(154, 29);
            label4.TabIndex = 8;
            label4.Text = " Contact No:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 114);
            label3.Name = "label3";
            label3.Size = new Size(110, 29);
            label3.TabIndex = 6;
            label3.Text = "Gender:*";
            // 
            // txtLname
            // 
            txtLname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLname.Location = new Point(632, 52);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(276, 35);
            txtLname.TabIndex = 2;
            txtLname.TextChanged += txtLname_TextChanged;
            txtLname.KeyPress += txtLname_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(465, 55);
            label2.Name = "label2";
            label2.Size = new Size(144, 29);
            label2.TabIndex = 4;
            label2.Text = "Last Name:*";
            // 
            // txtFname
            // 
            txtFname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFname.Location = new Point(184, 52);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(253, 35);
            txtFname.TabIndex = 1;
            txtFname.KeyPress += txtFname_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 55);
            label1.Name = "label1";
            label1.Size = new Size(147, 29);
            label1.TabIndex = 2;
            label1.Text = "First Name:*";
            // 
            // listView1
            // 
            listView1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(2, 336);
            listView1.Name = "listView1";
            listView1.Size = new Size(934, 314);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Click += listView1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Location = new Point(2, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 89);
            panel2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(219, 17);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(190, 53);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(718, 17);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 53);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "&Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(465, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 53);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmAddInstructor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 655);
            Controls.Add(listView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAddInstructor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddInstructor";
            Load += frmAddInstructor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cmbGender;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtAddress;
        private Label label5;
        private TextBox txtContact;
        private Label label4;
        private Label label3;
        private TextBox txtLname;
        private Label label2;
        private TextBox txtFname;
        private Label label1;
        private ListView listView1;
        private Panel panel2;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}