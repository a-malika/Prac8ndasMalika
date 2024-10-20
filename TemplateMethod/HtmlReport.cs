using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class HtmlReport : ReportGenerator
    {
        protected override void SaveReport()
        {
            Console.WriteLine("Сохранение HTML отчета...");
        }
        protected virtual void SendReportByEmail()
        {
            Console.WriteLine("Отправка ссылки на html отчет по электронной почте...");
        }
    }
}
