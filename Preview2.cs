using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;

using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using ExcelLibrary.CompoundDocumentFormat;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.BinaryFileFormat;

namespace Railway_Admin
{
    public partial class Preview2 : Form
    {
        public static String filelocation = System.IO.Path.Combine(
   Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
   "Railway_Record"
);
        // Checking whether the folder exists !......

        public Preview2()
        {

            //MessageBox.Show(Form1.stIP);
            InitializeComponent();
            try { 
            bool exists = System.IO.Directory.Exists(filelocation);
            if (!exists)
                System.IO.Directory.CreateDirectory(filelocation);
            }
            catch (Exception)
            {
                MessageBox.Show(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
            }

            try
            {
             
            SqlConnection con = new SqlConnection(
                "Data Source=103.74.139.201,1433;Network Library=DBMSSOCN;Initial Catalog=dosthDatabase;User ID=dosthDB;Password=dosthDB");
                con.Open();
            //MessageBox.Show("Welcome !..");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_TYPE='BASE TABLE'";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            StringBuilder sb = new StringBuilder(show.Text);
            String st = " ";
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    ++i;
                        sb.AppendLine("\t"+dr[2]);
                        sb.AppendLine(" ");
                        //st = st + " \n" + dr[2] + "\n";
                        

                    }
                    show.Text = sb + " ";
                    //MessageBox.Show("Table Name : " + st);
                }
            else
            {
                MessageBox.Show("Unable to retrieve data from Database...!");
            }
            }catch (Exception)
            {
                MessageBox.Show("Unable to retrieve data from Database...!");

            }
        }


        private void btnDownload_Click(object sender, EventArgs e)
        {

            try { 
            SqlConnection sqlCon =  new SqlConnection(
                "Data Source=103.74.139.201,1433;Network Library=DBMSSOCN;Initial Catalog=dosthDatabase;User ID=dosthDB;Password=dosthDB");
                sqlCon.Open();
            String st1 = tb3.Text;
            String filename = "test";
            if (tb4.Text != "") {
                filename = tb4.Text;
                    }

            
             
             String Samp_filelocation = filelocation +@"\"+filename + ".xls";
             SqlDataAdapter da = new SqlDataAdapter("SELECT * from "+st1, sqlCon);
            System.Data.DataTable dtMainSQLData = new System.Data.DataTable();
            da.Fill(dtMainSQLData);
            DataColumnCollection dcCollection = dtMainSQLData.Columns;
            // Export Data into EXCEL Sheet
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            // ExcelApp.Cells.CopyFromRecordset(objRS);
            for (int i = 1; i < dtMainSQLData.Rows.Count + 2; i++)
            {
                for (int j = 1; j < dtMainSQLData.Columns.Count + 1; j++)
                {
                    if (i == 1)
                    {
                        ExcelApp.Cells[i, j] = dcCollection[j - 1].ToString();
                    }
                    else
                        ExcelApp.Cells[i, j] = dtMainSQLData.Rows[i - 2][j - 1].ToString();
                }
            }
            MessageBox.Show("Download Completed..");
            tb5.Text = "File Location : "+ Samp_filelocation;
            ExcelApp.ActiveWorkbook.SaveCopyAs(Samp_filelocation);
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.Quit();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString);
                //MessageBox.Show("Error in exporting the file. \n 1.Error can be in server IP Address \n 2.Incorrect table name. \n 3.Incorrect export file name.", "Error in Exporting Excel file..", MessageBoxButtons.OK);
                tb3.Text = "";
                tb4.Text = "";
                groupLocation.Visible = true;
                groupExcel.Enabled = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDoneLocation_Click(object sender, EventArgs e)
        {
            if (tbLocation.Text != "")
            {
                String samploc = tbLocation.Text + "/SampleRailway_Record/";
                MessageBox.Show(samploc);
                groupLocation.Visible = false;
                groupExcel.Enabled = true;
            }
        }

        
    }







}
/**
 * 
 * 
        // create new xls file 
        string file = "newdoc.xls"; 
            Workbook workbook = new Workbook(); 
            Worksheet worksheet = new Worksheet("First Sheet"); 
            worksheet.Cells[0, 1] = new Cell((short)1);
            worksheet.Cells[2, 0] = new Cell(9999999); 
            worksheet.Cells[3, 3] = new Cell((decimal)3.45); 
            worksheet.Cells[2, 2] = new Cell("Text string");
            worksheet.Cells[2, 4] = new Cell("Second string");
            worksheet.Cells[4, 0] = new Cell(32764.5, "#,##0.00");
            worksheet.Cells[5, 1] = new Cell(DateTime.Now, @"YYYY-MM-DD"); 
            worksheet.Cells.ColumnWidth[0, 1] = 3000; 
            workbook.Worksheets.Add(worksheet); 
            workbook.Save(file);

           // open xls file 
            Workbook book = Workbook.Load(file);
            Worksheet sheet = book.Worksheets[0];

//traverse cells 
        
 * 
 * 
 * 
 * foreach (Pair<Pair<int, Cell>cell in sheets.cell s) 
            {
                dgvCells[cell.Left.Right, cell.Left.Left].Value = cell.Right.Value; 
            }

// traverse rows by Index 
            for (int rowIndex = sheet.Cells.FirstRowIndex; rowIndex <= sheet.Cells.LastRowIndex; rowIndex++)
            { 
                Row row = sheet.Cells.GetRow(rowIndex);
                for (int colIndex = row.FirstColIndex; colIndex <= row.LastColIndex; colIndex++) 
                { Cell cell = row.GetCell(colIndex); 
                }
            } 
*/