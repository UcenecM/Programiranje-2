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
using System.Xml.Serialization;

namespace Karitas
{
    public partial class OdZaščita : Form
    {
        List<Darovi> vsi = new List<Darovi>();

        public OdZaščita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string xmlPot = @"C:\\Karitas\\Karitas" + DateTime.Now.ToShortDateString() + ".xml";   
            string datPot = Resource1.pot;   

            try
            {
                using (FileStream fs = new FileStream(xmlPot, FileMode.Open))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Darovi>));
                    vsi = (List<Darovi>)ser.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri branju XML: " + ex.Message);
                return;
            }

            try
            {
                if (File.Exists(datPot))
                {
                    File.Delete(datPot);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri brisanju stare DAT: " + ex.Message);
                return;
            }
            try
            {
                using (FileStream fs = new FileStream(datPot, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();

                    foreach (var d in vsi)
                    {
                        bf.Serialize(fs, d);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka pri zapisovanju DAT: " + ex.Message);
                return;
            }

            MessageBox.Show("Pretvorba iz XML v DAT je končana.");


        }
    }
}
