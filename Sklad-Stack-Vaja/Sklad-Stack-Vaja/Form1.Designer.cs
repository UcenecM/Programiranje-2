namespace Sklad_Stack_Vaja
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
            txtVnos = new TextBox();
            lblStatus = new Label();
            btnPush = new Button();
            btnPop = new Button();
            btnPeek = new Button();
            btnPrazn = new Button();
            btnIsci = new Button();
            btnIzpis = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 82);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Vnesi niz:";
            // 
            // txtVnos
            // 
            txtVnos.Location = new Point(119, 74);
            txtVnos.Name = "txtVnos";
            txtVnos.Size = new Size(100, 23);
            txtVnos.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(43, 248);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(31, 15);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "tretji";
           
            // 
            // btnPush
            // 
            btnPush.Location = new Point(291, 43);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(77, 42);
            btnPush.TabIndex = 5;
            btnPush.Text = "push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(410, 43);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(77, 42);
            btnPop.TabIndex = 6;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(291, 96);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(77, 42);
            btnPeek.TabIndex = 7;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPrazn
            // 
            btnPrazn.Location = new Point(410, 91);
            btnPrazn.Name = "btnPrazn";
            btnPrazn.Size = new Size(77, 42);
            btnPrazn.TabIndex = 8;
            btnPrazn.Text = "Je prazen?";
            btnPrazn.UseVisualStyleBackColor = true;
            btnPrazn.Click += btnPrazn_Click;
            // 
            // btnIsci
            // 
            btnIsci.Location = new Point(291, 144);
            btnIsci.Name = "btnIsci";
            btnIsci.Size = new Size(77, 42);
            btnIsci.TabIndex = 9;
            btnIsci.Text = "Išči";
            btnIsci.UseVisualStyleBackColor = true;
            btnIsci.Click += btnIsci_Click;
            // 
            // btnIzpis
            // 
            btnIzpis.Location = new Point(410, 144);
            btnIzpis.Name = "btnIzpis";
            btnIzpis.Size = new Size(77, 42);
            btnIzpis.TabIndex = 10;
            btnIzpis.Text = "Izpis";
            btnIzpis.UseVisualStyleBackColor = true;
            btnIzpis.Click += btnIzpis_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 337);
            Controls.Add(btnIzpis);
            Controls.Add(btnIsci);
            Controls.Add(btnPrazn);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(lblStatus);
            Controls.Add(txtVnos);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVnos;
        private Label lblStatus;
        private Button btnPush;
        private Button btnPop;
        private Button btnPeek;
        private Button btnPrazn;
        private Button btnIsci;
        private Button btnIzpis;
    }
}
