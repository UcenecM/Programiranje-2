using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace RaziskovalecWFP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Imena koren = new Imena() { ime = "A" };
            NapolniVeje(@"c:\\PRO2", koren);
            IzpišiDadoteke(@"c:\\PRO2", koren);
            trvDrevo.Items.Add(koren);
        }
        private void NapolniVeje(string ime, Imena x)
        {
            try
            {
                string[] mape = Directory.GetDirectories(ime);
                if (mape.Length != 0)
                {
                    foreach(string imeMape in mape)
                    {
                        DirectoryInfo d = new DirectoryInfo(imeMape);
                        string brezPoti = d.Name;
                        Imena mojv = new Imena() { ime = brezPoti };
                        IzpišiDadoteke(imeMape, mojv);
                        NapolniVeje(imeMape, mojv);
                        x.Elementi.Add(mojv);
                    }
                }
            }
            catch
            {

            }
        }
        private void IzpišiDadoteke(string imeMape, Imena mojv)
        {
            DirectoryInfo d = new DirectoryInfo(imeMape);
            foreach ()
            {
                
            }

        }
    }
}