namespace VajaIzjeme
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
            btnDeli = new Button();
            label1 = new Label();
            label2 = new Label();
            lblOutput = new Label();
            txtDeljen = new TextBox();
            txtDelitelj = new TextBox();
            SuspendLayout();
            // 
            // btnDeli
            // 
            btnDeli.Location = new Point(77, 274);
            btnDeli.Name = "btnDeli";
            btnDeli.Size = new Size(75, 23);
            btnDeli.TabIndex = 0;
            btnDeli.Text = "Deli!";
            btnDeli.UseVisualStyleBackColor = true;
            btnDeli.Click += btnDeli_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 77);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Vnesi deljenca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 143);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Vnesi Delitelja";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(317, 282);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(38, 15);
            lblOutput.TabIndex = 3;
            lblOutput.Text = "label3";
            // 
            // txtDeljen
            // 
            txtDeljen.Location = new Point(214, 77);
            txtDeljen.Name = "txtDeljen";
            txtDeljen.Size = new Size(100, 23);
            txtDeljen.TabIndex = 4;
            // 
            // txtDelitelj
            // 
            txtDelitelj.Location = new Point(214, 140);
            txtDelitelj.Name = "txtDelitelj";
            txtDelitelj.Size = new Size(100, 23);
            txtDelitelj.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 438);
            Controls.Add(txtDelitelj);
            Controls.Add(txtDeljen);
            Controls.Add(lblOutput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeli);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDeli;
        private Label label1;
        private Label label2;
        private Label lblOutput;
        private TextBox txtDeljen;
        private TextBox txtDelitelj;
    }
}
