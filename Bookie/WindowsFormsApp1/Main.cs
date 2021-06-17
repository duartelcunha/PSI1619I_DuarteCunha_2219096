using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {

        public Main() 
        {
            Thread a = new Thread(new ThreadStart(StartForm));
            a.Start();
            Thread.Sleep(1200);
            a.Abort();

            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Tempo.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
            MdiClient ctlMDI;

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackgroundImage = Properties.Resources.background;
                }
                catch (InvalidCastException)
                {}
            }
        }

        public static void StartForm()
        {
            try
            {
                Application.Run(new Splash());
            }
            catch (ThreadAbortException)
            {
                Thread.ResetAbort();
            }
        }

        private void verUtenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerUtente.a = 3;
            var verutente = new VerUtente();
            verutente.Show();
        }

        private void inserirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reg = new Registo();
            reg.Show();
        }

        private void inserirLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var insert = new InserirLivro();
            insert.Show();
        }

        private void verLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var verlivro = new VerLivro();
            verlivro.Show();
        }

        private void requisitarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerUtente.a = 1;

            var req = new Req();
            req.Show();
        }

        private void devolverLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerUtente.a = 2;
            Info.b = 1;
            var dev = new Dev();
            dev.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerUtente.a = 0;
            Info.b = 0;

            var info = new Info();
            info.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return Color.LightSkyBlue; }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return Color.LightSkyBlue; }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return Color.White; }
            }
            public override Color MenuItemBorder
            {
                get { return Color.White; }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Tempo.Text = DateTime.Now.ToLongTimeString();
            timer2.Start();
        }
    }

}
