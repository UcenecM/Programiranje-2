using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVnesi_Click(object sender, EventArgs e)
        {
            Darovi d = new Darovi();
            try
            {
                d.ZapŠt = int.Parse(txtZapŠt.Text);
            }
            catch (FormatException)
            {
                d.ZapŠt = 0;
            }
            d.Datum = dtpDatum.Value;
            d.Namen = txtNamen.Text;
            try
            {
                d.Znesek = double.Parse(txtZnesek.Text);
            }
            catch (FormatException)
            {
                d.Znesek = 0;
            }
            d.Opombe = txtOpombe.Text;
            FileStream fs = new FileStream(Resource1.pot, FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();
            labStatus.Text = "Uspešen vnos";
            txtZapŠt.Clear();
            txtNamen.Clear();
            txtOpombe.Clear();
            txtZnesek.Clear();
            txtZapŠt.Focus();
        }

        private void txtZapŠt_Leave(object sender, EventArgs e)
        {
            labStatus.Text = "Pripravljen";
        }
    }
}
