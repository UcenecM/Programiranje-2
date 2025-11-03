namespace IgraGoFish
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
            Txt1 = new Label();
            txtIme = new TextBox();
            label1 = new Label();
            txtIgra = new TextBox();
            Kompleti = new Label();
            txtKompleti = new TextBox();
            label2 = new Label();
            btnAsk = new Button();
            btnStart = new Button();
            lstVRokah = new ListBox();
            SuspendLayout();
            // 
            // Txt1
            // 
            Txt1.AutoSize = true;
            Txt1.Location = new Point(36, 14);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(61, 15);
            Txt1.TabIndex = 0;
            Txt1.Text = "Tvoje ime:";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(36, 41);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(113, 23);
            txtIme.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 76);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 2;
            label1.Text = "Igra";
            // 
            // txtIgra
            // 
            txtIgra.Location = new Point(36, 94);
            txtIgra.Multiline = true;
            txtIgra.Name = "txtIgra";
            txtIgra.Size = new Size(212, 195);
            txtIgra.TabIndex = 3;
            // 
            // Kompleti
            // 
            Kompleti.AutoSize = true;
            Kompleti.Location = new Point(36, 306);
            Kompleti.Name = "Kompleti";
            Kompleti.Size = new Size(55, 15);
            Kompleti.TabIndex = 4;
            Kompleti.Text = "Kompleti";
            // 
            // txtKompleti
            // 
            txtKompleti.Location = new Point(36, 324);
            txtKompleti.Multiline = true;
            txtKompleti.Name = "txtKompleti";
            txtKompleti.Size = new Size(212, 195);
            txtKompleti.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(350, 76);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 6;
            label2.Text = "Igra";
            // 
            // btnAsk
            // 
            btnAsk.Location = new Point(350, 482);
            btnAsk.Name = "btnAsk";
            btnAsk.Size = new Size(212, 37);
            btnAsk.TabIndex = 8;
            btnAsk.Text = "Vprašaj za karto";
            btnAsk.UseVisualStyleBackColor = true;
            btnAsk.Click += btnAsk_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(173, 41);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 9;
            btnStart.Text = "Začni";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lstVRokah
            // 
            lstVRokah.FormattingEnabled = true;
            lstVRokah.ItemHeight = 15;
            lstVRokah.Location = new Point(350, 94);
            lstVRokah.Name = "lstVRokah";
            lstVRokah.Size = new Size(212, 379);
            lstVRokah.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 573);
            Controls.Add(lstVRokah);
            Controls.Add(btnStart);
            Controls.Add(btnAsk);
            Controls.Add(label2);
            Controls.Add(txtKompleti);
            Controls.Add(Kompleti);
            Controls.Add(txtIgra);
            Controls.Add(label1);
            Controls.Add(txtIme);
            Controls.Add(Txt1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Txt1;
        private TextBox txtIme;
        private Label label1;
        private TextBox txtIgra;
        private Label Kompleti;
        private TextBox txtKompleti;
        private Label label2;
        private Button btnAsk;
        private Button btnStart;
        private ListBox lstVRokah;
    }
}
