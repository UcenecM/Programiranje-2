namespace Sklad_Stack_Vaja
{
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    /// <summary>
    /// Defines the <see cref="Form1" />
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Defines the s
        /// </summary>
        internal Stack<String> s = new Stack<String>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The btnPush_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnPush_Click(object sender, EventArgs e)
        {
            s.Push(txtVnos.Text);
            lblStatus.Text = "Dodan element v seznam " + txtVnos.Text;
        }

        /// <summary>
        /// The btnPop_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnPop_Click(object sender, EventArgs e)
        {
            lblStatus.Text = s.Pop();
        }

        /// <summary>
        /// The btnPeek_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnPeek_Click(object sender, EventArgs e)
        {
            lblStatus.Text = s.Peek();
        }

        /// <summary>
        /// The btnPrazn_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnPrazn_Click(object sender, EventArgs e)
        {
            if (s.Count == 0)
            {
                lblStatus.Text = "Sklad je Prazen";
            }
            else
            {
                lblStatus.Text = "Sklad ni Prazen";
            }
        }

        /// <summary>
        /// The btnIsci_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnIsci_Click(object sender, EventArgs e)
        {
            if (s.Contains(lblStatus.Text))
            {
                lblStatus.Text = "Sklad vsebuje " + txtVnos.Text;
            }
        }

        /// <summary>
        /// The btnIzpis_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void btnIzpis_Click(object sender, EventArgs e)
        {

            if (s.Count == 0)
            {
                lblStatus.Text = "Sklad je prazen";
                return;
            }

            lblStatus.Text = "Elementi v skladu: ";

            foreach (string element in s)
            {
                lblStatus.Text += element + " , ";
            }
        }
    }
}
