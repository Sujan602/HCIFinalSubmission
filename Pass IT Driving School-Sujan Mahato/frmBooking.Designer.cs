namespace WinFormsApp6
{
    partial class frmBooking
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
            label3 = new Label();
            label1 = new Label();
            cmbCourseType = new ComboBox();
            lblStudentFname = new Label();
            lblStudentLname = new Label();
            label2 = new Label();
            label4 = new Label();
            bookinghour = new NumericUpDown();
            dtpBookingDate = new DateTimePicker();
            label5 = new Label();
            cmInstructor = new ComboBox();
            panel2 = new Panel();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)bookinghour).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 132);
            label3.Name = "label3";
            label3.Size = new Size(168, 29);
            label3.TabIndex = 10;
            label3.Text = "Course Type:*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 32);
            label1.Name = "label1";
            label1.Size = new Size(172, 29);
            label1.TabIndex = 9;
            label1.Text = "Student Name:";
            // 
            // cmbCourseType
            // 
            cmbCourseType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCourseType.FormattingEnabled = true;
            cmbCourseType.Items.AddRange(new object[] { "Introductory", "Standard", "Pass Plus", "Driving Test" });
            cmbCourseType.Location = new Point(209, 128);
            cmbCourseType.Name = "cmbCourseType";
            cmbCourseType.Size = new Size(271, 37);
            cmbCourseType.TabIndex = 11;
            // 
            // lblStudentFname
            // 
            lblStudentFname.AutoSize = true;
            lblStudentFname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentFname.Location = new Point(225, 32);
            lblStudentFname.Name = "lblStudentFname";
            lblStudentFname.Size = new Size(70, 29);
            lblStudentFname.TabIndex = 12;
            lblStudentFname.Text = "value";
            // 
            // lblStudentLname
            // 
            lblStudentLname.AutoSize = true;
            lblStudentLname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentLname.Location = new Point(225, 77);
            lblStudentLname.Name = "lblStudentLname";
            lblStudentLname.Size = new Size(70, 29);
            lblStudentLname.TabIndex = 13;
            lblStudentLname.Text = "value";
            lblStudentLname.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(519, 132);
            label2.Name = "label2";
            label2.Size = new Size(174, 29);
            label2.TabIndex = 14;
            label2.Text = "Booking Date:*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 205);
            label4.Name = "label4";
            label4.Size = new Size(176, 29);
            label4.TabIndex = 15;
            label4.Text = "Booking Hour:*";
            // 
            // bookinghour
            // 
            bookinghour.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookinghour.Location = new Point(209, 205);
            bookinghour.Name = "bookinghour";
            bookinghour.Size = new Size(271, 35);
            bookinghour.TabIndex = 16;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBookingDate.Format = DateTimePickerFormat.Short;
            dtpBookingDate.Location = new Point(699, 129);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new Size(253, 31);
            dtpBookingDate.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(519, 207);
            label5.Name = "label5";
            label5.Size = new Size(127, 29);
            label5.TabIndex = 18;
            label5.Text = "Instructor:*";
            // 
            // cmInstructor
            // 
            cmInstructor.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmInstructor.FormattingEnabled = true;
            cmInstructor.Items.AddRange(new object[] { "Doug Wegal", "Jhon Walker" });
            cmInstructor.Location = new Point(699, 197);
            cmInstructor.Name = "cmInstructor";
            cmInstructor.Size = new Size(253, 37);
            cmInstructor.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Location = new Point(12, 265);
            panel2.Name = "panel2";
            panel2.Size = new Size(940, 89);
            panel2.TabIndex = 20;
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
            // listView1
            // 
            listView1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Location = new Point(12, 360);
            listView1.Name = "listView1";
            listView1.Size = new Size(940, 280);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.Click += listView1_Click;
            // 
            // frmBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(975, 648);
            Controls.Add(listView1);
            Controls.Add(panel2);
            Controls.Add(cmInstructor);
            Controls.Add(label5);
            Controls.Add(dtpBookingDate);
            Controls.Add(bookinghour);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lblStudentLname);
            Controls.Add(lblStudentFname);
            Controls.Add(cmbCourseType);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmBooking";
            Text = "Booking Form";
            Load += frmBooking_Load;
            ((System.ComponentModel.ISupportInitialize)bookinghour).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label1;
        private ComboBox cmbCourseType;
        private Label lblStudentFname;
        private Label lblStudentLname;
        private Label label2;
        private Label label4;
        private NumericUpDown bookinghour;
        private DateTimePicker dtpBookingDate;
        private Label label5;
        private ComboBox cmInstructor;
        private Panel panel2;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private ListView listView1;
    }
}