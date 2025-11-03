using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgraGoFish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Igra igra;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Vnesi svoje ime", "Ne morem še zaèeti");
                return;
            }
            igra = new Igra(txtIme.Text, new List<string> { "Janez", "Marija" }, txtIgra);
            btnStart.Enabled = false;
            txtIme.Enabled = false;
            btnAsk.Enabled = true;
            UpdateForm();
        }
        private void UpdateForm()
        {
            lstVRokah.Items.Clear();
            foreach (String cardName in igra.KarteIgralca())
                lstVRokah.Items.Add(cardName);
            txtKompleti.Text = igra.OpišiKomplete();
            txtIgra.Text += igra.OpišiVRokah();
            txtIgra.SelectionStart = txtIgra.Text.Length;
            txtIgra.ScrollToCaret();
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            txtIgra.Text = "";
            if (lstVRokah.SelectedIndex < 0)
            {
                MessageBox.Show("Prosim izberi karto");
                return;
            }
            if (igra.IgrajEnKrog(lstVRokah.SelectedIndex))
            {
                txtIgra.Text += "Zmagovalec je... " + igra.ImeZmagovalca();
                txtKompleti.Text = igra.OpišiKomplete();
                btnAsk.Enabled = false;
            }
            else
                UpdateForm();
        }
    }
}
