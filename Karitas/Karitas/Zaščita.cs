using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Karitas
{
    public partial class Zaščita : Form
    {
        String pot = Resource1.pot;
        List<Darovi> vsi = new List<Darovi>();

        public Zaščita()
        {
            InitializeComponent();
        }

        private void btnZascita_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(pot, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Darovi d;
                try
                {
                    while (true)
                    {
                        d = (Darovi)bf.Deserialize(fs);
                        vsi.Add(d);
                    }
                }
                catch (SerializationException)
                {

                }
                finally
                {
                    fs.Close();
                }
            }
            catch
            {

            }
            string imeD = "C:\\Karitas\\Karitas" + DateTime.Now.ToShortDateString() + ".xml";
            FileStream fs1 = new FileStream(imeD, FileMode.Create);
            XmlSerializer ser = new XmlSerializer(typeof(List<Darovi>));
            ser.Serialize(fs1, vsi);
            fs1.Close();
            MessageBox.Show("Končano");

        }
    }
}
