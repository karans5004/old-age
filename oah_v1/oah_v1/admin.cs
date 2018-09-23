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
    public partial class admin : Form
    {
        MySqlConnection cs = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
        public admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            cs.Open();
            MessageBox.Show("database connected");
            cs.Close();
            MessageBox.Show("login successfully");
            admin_loginp aa = new admin_loginp();
            aa.Show();
            
        }

        private void admin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
