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
            Font font = new Font();
            font.SetColor(255, 255, 255);
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
            table.AddCell("Fecha:");

            PdfPCell SOLICITUD = new PdfPCell(new Phrase("SOLICITUD", font));
            SOLICITUD.BackgroundColor = BaseColor.BLACK;
            SOLICITUD.Colspan = 5;
            SOLICITUD.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(SOLICITUD);

            PdfPCell monto = new PdfPCell(new Phrase("Monto solicitado: "));
            monto.Colspan = 5;
            table.AddCell("Monto solicitado:");
            table.AddCell(monto);

            PdfPCell destinoCredito = new PdfPCell(new Phrase("Destino de credito: "));
            destinoCredito.Colspan = 5;
            table.AddCell(destinoCredito);

            PdfPCell formaDisposicion = new PdfPCell(new Phrase("Forma de disposición: "));
            formaDisposicion.Colspan = 5;
            table.AddCell(formaDisposicion);

            PdfPCell DATOS_PERSONALES = new PdfPCell(new Phrase
                ("DATOS PERSONALES Y DE IDENTIFICACIÓN DEL SOLICITANTE", font));
            DATOS_PERSONALES.BackgroundColor = BaseColor.BLACK;
            DATOS_PERSONALES.Colspan = 5;
            DATOS_PERSONALES.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(DATOS_PERSONALES);

            PdfPCell nombreSolicitante = new PdfPCell(new Phrase("Nombre(s): "));
            nombreSolicitante.Colspan = 5;
            table.AddCell("Apellido Paterno: ");
            table.AddCell("Apellido Materno: ");
            table.AddCell(nombreSolicitante);

            PdfPCell fechaGeneroCurp = new PdfPCell(new Phrase("Fecha nacimiento: "));
            fechaGeneroCurp.Colspan = 5;
            table.AddCell("CURP: ");
            table.AddCell("Genero: ");
            table.AddCell(fechaGeneroCurp);

            table.WidthPercentage = 100;
            doc.Add(table);
            doc.Close();
        }
    }
}
      