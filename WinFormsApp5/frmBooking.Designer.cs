namespace WinFormsApp5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox7 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(223, 44);
            label1.Name = "label1";
            label1.Size = new Size(303, 54);
            label1.TabIndex = 0;
            label1.Text = "Booking Course";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 142);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Name:*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 193);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 2;
            label3.Text = "Course Type:*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 295);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 3;
            label4.Text = "Start Date:*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 399);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 4;
            label5.Text = "Instructor Name:*";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 344);
            label6.Name = "label6";
            label6.Size = new Size(128, 25);
            label6.TabIndex = 5;
            label6.Text = "Training Time:*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 458);
            label7.Name = "label7";
            label7.Size = new Size(163, 25);
            label7.TabIndex = 6;
            label7.Text = "Car Plate Number:*";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(261, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(359, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(261, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(359, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(261, 292);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(359, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(261, 396);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(359, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(261, 340);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(359, 31);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(261, 455);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(359, 31);
            textBox6.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(492, 558);
            button1.Name = "button1";
            button1.Size = new Size(128, 54);
            button1.TabIndex = 13;
            button1.Text = "&Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(341, 558);
            button2.Name = "button2";
            button2.Size = new Size(128, 54);
            button2.TabIndex = 14;
            button2.Text = "&Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(261, 241);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(359, 31);
            textBox7.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(94, 244);
            label8.Name = "label8";
            label8.Size = new Size(51, 25);
            label8.TabIndex = 15;
            label8.Text = "Fee:*";
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(905, 646);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Booking";
            Text = "Booking";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private Button button2;
        private TextBox textBox7;
        private Label label8;
    }
}