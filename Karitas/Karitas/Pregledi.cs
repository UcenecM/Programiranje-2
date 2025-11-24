using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karitas
{
    public partial class Pregledi : Form
    {
        string pot = Resource1.pot;
        List<Darovi> spremembe = new List<Darovi>();
        int števecSprememb = 0;
        public Pregledi()
        {
            InitializeComponent();
        }

        private void Pregledi_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(pot, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Darovi d;
                //beri iz te datoteke, dokler se ne zgodi SerializationEx
                try
                {
                    while (true)
                    {
                        d = (Darovi)bf.Deserialize(fs);
                        spremembe.Add(d);
                    }
                }
                catch (SerializationException) //ustavi nesk. while
                { }
                dgvPodatki.DataSource = spremembe;

                fs.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Pregledi_Shown(object sender, EventArgs e)
        {
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "###.00 €";
            dgvPodatki.Columns[3].DefaultCellStyle = dcs;
            dgvPodatki.Columns[4].Width = 175;
            foreach (DataGridViewRow row in dgvPodatki.Rows)
            {
                double vrednost = double.Parse(row.Cells[3].Value.ToString());
                if (vrednost < 0)
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                else
                    row.DefaultCellStyle.BackColor = Color.LightGray;
            }
            dgvPodatki.Refresh();
        }

        private void dgvPodatki_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int vrstica = e.RowIndex;
            int stolpec = e.ColumnIndex;
            Darovi d = new Darovi();
            d.ZapŠt = 
            int.Parse(dgvPodatki.Rows[vrstica].Cells[0].Value.ToString());
            d.Datum=
            DateTime.Parse(dgvPodatki.Rows[vrstica].Cells[1].Value.ToString());  
            d.Namen=
            dgvPodatki.Rows[vrstica].Cells[2].Value.ToString();
            d.Znesek =
            double.Parse(dgvPodatki.Rows[vrstica].Cells[3].Value.ToString());
            d.Opombe=
            dgvPodatki.Rows[vrstica].Cells[4].Value.ToString();
            spremembe[vrstica] = d;
            števecSprememb++;
        }
        public void ShraniSpremembe()
        {
            FileInfo fi = new FileInfo(pot);
            fi.Delete();
            FileStream fs = new FileStream(pot, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            foreach (Darovi d in spremembe)
                bf.Serialize(fs, d);
            fs.Close();
            števecSprememb = 0;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShraniSpremembe();
        }

        private void Pregledi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (števecSprememb != 0)
            {
                DialogResult x =
                       MessageBox.Show("Imaš neshranjene spremembe\nShranim sedaj?",
                       "Karitas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                    ShraniSpremembe();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show(" Res brisem vrstico?", "Karitas", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(a== DialogResult.Yes)
            {
                DataGridViewRow vrstica = dgvPodatki.CurrentRow;
                int Št = vrstica.Index;
                BrisiVrstico(Št);
            }
        }
        private void BrisiVrstico(int št)
        {
            spremembe.RemoveAt(št);
            števecSprememb++;
        }
    }
}
