using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class ExcelReport : ReportGenerator
    {
        protected override void SaveReport()
        {
            Console.WriteLine("Сохранение Excel отчета...");
        }
    }
}
