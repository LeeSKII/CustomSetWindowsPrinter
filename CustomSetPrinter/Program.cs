using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomSetPrinterTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintDocument printDocument1 = new PrintDocument();
                string defaultPrinterName = printDocument1.PrinterSettings.PrinterName; //默认打印机名称
                if (string.IsNullOrEmpty(defaultPrinterName))
                {
                    MessageBox.Show("未正确获取到默认打印机名称，请设置默认打印机！");
                    return;
                }
                //string myPageSizeName = "MyCustomePageSize";
                //PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, myPageSizeName, 2000, 5000);
                #region 补全自定义纸张
                //建议不要对系统内置的标准图纸进行操作
                
                //PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "A0", (float)8410.0, (float)11890.0);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.25A0", (float)8410.0, (float)14862.5);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.5A0", (float)8410.0, (float)17835.0);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.75A0", (float)8410.0, (float)20807.5);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "2.0A0", (float)8410.0, (float)23780.0);

                //PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "A1", (float)5941.0, (float)8410.0);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.25A1", (float)5940.0, (float)10512.5);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.5A1", (float)5940.0, (float)12615.0);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.75A1", (float)5940.0, (float)14717.5);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "2.0A1", (float)5940.0, (float)16820.0);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "2.5A1", (float)5940.0, (float)21025);

                //PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "A2", (float)4200.8, (float)5940.0);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.25A2", (float)4200.8, (float)7425);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.5A2", (float)4200.8, (float)8910);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.75A2", (float)4200.8, (float)10395);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "2.0A2", (float)4200.8, (float)11880);

                //PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "A3", (float)2970, (float)4200);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.25A3", (float)2970, (float)5250);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.5A3", (float)2970, (float)6300);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.75A3", (float)2970, (float)7350);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "2.0A3", (float)2970, (float)8400);

                //PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "A4", (float)2100, (float)2970);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.25A4", (float)2100, (float)3712.5);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.5A4", (float)2100, (float)4455);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.75A4", (float)2100, (float)5197.5);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "2.0A4", (float)2100, (float)5940);


                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("打印错误："+ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
