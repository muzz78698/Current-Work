using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{

    public partial class Main : Form
    {
    SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\muzam\Documents\GameofScratch.mdf;Integrated Security=True;Connect Timeout=30");
    
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into table1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();

            MessageBox.Show("Record Inserted successfully"); 
        }
         public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from table1 where name = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();

            MessageBox.Show("Record Deleted successfully"); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update table1 set name='" +textBox2.Text+ "'where name = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();

            MessageBox.Show("Record Updated successfully"); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
