namespace WinFormsApp5
{
    partial class frmCar
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
            cmbMake = new ComboBox();
            txtModel = new TextBox();
            cmbYear = new ComboBox();
            txtLicense = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(237, 26);
            label1.Name = "label1";
            label1.Size = new Size(148, 48);
            label1.TabIndex = 0;
            label1.Text = "Add Car";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(61, 117);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Make:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 209);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Year:*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(61, 165);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Model:*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(61, 260);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 4;
            label5.Text = "License Plate:*";
            // 
            // cmbMake
            // 
            cmbMake.FormattingEnabled = true;
            cmbMake.Location = new Point(189, 110);
            cmbMake.Name = "cmbMake";
            cmbMake.Size = new Size(365, 33);
            cmbMake.TabIndex = 1;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(189, 158);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(365, 31);
            txtModel.TabIndex = 2;
            txtModel.KeyPress += txtModel_KeyPress;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(189, 202);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(365, 33);
            cmbYear.TabIndex = 3;
            // 
            // txtLicense
            // 
            txtLicense.Location = new Point(189, 253);
            txtLicense.Name = "txtLicense";
            txtLicense.Size = new Size(365, 31);
            txtLicense.TabIndex = 4;
            txtLicense.KeyPress += txtLicense_KeyPress;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(442, 308);
            button1.Name = "button1";
            button1.Size = new Size(112, 45);
            button1.TabIndex = 5;
            button1.Text = "&Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(311, 308);
            button2.Name = "button2";
            button2.Size = new Size(112, 45);
            button2.TabIndex = 6;
            button2.Text = "&Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmCar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(694, 379);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtLicense);
            Controls.Add(cmbYear);
            Controls.Add(txtModel);
            Controls.Add(cmbMake);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCar";
            Text = "frmCar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cmbMake;
        private TextBox txtModel;
        private ComboBox cmbYear;
        private TextBox txtLicense;
        private Button button1;
        private Button button2;
    }
}