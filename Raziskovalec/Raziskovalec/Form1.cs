using System.Xml.Serialization;

namespace Raziskovalec
{
    enum Tip { Datoteka,Mapa}
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            trvDrevo.Nodes.Add(@"C:\");
            NaložiDrevo1("C:\\", trvDrevo.Nodes[0]);
        }
        private void NaložiDrevo1(string ime, TreeNode roditelj)
        {
            try
            {
                string[] tabelaMap = Directory.GetDirectories(ime);
                if (tabelaMap.Length != 0)//robni pogoj
                {
                    foreach (string mapa in tabelaMap)
                    {
                        TreeNode mojV = new TreeNode(mapa);
                        roditelj.Nodes.Add(mojV);
                        NaložiDrevo1(mapa, mojV);
                    }
                }
            }
            catch(Exception x)
            {
                
            }
           
        }
        private void NaložiDrevo()
        {
            trvDrevo.Nodes.Clear();
            foreach (string ime in Directory.GetLogicalDrives())
            {
                TreeNode vozel = trvDrevo.Nodes.Add(ime);
                vozel.Nodes.Add("Kar neki");

            }
        }

        private void trvDrevo_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                e.Node.Nodes.Clear(); //e.Node je tipa TreeNode
                DodajMape(e.Node);
                DodajDatoteke(e.Node);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Napaka");
            }
        }

        private void DodajMape(TreeNode node)
        {
            string pot = node.FullPath;
            foreach (string imeM in Directory.GetDirectories(pot))
            {
                TreeNode novi = node.Nodes.Add(Path.GetFileName(imeM));
                novi.Tag = Tip.Mapa;
                novi.Nodes.Add("Fake");
            }
        }

        private void DodajDatoteke(TreeNode node)
        {
            string pot = node.FullPath;
            foreach (string imeD in Directory.GetFiles(pot))
            {
                TreeNode novi = node.Nodes.Add(Path.GetFileName(imeD));
                novi.Tag = Tip.Datoteka;
            }
        }

        private void trvDrevo_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtA.Text = "";
            txtUstvarjena.Text = "";
            if (e.Node.Tag is Tip)
            {
                switch ((Tip)e.Node.Tag)
                {
                    case Tip.Datoteka:
                        //blabla
                        FileInfo f = new FileInfo(e.Node.FullPath);
                        txtA.Text = "Datoteka";
                        txtUstvarjena.Text = f.CreationTime.ToShortDateString();
                        break;
                    case Tip.Mapa:
                        //bla bla
                        DirectoryInfo d = new DirectoryInfo(e.Node.FullPath);
                        txtA.Text = "Mapa";
                        txtUstvarjena.Text = d.CreationTime.ToShortDateString();
                        break;
                }
            }
        }
    }
}
