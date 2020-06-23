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
        
        public Preview2()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=192.168.1.4;Initial Catalog=testDatabase;Integrated Security=True";
            con.Open();
            //MessageBox.Show("Welcome !..");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES where TABLE_TYPE='BASE TABLE'";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            int i = 0;
            String st = " ";
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    ++i;
                    st = st + dr[2] + "\n";
                    //MessageBox.Show("Table Name : " + arr[i]);

                }
                show.Text = st;
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = @"Data Source=192.168.1.4;Initial Catalog=testDatabase;Integrated Security=True";
            sqlCon.Open();
            String st1 = tb3.Text;

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
            MessageBox.Show("" + dtMainSQLData.Rows.Count + "hai");
            ExcelApp.ActiveWorkbook.SaveCopyAs("C:/Users/sumit/test.xls");
            ExcelApp.ActiveWorkbook.Saved = true;
            ExcelApp.Quit();
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