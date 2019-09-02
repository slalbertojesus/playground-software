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
                ("Solicitud.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
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

            PdfPCell rfcFielDomicilioNoExtNoInt = new PdfPCell(new Phrase("No ext: "));
            rfcFielDomicilioNoExtNoInt.Colspan = 5;
            table.AddCell("RFC: ");
            table.AddCell("FIEL: ");
            table.AddCell("Domicilio: ");
            table.AddCell("No int: ");
            table.AddCell(rfcFielDomicilioNoExtNoInt);

            PdfPCell coloniaCpDelegacion = new PdfPCell(new Phrase("Delegacion: "));
            coloniaCpDelegacion.Colspan = 5;
            table.AddCell("Colonia: ");
            table.AddCell("Cp: ");
            table.AddCell(coloniaCpDelegacion);

            PdfPCell ciudadEstadoPaisTiempoRecidencia = new PdfPCell(new Phrase("Tiempo de recidencia: "));
            ciudadEstadoPaisTiempoRecidencia.Colspan = 5;
            table.AddCell("Ciudad: ");
            table.AddCell("Estado: ");
            table.AddCell("Pais: ");
            table.AddCell(ciudadEstadoPaisTiempoRecidencia);

            PdfPCell tipoDomicilio = new PdfPCell(new Phrase("Tipo de domicilio: "));
            tipoDomicilio.Colspan = 5;
            table.AddCell(tipoDomicilio);

            PdfPCell telefono = new PdfPCell(new Phrase("Casa: "));
            telefono.Colspan = 5;
            table.AddCell("Telefonos Oficina:");
            table.AddCell("Celular:");
            table.AddCell(telefono);

            PdfPCell estadoNacionalidad = new PdfPCell(new Phrase("Nacionalidad: "));
            estadoNacionalidad.Colspan = 5;
            table.AddCell("Estado civil:");
            table.AddCell(estadoNacionalidad);

            PdfPCell correoNacimientoEstadoPais = new PdfPCell(new Phrase("Pais: "));
            correoNacimientoEstadoPais.Colspan = 5;
            table.AddCell("Correo:");
            table.AddCell("Lugar de nacimiento:");
            table.AddCell("Estado:");
            table.AddCell(correoNacimientoEstadoPais);

            PdfPCell INFORMACION_EMPLEO = new PdfPCell(new Phrase
                ("INFORMACIÓN DEL EMPLEO", font));
            INFORMACION_EMPLEO.BackgroundColor = BaseColor.BLACK;
            INFORMACION_EMPLEO.Colspan = 5;
            INFORMACION_EMPLEO.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(INFORMACION_EMPLEO);

            PdfPCell empresaNoEmpleado = new PdfPCell(new Phrase("Número empleado: "));
            empresaNoEmpleado.Colspan = 5;
            table.AddCell("Nombre empresa:");
            table.AddCell(empresaNoEmpleado);

            PdfPCell centroTrabajoAntiguedad = new PdfPCell(new Phrase("Antiguedad en el empleo: "));
            empresaNoEmpleado.Colspan = 5;
            table.AddCell("Centro de trabajo:");
            table.AddCell(empresaNoEmpleado);

            PdfPCell ocupacionPuestoPresentacion = new PdfPCell(new Phrase("Periodo de presentación: "));
            ocupacionPuestoPresentacion.Colspan = 5;
            table.AddCell("Ocupación:");
            table.AddCell("Puesto:");
            table.AddCell(ocupacionPuestoPresentacion);

            PdfPCell percepcionesLiquidoPercepcionesLiquido = new PdfPCell(new Phrase("Líquido recibo 2: "));
            ocupacionPuestoPresentacion.Colspan = 5;
            table.AddCell("Percepciones recibo 1:");
            table.AddCell("Líquido recibo 1:");
            table.AddCell("Percepciones recibo 2:");
            table.AddCell("Líquido recibo 1:");
            table.AddCell(percepcionesLiquidoPercepcionesLiquido);

            PdfPCell REFERENCIA_PERSONAL = new PdfPCell(new Phrase
                ("REFERENCIAS PERSONALES", font));
            REFERENCIA_PERSONAL.BackgroundColor = BaseColor.BLACK;
            REFERENCIA_PERSONAL.Colspan = 5;
            REFERENCIA_PERSONAL.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(REFERENCIA_PERSONAL);

            PdfPCell nombreRelacionTelefono = new PdfPCell(new Phrase("Telefono: "));
            nombreRelacionTelefono.Colspan = 5;
            table.AddCell("Nombre:");
            table.AddCell("Relación:");
            table.AddCell(nombreRelacionTelefono);

            PdfPCell direccionHorario = new PdfPCell(new Phrase("Direcicón: "));
            direccionHorario.Colspan = 5;
            table.AddCell("Horario:");
            table.AddCell(direccionHorario);

            PdfPCell nombreRelacionTelefonoSegundo = new PdfPCell(new Phrase("Telefono: "));
            nombreRelacionTelefonoSegundo.Colspan = 5;
            table.AddCell("Nombre:");
            table.AddCell("Relación:");
            table.AddCell(nombreRelacionTelefonoSegundo);

            PdfPCell direccionHorarioSegundo = new PdfPCell(new Phrase("Direcicón: "));
            direccionHorarioSegundo.Colspan = 5;
            table.AddCell("Horario:");
            table.AddCell(direccionHorarioSegundo);

            string textoEntrevista = @"Entrevista personal: Comentarios adicionales del promotor sobre la entrevista realizada:
            ¿Usted desempeña o ha desempeñado funciones públicas en un país extranjero o en territorio nacional, considerando
            entre otros, alos jefes de estado o de gobierno, lideres políticos, funcionarios gubernamentales de alta jerarquia,
            judiciales o militares de alta jerarquía, altos ejecutivos de empresas estatales o funcionarios o miembros importantes
            de partidos políticos?";

            textoEntrevista = textoEntrevista.Replace(Environment.NewLine, String.Empty).Replace("  ", String.Empty);

            Chunk chuckTexto = new Chunk(textoEntrevista);
            PdfPCell celdaEntrevista = new PdfPCell(new Phrase(chuckTexto));
            celdaEntrevista.Colspan = 5;
            celdaEntrevista.HorizontalAlignment = Element.PARAGRAPH;
            table.AddCell(celdaEntrevista);

            table.WidthPercentage = 100;
            doc.Add(table);
            doc.Close();
        }
    }
}
      