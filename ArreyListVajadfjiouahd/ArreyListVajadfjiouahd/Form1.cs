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

        }

        private void btnStatistika_Click(object sender, EventArgs e)
        {
            txtKonzola = "";
        }
    }
}
