﻿namespace RačunjesKOMPFORM
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label1.Location = new Point(52, 31);
            label1.Name = "label1";
            label1.Size = new Size(74, 13);
            label1.TabIndex = 0;
            label1.Text = "Prvo število";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(52, 70);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Realna komponenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 70);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 2;
            label3.Text = "Imaginarna komponenta";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(113, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            label4.Location = new Point(52, 156);
            label4.Name = "label4";
            label4.Size = new Size(82, 13);
            label4.TabIndex = 5;
            label4.Text = "Drugo število";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 195);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 6;
            label5.Text = "Realna komponenta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(230, 195);
            label6.Name = "label6";
            label6.Size = new Size(138, 15);
            label6.TabIndex = 7;
            label6.Text = "Imaginarna komponenta";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(52, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(230, 232);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 23);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button1.Location = new Point(52, 300);
            button1.Name = "button1";
            button1.Size = new Size(63, 55);
            button1.TabIndex = 10;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            button2.Location = new Point(183, 300);
            button2.Name = "button2";
            button2.Size = new Size(63, 55);
            button2.TabIndex = 11;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button3.Location = new Point(305, 300);
            button3.Name = "button3";
            button3.Size = new Size(63, 55);
            button3.TabIndex = 12;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 407);
            label7.Name = "label7";
            label7.Size = new Size(122, 15);
            label7.TabIndex = 13;
            label7.Text = "Rezultat v obliki a+i*b";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(455, 461);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
    }
}
