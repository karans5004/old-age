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
    public partial class expenditure : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=bb");
        public expenditure()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("amount debitted suceesfully");
        }

        private void expenditure_Load(object sender, EventArgs e)
        {

        }
    }
}
