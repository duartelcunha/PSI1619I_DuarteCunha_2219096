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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

       

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(this.Tick);
            timer1.Enabled = true;
            this.Opacity = 0;
        }

        private bool aumenta = true;
        private void Tick(object sender, EventArgs e)
        {
            if (aumenta)
                this.Opacity += 0.07D;
          

            if (this.Opacity == 1)
                aumenta = false;

            if (this.Opacity == 0)
                this.Close();
        }

        
    }
}
