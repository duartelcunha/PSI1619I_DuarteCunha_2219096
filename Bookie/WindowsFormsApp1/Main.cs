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
            Thread.Sleep(5000);
            InitializeComponent();
            a.Abort();
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

        public void StartForm()
        {
            Application.Run(new Splash());
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
    }

}
