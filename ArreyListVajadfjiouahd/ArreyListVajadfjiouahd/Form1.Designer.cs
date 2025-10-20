namespace ArreyListVajadfjiouahd
{
    partial class Arrey
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
            btnDodaj = new Button();
            btnUdstrani = new Button();
            btnPrvi = new Button();
            btnZadnji = new Button();
            btnPrazn = new Button();
            btnVsebuje = new Button();
            btnPozicija = new Button();
            btnTrim = new Button();
            btnStatistika = new Button();
            btnIzpisi = new Button();
            txtKonzola = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 39);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Vnesi nekaj";
            // 
            // txtVnos
            // 
            txtVnos.Location = new Point(222, 39);
            txtVnos.Name = "txtVnos";
            txtVnos.Size = new Size(188, 33);
            txtVnos.TabIndex = 1;
            // 
            // btnDodaj
            // 
            btnDodaj.Location = new Point(485, 39);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 33);
            btnDodaj.TabIndex = 2;
            btnDodaj.Text = "Dodaj";
            btnDodaj.UseVisualStyleBackColor = true;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // btnUdstrani
            // 
            btnUdstrani.Location = new Point(75, 143);
            btnUdstrani.Name = "btnUdstrani";
            btnUdstrani.Size = new Size(112, 33);
            btnUdstrani.TabIndex = 3;
            btnUdstrani.Text = "Odstrani";
            btnUdstrani.UseVisualStyleBackColor = true;
            btnUdstrani.Click += btnUdstrani_Click;
            // 
            // btnPrvi
            // 
            btnPrvi.AutoSize = true;
            btnPrvi.Location = new Point(276, 143);
            btnPrvi.Name = "btnPrvi";
            btnPrvi.Size = new Size(112, 35);
            btnPrvi.TabIndex = 4;
            btnPrvi.Text = "Prvi";
            btnPrvi.UseVisualStyleBackColor = true;
            btnPrvi.Click += btnPrvi_Click;
            // 
            // btnZadnji
            // 
            btnZadnji.Location = new Point(485, 143);
            btnZadnji.Name = "btnZadnji";
            btnZadnji.Size = new Size(112, 33);
            btnZadnji.TabIndex = 5;
            btnZadnji.Text = "Zadnji";
            btnZadnji.UseVisualStyleBackColor = true;
            btnZadnji.Click += btnZadnji_Click;
            // 
            // btnPrazn
            // 
            btnPrazn.Location = new Point(75, 256);
            btnPrazn.Name = "btnPrazn";
            btnPrazn.Size = new Size(112, 33);
            btnPrazn.TabIndex = 6;
            btnPrazn.Text = "Je prazen?";
            btnPrazn.UseVisualStyleBackColor = true;
            btnPrazn.Click += btnPrazn_Click;
            // 
            // btnVsebuje
            // 
            btnVsebuje.Location = new Point(276, 256);
            btnVsebuje.Name = "btnVsebuje";
            btnVsebuje.Size = new Size(112, 33);
            btnVsebuje.TabIndex = 7;
            btnVsebuje.Text = "Vsebuje";
            btnVsebuje.UseVisualStyleBackColor = true;
            btnVsebuje.Click += btnVsebuje_Click;
            // 
            // btnPozicija
            // 
            btnPozicija.Location = new Point(485, 256);
            btnPozicija.Name = "btnPozicija";
            btnPozicija.Size = new Size(112, 33);
            btnPozicija.TabIndex = 8;
            btnPozicija.Text = "Pozicija";
            btnPozicija.UseVisualStyleBackColor = true;
            btnPozicija.Click += btnPozicija_Click;
            // 
            // btnTrim
            // 
            btnTrim.Location = new Point(75, 371);
            btnTrim.Name = "btnTrim";
            btnTrim.Size = new Size(112, 33);
            btnTrim.TabIndex = 9;
            btnTrim.Text = "Trim";
            btnTrim.UseVisualStyleBackColor = true;
            btnTrim.Click += btnTrim_Click;
            // 
            // btnStatistika
            // 
            btnStatistika.Location = new Point(276, 371);
            btnStatistika.Name = "btnStatistika";
            btnStatistika.Size = new Size(112, 33);
            btnStatistika.TabIndex = 10;
            btnStatistika.Text = "Statistika";
            btnStatistika.UseVisualStyleBackColor = true;
            btnStatistika.Click += btnStatistika_Click;
            // 
            // btnIzpisi
            // 
            btnIzpisi.Location = new Point(485, 371);
            btnIzpisi.Name = "btnIzpisi";
            btnIzpisi.Size = new Size(112, 33);
            btnIzpisi.TabIndex = 11;
            btnIzpisi.Text = "Izpiši";
            btnIzpisi.UseVisualStyleBackColor = true;
            btnIzpisi.Click += btnIzpisi_Click;
            // 
            // txtKonzola
            // 
            txtKonzola.Location = new Point(75, 456);
            txtKonzola.Multiline = true;
            txtKonzola.Name = "txtKonzola";
            txtKonzola.Size = new Size(522, 124);
            txtKonzola.TabIndex = 12;
            // 
            // Arrey
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 592);
            Controls.Add(txtKonzola);
            Controls.Add(btnIzpisi);
            Controls.Add(btnStatistika);
            Controls.Add(btnTrim);
            Controls.Add(btnPozicija);
            Controls.Add(btnVsebuje);
            Controls.Add(btnPrazn);
            Controls.Add(btnZadnji);
            Controls.Add(btnPrvi);
            Controls.Add(btnUdstrani);
            Controls.Add(btnDodaj);
            Controls.Add(txtVnos);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(5);
            Name = "Arrey";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVnos;
        private Button btnDodaj;
        private Button btnUdstrani;
        private Button btnPrvi;
        private Button btnZadnji;
        private Button btnPrazn;
        private Button btnVsebuje;
        private Button btnPozicija;
        private Button btnTrim;
        private Button btnStatistika;
        private Button btnIzpisi;
        private TextBox txtKonzola;
    }
}
