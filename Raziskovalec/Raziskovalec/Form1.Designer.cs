namespace Raziskovalec
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
            trvDrevo = new TreeView();
            label1 = new Label();
            label2 = new Label();
            txtA = new TextBox();
            txtUstvarjena = new TextBox();
            SuspendLayout();
            // 
            // trvDrevo
            // 
            trvDrevo.Dock = DockStyle.Top;
            trvDrevo.Location = new Point(0, 0);
            trvDrevo.Name = "trvDrevo";
            trvDrevo.Size = new Size(800, 299);
            trvDrevo.TabIndex = 0;
            trvDrevo.BeforeExpand += trvDrevo_BeforeExpand;
            trvDrevo.AfterSelect += trvDrevo_AfterSelect;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 336);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 1;
            label1.Text = "Atribut";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 379);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Ustvarjena";
            // 
            // txtA
            // 
            txtA.Location = new Point(194, 331);
            txtA.Name = "txtA";
            txtA.Size = new Size(279, 23);
            txtA.TabIndex = 3;
            // 
            // txtUstvarjena
            // 
            txtUstvarjena.Location = new Point(194, 369);
            txtUstvarjena.Name = "txtUstvarjena";
            txtUstvarjena.Size = new Size(279, 23);
            txtUstvarjena.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 756);
            Controls.Add(txtUstvarjena);
            Controls.Add(txtA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trvDrevo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView trvDrevo;
        private Label label1;
        private Label label2;
        private TextBox txtA;
        private TextBox txtUstvarjena;
    }
}
