namespace WinFormsApp5
{
    partial class frmEditStudent
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
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(375, 95);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 29);
            radioButton3.TabIndex = 39;
            radioButton3.TabStop = true;
            radioButton3.Text = "Other";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(247, 95);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(93, 29);
            radioButton2.TabIndex = 38;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(147, 93);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 29);
            radioButton1.TabIndex = 37;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 97);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 36;
            label7.Text = "Gender:*";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 31);
            txtEmail.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 148);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 35;
            label6.Text = "Email:*";
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.Location = new Point(316, 250);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(152, 54);
            btnclear.TabIndex = 34;
            btnclear.Text = "&Delete";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(147, 250);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(130, 54);
            btnsave.TabIndex = 33;
            btnsave.Text = "&Update";
            btnsave.UseVisualStyleBackColor = true;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(147, 201);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(386, 31);
            txtaddress.TabIndex = 32;
            // 
            // txtcontactno
            // 
            txtcontactno.Location = new Point(512, 145);
            txtcontactno.Name = "txtcontactno";
            txtcontactno.Size = new Size(304, 31);
            txtcontactno.TabIndex = 31;
            // 
            // txtlname
            // 
            txtlname.Location = new Point(512, 50);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(304, 31);
            txtlname.TabIndex = 29;
            // 
            // txtfname
            // 
            txtfname.Location = new Point(147, 47);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(229, 31);
            txtfname.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 204);
            label5.Name = "label5";
            label5.Size = new Size(94, 25);
            label5.TabIndex = 27;
            label5.Text = "Address: *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 148);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 26;
            label4.Text = "Contact No:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 50);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 25;
            label3.Text = "Last Name: *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 84);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 50);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 23;
            label1.Text = "First Name: *";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(931, 323);
            dataGridView1.TabIndex = 40;
            // 
            // frmEditStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(955, 661);
            Controls.Add(dataGridView1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label7);
            Controls.Add(txtEmail);
            Controls.Add(label6);
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
            Name = "frmEditStudent";
            Text = "Student Edit Form";
            Load += frmEditStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
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
        private DataGridView dataGridView1;
    }
}