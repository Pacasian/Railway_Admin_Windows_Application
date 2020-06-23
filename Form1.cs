using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<string> arr = new List<string>();
            if (tb1.Text == "" && tb2.Text == "")
            {
                MessageBox.Show("Please fill the credentials");
            }
            else
            {
                MessageBox.Show("Welcome.....!");
                Form1 f1 = new Form1();
                f1.Hide();
                Preview2 f2 = new Preview2();
                f2.Show();
                /**

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=192.168.1.4;Initial Catalog=testDatabase;Integrated Security=True";
                con.Open();
                MessageBox.Show("Welcome !..");
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_TYPE='BASE TABLE'";
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();
                int i = 0;
                String st=" ";
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        st = st + dr[2] + "\n";
                        //MessageBox.Show("Table Name : " + arr[i]);

                    }
                 
                    MessageBox.Show("Table Name : " + st);
                    Form1 f1 = new Form1();
                    f1.Close();
                    Preview2 f2 = new Preview2();
                    f2.Show();
                }
                */

            }
        }
    }
}
