using System;
using System.IO;
using System.Windows.Forms;

namespace Raziskovalec
{
    public enum ItemType
    {
        Mapa,
        Datoteka
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // === NALOŽI CELOTNO DREVO Z RESNIÈNIMI DATOTEKAMI ===
        private void Form1_Load(object sender, EventArgs e)
        {
            NaloziDrevo();
        }

        // === USTVARI KORENSKE VOZLE ZA LOGIÈNE ENOTE ===
        private void NaloziDrevo()
        {
            trvDrevo.Nodes.Clear();

            foreach (string imeDiska in Directory.GetLogicalDrives())
            {
                try
                {
                    TreeNode koren = new TreeNode(imeDiska);
                    koren.Tag = ItemType.Mapa;
                    trvDrevo.Nodes.Add(koren);
                    NapolniMapo(koren, imeDiska);
                }
                catch
                {
                    // preskoèi, èe enota ni dostopna
                }
            }
        }


        // === NAPOLNI MAPE Z NJIHOVIMI PODMAPAMI IN DATOTEKAMI ===
        private void NapolniMapo(TreeNode vozel, string pot)
        {
            try
            {
                // Dodaj mape
                foreach (string dir in Directory.GetDirectories(pot))
                {
                    TreeNode mapVozel = new TreeNode(Path.GetFileName(dir));
                    mapVozel.Tag = ItemType.Mapa;
                    vozel.Nodes.Add(mapVozel);

                    // rekurzivno dodaj vsebino
                    NapolniMapo(mapVozel, dir);
                }

                // Dodaj datoteke
                foreach (string dat in Directory.GetFiles(pot))
                {
                    TreeNode datVozel = new TreeNode(Path.GetFileName(dat));
                    datVozel.Tag = ItemType.Datoteka;
                    vozel.Nodes.Add(datVozel);
                }
            }
            catch
            {
                // Ni dostopa – preskoèi
            }
        }

        // === OB IZBIRI VOZLA PRIKAŽI LASTNOSTI ===
        private void trvDrevo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag is ItemType)
            {
                string pot = DobiPolnoPot(e.Node);

                switch ((ItemType)e.Node.Tag)
                {
                    case ItemType.Mapa:
                        PrikaziPodatkeMape(pot);
                        break;

                    case ItemType.Datoteka:
                        PrikaziPodatkeDatoteke(pot);
                        break;
                }
            }
        }

        // === POMOŽNA METODA: IZGRADI POLNO POT VOZLA ===
        private string DobiPolnoPot(TreeNode vozel)
        {
            string pot = vozel.Text;
            TreeNode trenutni = vozel.Parent;
            while (trenutni != null)
            {
                pot = Path.Combine(trenutni.Text, pot);
                trenutni = trenutni.Parent;
            }
            return pot;
        }

        // === PRIKAŽI LASTNOSTI MAPE ===
        private void PrikaziPodatkeMape(string pot)
        {
            try
            {
                DirectoryInfo d = new DirectoryInfo(pot);
                txtIme.Text = d.Name;
                txtPot.Text = d.FullName;
                txtVelikost.Text = "-";
                txtDatum.Text = d.CreationTime.ToString();
                txtTip.Text = "Mapa";
            }
            catch
            {
                PocistiPolja();
            }
        }

        // === PRIKAŽI LASTNOSTI DATOTEKE ===
        private void PrikaziPodatkeDatoteke(string pot)
        {
            try
            {
                FileInfo f = new FileInfo(pot);
                txtIme.Text = f.Name;
                txtPot.Text = f.FullName;
                txtVelikost.Text = $"{f.Length / 1024.0:F2} KB";
                txtDatum.Text = f.CreationTime.ToString();
                txtTip.Text = f.Extension;
            }
            catch
            {
                PocistiPolja();
            }
        }

        // === POÈISTI POLJA ===
        private void PocistiPolja()
        {
            txtIme.Clear();
            txtPot.Clear();
            txtVelikost.Clear();
            txtDatum.Clear();
            txtTip.Clear();
        }

        // === MENI: OSVEŽI ===
        private void mniOsvezi_Click(object sender, EventArgs e)
        {
            NaloziDrevo();
            PocistiPolja();
        }

        // === MENI: IZHOD ===
        private void mniIzhod_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // === MENI: O PROGRAMU ===
        private void mniOProgramu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Preprost raziskovalec datotek\nAvtor: [Tvoje ime]\nProgramiranje 2",
                "O programu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
