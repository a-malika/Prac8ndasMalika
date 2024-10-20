using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Practice8
{
    public class PdfReport : ReportGenerator
    {
        protected override void SaveReport()
        {
            using (PdfWriter writer = new PdfWriter("Report.pdf"))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new Paragraph(header).SetFontSize(18).SetTextAlignment(TextAlignment.CENTER));
                    document.Add(new Paragraph(body).SetFontSize(14));
                    document.Add(new Paragraph(footer).SetFontSize(16));
                }
            }
            Console.WriteLine($"PDF отчет сохранен: \"Report.pdf\"");
        }
    }
}
