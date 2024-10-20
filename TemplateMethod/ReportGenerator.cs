using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;

namespace Practice8
{
    public abstract class ReportGenerator
    {
        protected string header, body, footer;
        public void GenerateReport()
        {
            GenerateHeader();
            GenerateBody();
            GenerateFooter();
            if (CustomerWantsSave())
            {
                SaveReport();
            }
            else
            {
                SendReportByEmail();
            }
        }
        private void GenerateHeader()
        {
            Console.WriteLine("Введите заголовок для отчета:");
            header = Console.ReadLine();
        }
        private void GenerateBody()
        {
            Console.WriteLine("Введите тело отчета:");
            body = Console.ReadLine();
        }
        private void GenerateFooter()
        {
            Console.WriteLine("Введите подвал для отчета:");
            footer = Console.ReadLine();
        }
        private bool CustomerWantsSave()
        {
            while (true)
            {
                Console.WriteLine("Сохранить отчет? (y/n): ");
                string input = Console.ReadLine().ToLower();
                if (input == "y") return true;
                if (input == "n") return false;
                Console.WriteLine("Неверный ввод. Введите 'y' для сохранения или 'n' для отправки по эмейлу.");
            }
        }
        protected abstract void SaveReport();
        protected virtual void SendReportByEmail()
        {
            Console.WriteLine("Отправка отчета по электронной почте...");
        }
    }
}
