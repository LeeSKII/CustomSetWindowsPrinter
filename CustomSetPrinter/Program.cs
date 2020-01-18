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
                string myPageSizeName = "MyCustomePageSize";
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, myPageSizeName, 2000, 5000);

                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.5A1", (float)5940.8, (float)12615);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.25A0", (float)8410, (float)14870);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "1.25A1", (float)5940.8, (float)10512.5);
                PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, "2.0A1", (float)5940.8, (float)16825);
            }
            catch (Exception ex)
            {
                MessageBox.Show("打印错误："+ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
