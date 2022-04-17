using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using _Excel = Microsoft.Office.Interop.Excel;

namespace CRR5app
{
    internal class ExcelWorker : IDisposable
    {
        string path;
        Workbook wb;
        Worksheet ws;
        _Application excel = new _Excel.Application();
        public ExcelWorker(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }
        public string ReadCell(int Rows, int Colums)
        {
            if (ws.Cells[Rows, Colums].Value2 != null)
                return ws.Cells[Rows, Colums].Value2.ToString();
            else
                return "";
        }
        public double ReadCellDouble(int Rows, int Colums)
        {
            /*
             * Type value = ws.Cells[Rows, Colums].Value2.GetType();
                if (value == typeof(double))
                    return ws.Cells[Rows, Colums].Value2.ToDouble();
                else if (ws.Cells[Rows, Colums].Value2.ToString() == "8%" || ws.Cells[Rows, Colums].Value2.ToString() == "15%")
                {
                    return Convert.ToDouble(ws.Cells[Rows, Colums].Value2.ToString());
                }
                else
                    return 0d;
             * 
             * 
             * 
             * 
             if (ws.Cells[Rows, Colums].Value2 != null)
                return ws.Cells[Rows, Colums].Value2;
            else
                return 0d;
            */
            if (ws.Cells[Rows, Colums].Value2 != null)
            {
                if (ws.Cells[Rows, Colums].Value2.GetType() == typeof(double))
                    return ws.Cells[Rows, Colums].Value2;
                else
                    //MessageBox.Show(ws.Cells[Rows, Colums].Value2.ToString());
                    return 0d;
            } 
            else
                return 0d;
        }
        public void WriteToCell(int Rows, int Colums, string Valuestring = "", double Valuedouble = 0d)
        {
            if (Valuestring == "")
                ws.Cells[Rows, Colums].Value2 = Valuedouble;
            else if(Valuestring == "null")
                ws.Cells[Rows, Colums].Value2 = null;
            else
                ws.Cells[Rows, Colums].Value2 = Valuestring;
        }
        public void SaveAs(string path)
        {
            try
            {
                wb.SaveAs(path);

                MessageBox.Show("Файл скорректирован");
            }
            catch (COMException)
            {
                MessageBox.Show("Изменения не приняты");
            }
            //try {  }
            //catch (Exception) { MessageBox.Show("Вы не закрыли файл перед изменением, не забудьте проверить открытую программу EXELE.EXE в диспечере задачь"); }
        }
        public void Dispose()
        {
            Marshal.ReleaseComObject(wb);
            Marshal.ReleaseComObject(ws);
            excel.Quit();
        }
    }
}
