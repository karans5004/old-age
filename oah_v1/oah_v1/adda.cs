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
    public partial class adda : Form
    {
        MySqlConnection cs = new MySqlConnection("server=localhost;user id=root;password=karan@5004;database=oldv1");

        string gen,gen1;
        public adda()
        {
            InitializeComponent();
        }

        private void adda_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gen = "male";

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            gen = "female";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                cs.Open();
                string str = "insert into resident(fname,mname,lname,dob,mobno,altmob,gender,joindate,address,paddress,roomno)" + "values('" + this.fname.Text + "','" + this.mname.Text + "','" + this.lname.Text + "','" + this.dob.Text + "','" + this.mobileno.Text + "','" + this.altmobno.Text + "','" + gen + "','" + this.joindate.Text + "','" + this.address.Text + "','" + this.paddress.Text + "'," + this.roomno.Text + ")";
                MySqlCommand cmd = new MySqlCommand(str, cs);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data inserted");
                cs.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cs.Open();
            string str = "insert into volunteer(fname,mname,lname,dob,mobno,altmob,gender,address,worktype,salary)" + "values('" + this.fname1.Text + "','" + this.mname1.Text + "','" + this.lname1.Text + "','" + this.dob1.Text + "','" + this.mob1.Text + "','" + this.altmob1.Text + "','" + gen1 + "','" + this.address1.Text + "','" + this.worktype.Text + "'," + this.salary.Text + ")";
            MySqlCommand cmd = new MySqlCommand(str, cs);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data inserted");
            cs.Close();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gen1 = "male";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gen1 = "female";
        }
    }
}
