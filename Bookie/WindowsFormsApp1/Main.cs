using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            Thread.Sleep(1900);
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
            a.Abort();
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
        public static void StartForm()
        {
                Application.Run(new Splash());
        }

        private void Main_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            foreach (Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;
                    ctlMDI.BackgroundImage = Properties.Resources.background;
                }
                catch (InvalidCastException)
                {

                }
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void verUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var veruser = new VerUtilizador();
            veruser.Show();
        }

       

        private void inserirUtilizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Registo();
            a.Show();
        }

        private void inserirLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new InserirLivro();
            a.Show();
        }

        private void verLivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new VerLivro();
            a.Show();
        }

        private void requisitarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Req();
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .2;
        }

        private void retornarLivroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Dev();
            a.Show();
        }

        private void detalhesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var a = new Info();
            a.Show();
        }
    }

}
