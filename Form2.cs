using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Admin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnIPLogin_Click(object sender, EventArgs e)
        {
            if (passwordIP.Text == "" && loginIP.Text == "")
            {
                MessageBox.Show("Please Enter a non null Login id and Password credentials. \n Contact the Developer, if any application issue.", "Provided Empty Credentials !", MessageBoxButtons.OK);
            }
            else if (passwordIP.Text == "heroku_Salem_@ServerIP" && loginIP.Text == "Salem_Admin_Fixer")
            {
                passwordIP.Text = "";
                loginIP.Text = "";
                Form2 form2 = new Form2();
                form2.Hide();
                //-------------------Deleted IP Fixer Access Layer 2----------------------
                BackGroundProcess backGroundProcess = new BackGroundProcess();
                backGroundProcess.Show();
                MessageBox.Show("IMPORTANT NOTE.\n **. Make sure that you are running this application in the Database Server, if not, it can disrupt the SQL Server Database.  \n Contact the Developer, if any application issue.", "WARNING !", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please provide valid Login id and Password credentials. \n Contact the Developer, if any application issues.", "Incorrect Credentials !", MessageBoxButtons.OK);
                passwordIP.Text = "";
                loginIP.Text = "";
            }
        }
    }
}
