using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TempAndHumiTest
{
    class Export
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

        public Export() { }

        /// <summary>
        /// 导出数据到Excel,导出速度最快  
        /// </summary>
        /// <param name="list">列名，数据</param>  
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static bool ExportExcel(List<DictionaryEntry> list, string filepath)
        {
            bool bSuccess = true;
            Microsoft.Office.Interop.Excel.Application appexcel = new Microsoft.Office.Interop.Excel.Application();
            System.Reflection.Missing miss = System.Reflection.Missing.Value;
            appexcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbookdata = null;
            Microsoft.Office.Interop.Excel.Worksheet worksheetdata = null;
            Microsoft.Office.Interop.Excel.Range rangedata;

            workbookdata = appexcel.Workbooks.Add();

            //设置对象不可见  
            appexcel.Visible = false;
            appexcel.DisplayAlerts = false;
            try
            {
                foreach (var lv in list)
                {
                    var keys = lv.Key as List<string>;
                    var values = lv.Value as List<IList<object>>;
                    worksheetdata = (Microsoft.Office.Interop.Excel.Worksheet)workbookdata.Worksheets.Add(miss, workbookdata.ActiveSheet);

                    for (int i = 0; i < keys.Count - 1; i++)
                    {
                        //给工作表赋名称  
                        worksheetdata.Name = keys[0];//列名的第一个数据位表名  
                        worksheetdata.Cells[1, i + 1] = keys[i + 1];
                    }

                    //因为第一行已经写了表头，所以所有数据都应该从a2开始  
                    rangedata = worksheetdata.get_Range("a2", miss);
                    Microsoft.Office.Interop.Excel.Range xlrang = null;

                    //irowcount为实际行数，最大行  
                    int irowcount = values.Count;
                    int iparstedrow = 0, icurrsize = 0;

                    //ieachsize为每次写行的数值，可以自己设置  
                    int ieachsize = 10000;

                    //icolumnaccount为实际列数，最大列数  
                    int icolumnaccount = keys.Count - 1;

                    //在内存中声明一个ieachsize×icolumnaccount的数组，ieachsize是每次最大存储的行数，icolumnaccount就是存储的实际列数  
                    object[,] objval = new object[ieachsize, icolumnaccount];
                    icurrsize = ieachsize;

                    while (iparstedrow < irowcount)
                    {
                        if ((irowcount - iparstedrow) < ieachsize)
                            icurrsize = irowcount - iparstedrow;

                        //用for循环给数组赋值  
                        for (int i = 0; i < icurrsize; i++)
                        {
                            for (int j = 0; j < icolumnaccount; j++)
                            {
                                var v = values[i + iparstedrow][j];
                                objval[i, j] = v != null ? v.ToString() : "";
                            }
                        }
                        string X = "A" + ((int)(iparstedrow + 2)).ToString();
                        string col = "";
                        if (icolumnaccount <= 26)
                        {
                            col = ((char)('A' + icolumnaccount - 1)).ToString() + ((int)(iparstedrow + icurrsize + 1)).ToString();
                        }
                        else
                        {
                            col = ((char)('A' + (icolumnaccount / 26 - 1))).ToString() + ((char)('A' + (icolumnaccount % 26 - 1))).ToString() + ((int)(iparstedrow + icurrsize + 1)).ToString();
                        }
                        xlrang = worksheetdata.get_Range(X, col);
                        xlrang.NumberFormat = "@";
                        // 调用range的value2属性，把内存中的值赋给excel  
                        xlrang.Value2 = objval;
                        iparstedrow = iparstedrow + icurrsize;
                    }
                }
                ((Microsoft.Office.Interop.Excel.Worksheet)workbookdata.Worksheets["Sheet1"]).Delete();
                ((Microsoft.Office.Interop.Excel.Worksheet)workbookdata.Worksheets["Sheet2"]).Delete();
                ((Microsoft.Office.Interop.Excel.Worksheet)workbookdata.Worksheets["Sheet3"]).Delete();
                //保存工作表  
                workbookdata.SaveAs(filepath, miss, miss, miss, miss, miss, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, miss, miss, miss);
                workbookdata.Close(false, miss, miss);
                appexcel.Workbooks.Close();
                appexcel.Quit();

                Marshal.ReleaseComObject(workbookdata);
                Marshal.ReleaseComObject(appexcel.Workbooks);
                Marshal.ReleaseComObject(appexcel);
                GC.Collect();
            }
            catch (Exception ex)
            {
                //ErrorMsg = ex.Message;
                bSuccess = false;
            }
            finally
            {
                if (appexcel != null)
                {
                    //ExcelImportHelper.KillSpecialExcel(appexcel);
                    try
                    {
                        int lpdwProcessId;
                        GetWindowThreadProcessId(new IntPtr(appexcel.Hwnd), out lpdwProcessId);
                        System.Diagnostics.Process.GetProcessById(lpdwProcessId).Kill();
                    }
                    catch (Exception) { }
                }
            }
            return bSuccess;
        }

        /// <summary>
        /// 导出数据到Excel
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>0为dt参数错误，1为未安装Excel</returns>
        public static int ExportExcel(System.Data.DataTable dt)
        {
            if (dt == null || dt.Rows.Count == 0) return 0;
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                //对此实例进行验证，如果为null则表示运行此代码的机器可能未安装Excel
                return 1;
            }
            System.Globalization.CultureInfo CurrentCI = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
            Microsoft.Office.Interop.Excel.Range range;
            long totalCount = dt.Rows.Count;
            long rowRead = 0;
            float percent = 0;
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dt.Columns[i].ColumnName;
                range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, i + 1];
                range.Interior.ColorIndex = 15;
                range.Font.Bold = true;
            }
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = dt.Rows[r][i].ToString();
                }
                rowRead++;
                percent = ((float)(100 * rowRead)) / totalCount;
            }
            xlApp.Visible = true;
            return 3;
        }
    }
}
