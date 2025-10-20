using System.Collections;

namespace ArreyListVajadfjiouahd
{
    public partial class Arrey : Form
    {
        ArrayList a = new ArrayList();

        public Arrey()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            a.Add(txtVnos.Text);
            txtKonzola.Text = "Dodan element v seznam " + txtVnos.Text;
        }

        private void btnUdstrani_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].ToString() == txtVnos.Text)
                {
                    a.RemoveAt(i);
                    i--;
                    txtKonzola.Text = "Vnos " + a[i].ToString() + "je bil izbrisan";
                }
            }
        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Velikost seznama " + a.Count +"\r\n"
            + "kacipateta seznama " + a.Capacity;
        }

        private void btnPrvi_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Prvi vnos je " + a[1].ToString();

        }

        private void btnZadnji_Click(object sender, EventArgs e)
        {

            txtKonzola.Text = "Prvi vnos je " + a[^1].ToString();
        }

        private void btnPrazn_Click(object sender, EventArgs e)
        {
            if (a.Count == 0)
            {
                txtKonzola.Text = "Seznam je prazen";
            }
            else
            {
                txtKonzola.Text = "Seznam ni prazen";
            }
        }

        private void btnVsebuje_Click(object sender, EventArgs e)
        {
            string vnos = txtVnos.Text;

            if (a.Contains(vnos))
            {
                txtKonzola.Text = "Seznam vsebuje niz: " + vnos;
            }
            else
            {
                txtKonzola.Text = "Seznam ne vsebuje niza: " + vnos;
            }
        }

        private void btnPozicija_Click(object sender, EventArgs e)
        {
            string vnos = txtVnos.Text;
            int index = a.IndexOf(vnos);

            if (index != -1)
            {
                txtKonzola.Text = "Niz se nahaja na lokaciji: " + index.ToString();
            }
            else
            {
                txtKonzola.Text = "Niz ni najden v seznamu.";
            }
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            a.TrimToSize();
            txtKonzola.Text = "Zmanjšana kapicateta";
        }

        private void btnIzpisi_Click(object sender, EventArgs e)
        {
            txtKonzola.Clear();
            foreach (var item in a)
            {
                txtKonzola.AppendText(item.ToString() + Environment.NewLine); // Dodaj vsak element in novo vrstico
            }
        }
    }
}
