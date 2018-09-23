using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace oah_v1
{
    public partial class deletea : Form
    {
        MySqlConnection cs = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=oldv1");
        public deletea()
        {
            InitializeComponent();
        }

        private void deletea_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cs.Open();
            string str = "delete from resident where rid="+this.del.Text+";";
            MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, cs);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            cs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs.Open();
            string str = "delete from volunteer where vid=" + this.del2.Text + ";";
            MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, cs);
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted");
            cs.Close();
        }
    }
}
