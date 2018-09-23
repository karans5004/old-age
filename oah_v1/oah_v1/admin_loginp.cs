using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oah_v1
{
    public partial class admin_loginp : Form
    {
        public admin_loginp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifya md = new modifya();
            md.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adda ad = new adda();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deletea dd = new deletea();
            dd.Show();
        }

        private void admin_loginp_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            expenditure ex = new expenditure();
            ex.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            donation dn = new donation();
            dn.Show();
        }
    }
}
