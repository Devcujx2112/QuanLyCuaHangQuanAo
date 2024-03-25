using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSHOPQUANAO
{
    public partial class Online : Form
    {
        //private string url;
        public Online()//:base()
        {
           InitializeComponent();
           // this.url = url;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = Program.X;
            webBrowser1.Navigate(Program.X);
            webBrowser1.Update();
        }
    }
}
