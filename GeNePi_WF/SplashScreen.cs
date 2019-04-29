using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtoLeaf_WF
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            this.Visible = true;
            this.Opacity = 0;
            double i = 0;
            while (i < 1)
            {
                System.Threading.Thread.Sleep(100);
                this.Opacity = i;
                Console.WriteLine("Opacity value = " + i);
                i = i + 0.1;
            }
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }
    }
}
