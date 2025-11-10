namespace VajaIzjeme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeli_Click(object sender, EventArgs e)
        {
            try
            {
                double deljenec = double.Parse(txtDeljen.Text);
                double delitelj = double.Parse(txtDelitelj.Text);

                if (delitelj == 0)
                {
                    throw new DivideByZeroException();
                }

                double rezultat = deljenec / delitelj;

                lblOutput.Text = "Rezultat: " + rezultat.ToString();
            }
            catch (FormatException x)
            {
                MessageBox.Show("Vnesite veljavni številski vrednosti!", "FormatException",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Deljenje z niè ni dovoljeno!", "DivideByZeroException",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
