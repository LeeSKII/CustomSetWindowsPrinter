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
            PrintDocument printDocument1 = new PrintDocument();
            string defaultPrinterName = printDocument1.PrinterSettings.PrinterName; //默认打印机名称
            if (string.IsNullOrEmpty(defaultPrinterName))
            {
                MessageBox.Show("未正确获取到默认打印机名称，请设置默认打印机！");
                return;
            }
            string myPageSizeName = "MyCustomePageSize";
            PrinterPageSize.MyPageSize.SetPrintForm(defaultPrinterName, myPageSizeName, 2000, 5000);
            Console.ReadKey();
        }
    }
}
