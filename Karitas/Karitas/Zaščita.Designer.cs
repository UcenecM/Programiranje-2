namespace Karitas
{
    partial class Zaščita
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
            this.btnZascita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZascita
            // 
            this.btnZascita.Location = new System.Drawing.Point(345, 132);
            this.btnZascita.Name = "btnZascita";
            this.btnZascita.Size = new System.Drawing.Size(75, 23);
            this.btnZascita.TabIndex = 0;
            this.btnZascita.Text = "Zaščita";
            this.btnZascita.UseVisualStyleBackColor = true;
            this.btnZascita.Click += new System.EventHandler(this.btnZascita_Click);
            // 
            // Zaščita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 290);
            this.Controls.Add(this.btnZascita);
            this.Name = "Zaščita";
            this.Text = "Zaščita";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZascita;
    }
}