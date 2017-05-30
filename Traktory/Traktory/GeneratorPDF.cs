using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Traktory
{
    class GeneratorPDF
    {
        public GeneratorPDF(List<string>[] ListaMarek, List<string>[] ListaModeli)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("PDF.pdf", FileMode.Create));
            doc.Open();
            Paragraph paragraf = new Paragraph("Traktory\n\n\n");
            paragraf.Alignment = 1;
            doc.Add(paragraf);
            PdfPTable table = new PdfPTable(4);
            PdfPCell cell = new PdfPCell(new Phrase("fdsfsdfsd"));
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1;
            table.AddCell("Model");
            table.AddCell("Marka");
            table.AddCell("Moc");
            table.AddCell("Masa");

            for (int j = 0; j < ListaModeli[0].Count; j++)
                for (int i = 0; i < ListaModeli.Count(); i++)
                {
                    if ((i + 3) % 4 == 0)
                        table.AddCell(ListaMarek[1][ListaMarek[0].IndexOf(ListaModeli[i][j])]);
                    else
                        table.AddCell(ListaModeli[i][j]);


                    
                    
                }
            doc.Add(table);
            doc.Close();
        }
    }
}
