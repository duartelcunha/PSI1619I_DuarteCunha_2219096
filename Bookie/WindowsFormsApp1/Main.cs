using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
    }

}
