namespace IgraSkartami
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
            listNak = new ListBox();
            listCel = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listNak
            // 
            listNak.FormattingEnabled = true;
            listNak.ItemHeight = 15;
            listNak.Location = new Point(34, 57);
            listNak.Name = "listNak";
            listNak.Size = new Size(299, 349);
            listNak.TabIndex = 0;
            // 
            // listCel
            // 
            listCel.FormattingEnabled = true;
            listCel.ItemHeight = 15;
            listCel.Location = new Point(459, 57);
            listCel.Name = "listCel";
            listCel.Size = new Size(299, 349);
            listCel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "kup #1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(459, 22);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 3;
            label2.Text = "kup #2(Vse karte)";
            // 
            // button1
            // 
            button1.Location = new Point(34, 424);
            button1.Name = "button1";
            button1.Size = new Size(299, 23);
            button1.TabIndex = 4;
            button1.Text = "Ponastavi kup#1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(459, 424);
            button2.Name = "button2";
            button2.Size = new Size(299, 23);
            button2.TabIndex = 5;
            button2.Text = "Ponastavi kup#2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(34, 465);
            button3.Name = "button3";
            button3.Size = new Size(299, 23);
            button3.TabIndex = 6;
            button3.Text = "Mešaj #1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(459, 465);
            button4.Name = "button4";
            button4.Size = new Size(299, 23);
            button4.TabIndex = 7;
            button4.Text = "Mešaj #2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listCel);
            Controls.Add(listNak);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listNak;
        private ListBox listCel;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
