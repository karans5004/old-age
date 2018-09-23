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
    public partial class modifya : Form
    {
        MySqlConnection cs = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=oldv1");
        string gen3,gen4;
        public modifya()
        {
            InitializeComponent();
        }

        private void modifya_Load(object sender, EventArgs e)
        {
            cs.Open();
            try{

            MySqlCommand cmd = new MySqlCommand("select rid from resident",cs);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    resicombo.Items.Add(dr[0].ToString());

                }
                dr.Close();
                cs.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            cs.Open();
            try
            {

                MySqlCommand cmd = new MySqlCommand("select vid from volunteer", cs);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    volcombo.Items.Add(dr[0].ToString());

                }
                dr.Close();
                cs.Close();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cs.Open();
            MySqlCommand cmd = new MySqlCommand("select rid,fname,mname,lname,dob,mobno,altmob,gender,joindate,address,paddress from resident where rid=" + this.resicombo.Text, cs);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            this.rid2.Text= dr[0].ToString();
            this.fname2.Text = dr[1].ToString();
            this.mname2.Text = dr[2].ToString();
            this.lname2.Text = dr[3].ToString();
            this.dob2.Text = dr[4].ToString();
            this.mob2.Text = dr[5].ToString();
            this.altmob2.Text = dr[6].ToString();
            this.gen2.Text = dr[7].ToString();
            this.joindate2.Text = dr[8].ToString();
            this.address2.Text = dr[9].ToString();
            this.paddress2.Text = dr[10].ToString();
            dr.Close();
            cs.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cs.Open();
            string str = "update resident set fname='"+this.fname2.Text+"',mname='"+this.mname2.Text+"',lname='"+this.lname2.Text+"',dob='"+this.dob2.Text+"',mobno='"+this.mob2.Text+"',altmob='"+this.altmob2.Text+"',gender='"+gen3+"',joindate='"+this.joindate2.Text+"',address='"+this.address2.Text+"',paddress='"+this.paddress2.Text+"' where rid="+this.resicombo.Text+";";
            MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, cs);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");


            cs.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gen3="male";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gen3="female";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cs.Open();
            string str = "update volunteer set fname='" + this.fname3.Text + "',mname='" + this.mname3.Text + "',lname='" + this.lname3.Text + "',dob='" + this.dob3.Text + "',mobno='" + this.mob3.Text + "',altmob='" + this.altmob3.Text + "',gender='" + gen4 + "',address='" + this.address3.Text + "',worktype='" + this.worktype3.Text + "',salary="+this.sal2.Text+" where vid=" + this.volcombo.Text + ";";
            MessageBox.Show(str);

            MySqlCommand cmd = new MySqlCommand(str, cs);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated");


            cs.Close();
        }

        private void volcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cs.Open();
            MySqlCommand cmd = new MySqlCommand("select vid,fname,mname,lname,dob,mobno,altmob,gender,address,worktype,salary from volunteer where vid=" + this.volcombo.Text, cs);
            MySqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            this.vid2.Text = dr[0].ToString();
            this.fname3.Text = dr[1].ToString();
            this.mname3.Text = dr[2].ToString();
            this.lname3.Text = dr[3].ToString();
            this.dob3.Text = dr[4].ToString();
            this.mob3.Text = dr[5].ToString();
            this.altmob3.Text = dr[6].ToString();
            this.gender4.Text = dr[7].ToString();
            this.address3.Text = dr[8].ToString();
            this.worktype3.Text = dr[9].ToString();
            this.sal2.Text = dr[10].ToString();
            dr.Close();
            cs.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gen4 = "male";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gen4 = "female";
        }
    }
}
