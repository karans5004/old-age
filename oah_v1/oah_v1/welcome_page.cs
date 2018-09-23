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
    public partial class welcome_page : Form
    {

        string passwd;
        MySqlConnection cs = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=oldv1");
        public welcome_page()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_page sp = new login_page();
            sp.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (passw.Text == "abc")
            {
                admin aa = new admin();
                aa.Show();
                MessageBox.Show("login");
            }
            else if (passw.Text == "bbc")
            {
                login_page lp = new login_page();
                lp.Show();
                MessageBox.Show("login");

            }
            else { MessageBox.Show("login not possible"); }
            
        }

        private void welcome_page_Load(object sender, EventArgs e)
        {
            cs.Open();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select loginid from login", cs);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add(dr[0].ToString());

                }
                dr.Close();
                cs.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
           
            
            
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cs.Open();
            string str = "select loginid,username,password from login where loginid="+this.comboBox1.Text+";";
            MySqlCommand cmd = new MySqlCommand(str, cs);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            this.log.Text = dr[0].ToString();
            this.user.Text = dr[1].ToString();
            passwd = dr[2].ToString();
            dr.Close();

  
               
           // else { MessageBox.Show("no"); }
            //dr.Close();
            cs.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
