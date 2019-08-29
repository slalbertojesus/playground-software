using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
					

namespace practicapdf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FileStream fs = new FileStream
                ("Chapter1_Example1.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            PdfPTable table = new PdfPTable(5);
            PdfPCell cell = new PdfPCell(new Phrase("SOLICITUD DE APERTURA DE CREDITO"));
            cell.Colspan = 5;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(cell);

            table.AddCell("No. de vendedor:");
            table.AddCell("No. de supervisor: ");
            table.AddCell("Folio: ");
            table.AddCell("Promoción: ");
            table.AddCell("Fecha {dd/mm/aa}: ");

            cell = new PdfPCell(new Phrase("Solicitud"));
            cell.Colspan = 1;

            doc.Add(table);
            doc.Close();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
      