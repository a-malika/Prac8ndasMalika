using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ReportGenerator pdfReport = new PdfReport();
            ReportGenerator excelReport = new ExcelReport();
            ReportGenerator htmlReport = new HtmlReport();

            Console.WriteLine("=== PDF Report ===");
            pdfReport.GenerateReport();

            Console.WriteLine("\n=== Excel Report ===");
            excelReport.GenerateReport();

            Console.WriteLine("\n=== HTML Report ===");
            htmlReport.GenerateReport();
        }
    }
}
