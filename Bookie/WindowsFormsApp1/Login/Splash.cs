using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            PB.Value = 0;
        }

       

        private void timer_Tick(object sender, EventArgs e)
        {
            PB.Value = 99;

            if (PB.Value == 100)
            {
                timer1.Enabled = false;
                Main f3 = new Main();
                f3.Show();
                this.Hide();
            }
        }

   
    }
}
