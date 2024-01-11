namespace WinFormsApp6
{
    partial class frmAddCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddCar));
            panel1 = new Panel();
            dtpNextServicingDate = new DateTimePicker();
            dtpLastServicingDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            txtLicensePlate = new TextBox();
            label4 = new Label();
            txtModel = new TextBox();
            label3 = new Label();
            txtYear = new TextBox();
            label2 = new Label();
            txtMake = new TextBox();
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
            panel1.Controls.Add(dtpNextServicingDate);
            panel1.Controls.Add(dtpLastServicingDate);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtLicensePlate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtModel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtYear);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMake);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 210);
            panel1.TabIndex = 1;
            // 
            // dtpNextServicingDate
            // 
            dtpNextServicingDate.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNextServicingDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpNextServicingDate.Format = DateTimePickerFormat.Short;
            dtpNextServicingDate.Location = new Point(715, 145);
            dtpNextServicingDate.Name = "dtpNextServicingDate";
            dtpNextServicingDate.Size = new Size(263, 39);
            dtpNextServicingDate.TabIndex = 6;
            // 
            // dtpLastServicingDate
            // 
            dtpLastServicingDate.CalendarFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpLastServicingDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpLastServicingDate.Format = DateTimePickerFormat.Short;
            dtpLastServicingDate.Location = new Point(264, 145);
            dtpLastServicingDate.Name = "dtpLastServicingDate";
            dtpLastServicingDate.Size = new Size(205, 39);
            dtpLastServicingDate.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(475, 147);
            label5.Name = "label5";
            label5.Size = new Size(240, 29);
            label5.TabIndex = 12;
            label5.Text = "Next Servicing Date:*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 147);
            label6.Name = "label6";
            label6.Size = new Size(235, 29);
            label6.TabIndex = 10;
            label6.Text = "Last Servicing Date:*";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLicensePlate.Location = new Point(715, 83);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(263, 35);
            txtLicensePlate.TabIndex = 4;
            txtLicensePlate.TextChanged += txtLicensePlate_TextChanged;
            txtLicensePlate.KeyPress += txtLicensePlate_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(535, 89);
            label4.Name = "label4";
            label4.Size = new Size(174, 29);
            label4.TabIndex = 8;
            label4.Text = "License Plate:*";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.Location = new Point(644, 19);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(334, 35);
            txtModel.TabIndex = 2;
            txtModel.TextChanged += txtModel_TextChanged;
            txtModel.KeyPress += txtModel_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(541, 22);
            label3.Name = "label3";
            label3.Size = new Size(97, 29);
            label3.TabIndex = 6;
            label3.Text = "Model:*";
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtYear.Location = new Point(126, 89);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(271, 35);
            txtYear.TabIndex = 3;
            txtYear.KeyPress += txtYear_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 92);
            label2.Name = "label2";
            label2.Size = new Size(80, 29);
            label2.TabIndex = 4;
            label2.Text = "Year:*";
            // 
            // txtMake
            // 
            txtMake.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMake.Location = new Point(126, 22);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(271, 35);
            txtMake.TabIndex = 1;
            txtMake.KeyPress += txtMake_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(88, 29);
            label1.TabIndex = 2;
            label1.Text = "Make:*";
            // 
            // listView1
            // 
            listView1.Location = new Point(1, 323);
            listView1.Name = "listView1";
            listView1.Size = new Size(1002, 238);
            listView1.TabIndex = 2;
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
            panel2.Location = new Point(1, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 77);
            panel2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(62, 12);
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
            btnDelete.Location = new Point(713, 12);
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
            btnUpdate.Location = new Point(393, 12);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 53);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "&Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // frmAddCar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1006, 567);
            Controls.Add(panel2);
            Controls.Add(listView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmAddCar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAddCar";
            Load += frmAddCar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtLicensePlate;
        private Label label4;
        private TextBox txtModel;
        private Label label3;
        private TextBox txtYear;
        private Label label2;
        private TextBox txtMake;
        private Label label1;
        private ListView listView1;
        private Panel panel2;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpNextServicingDate;
        private DateTimePicker dtpLastServicingDate;
    }
}