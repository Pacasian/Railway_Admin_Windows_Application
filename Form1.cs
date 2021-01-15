using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Railway_Admin
{
    public partial class Form1 : Form
    {
        public static String stIP=null;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
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
       
                //List<string> arr = new List<string>();
                if (tb1.Text == "" && tb2.Text == "")
                {
                    MessageBox.Show("Please fill the credentials");
              
            }
                else if(tb1.Text == "abc123" && tb2.Text == "abc123")
                {
                //----------------------
                // Extracting the json object from the site....
                //----------------------
                /**
                String url = "https://hits-rail.herokuapp.com/static/data.json";
                System.Net.WebClient client = new System.Net.WebClient();
                String json = client.DownloadString(url);
                String ipPas = null;
                for (int i = 8; i < json.Length - 2; i++)
                {
                    ipPas = ipPas + json[i];
                }
                **/
                //----------------------
                // Replacing the stIP value with the value from json file value....
                stIP = "103.74.139.201";
                //stIP = "192.168.1.4";
                //----------------------

                //----------------------
                // Server SQL connection
                //----------------------
                SqlConnection con = new SqlConnection(
                "Data Source=103.74.139.201,1433;Network Library=DBMSSOCN;Initial Catalog=dosthDatabase;User ID=dosthDB;Password=dosthDB");
       
                //con.ConnectionString = @"Data Source=" + stIP + " ;Initial Catalog=testDatabase;Integrated Security=True";
                //con.ConnectionString = @"Data Source=103.74.139.201,1433;Network Library=DBMSSOCN;Initial Catalog=dosthDatabase;User ID=dosthDB;password=dosthDB;";
                //con.ConnectionString = @"Data Source=" + stIP + ";Initial Catalog=testDatabase;Integrated Security=True;User ID=test;password=test;Connect Timeout=30;User Instance=True";
                //----------------------
                // Server SQL connection
                //----------------------   

                try
                {
                    con.Open();
                   
                    MessageBox.Show("Welcome.....!","welcome",MessageBoxButtons.OK);
                    Form1 f1 = new Form1();
                    f1.Hide();
                    //-----------Deleted the IP Fixer Access Layer 1-----------------
                    //Form2 form2 = new Form2();
                    //form2.Show();
                    Preview2 f2 = new Preview2();
                    f2.Show();
                }
                catch (SqlException )
                {
                    //MessageBox.Show(e.ToString);
                    MessageBox.Show("Error caused due to faulty connectivity. \n 1.Error in server IP Address \n 2.Unable to extract the json object. \n"+"The ip is "+stIP, "Error in Connectivity", MessageBoxButtons.OK);
                    //groupIP.Visible = true;
                    
                }

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
            else
            {
                MessageBox.Show("Please provide valid Login id and Password credentials. \n Contact the Developer, if any application issues.", "Incorrect Credentials !", MessageBoxButtons.OK);
                tb1.Text = "";
                tb2.Text = "";
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will close down the whole application. Confirm?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("The application has been closed successfully.", "Application Closed!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (tb6.Text != "") { 
            stIP = tb6.Text;
            }

        }
    }
}
/**
 * 
 * 
 * 
 * String url = "https://hits-rail.herokuapp.com/static/data.json";
            System.Net.WebClient client = new System.Net.WebClient();
            String json = client.DownloadString(url);
            System.IO.File.WriteAllText("fileName.json", json);
            String ipPas=null;
            MessageBox.Show("" + json.Length);
            for (int i = 8; i < json.Length-2; i++)
            {
                ipPas = ipPas + json[i];
            }
*/