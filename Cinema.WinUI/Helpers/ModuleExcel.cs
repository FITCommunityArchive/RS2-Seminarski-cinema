using Microsoft.Office.Interop.Excel;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Cinema.WinUI.Helpers
{
    class moduleExcel
    {
        public void ToCsV(DataGridView dgv, string title, string filename)
        {
            //========Data from textbox==========//      
            string stOutput = "";
            string stTitle = "";
            string sHeaders = "";
            stTitle = "\r\n" + title + "\r\n\n";
            stOutput += stTitle;
            for (int j = 0; j < dgv.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dgv.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dgv.Rows[i].Cells.Count; j++)
                {
                    stLine = stLine.ToString() + Convert.ToString(dgv.Rows[i].Cells[j].FormattedValue) + "\t";
                }
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private Worksheet FindSheet(Workbook workbook, string sheet_name)
        {
            foreach (Worksheet sheet in workbook.Sheets)
            {
                if (sheet.Name == sheet_name) return sheet;
            }
            return null;
        }
        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}