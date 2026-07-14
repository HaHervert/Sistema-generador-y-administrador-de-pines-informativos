using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace SGAPI
{
    public static class ExportadorPDF
    {
        public static void ExportarPin(string rutaArchivo, PinInformativo pin, string textoPin)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(40);
                    page.Size(PageSizes.A4);

                    page.Header()
                        .Column(col =>
                        {
                            col.Item().Text("SGAPI")
                                .FontSize(20)
                                .Bold();

                            col.Item().Text("Sistema Generador y Administrador de Pines Informativos")
                                .FontSize(11);

                            col.Item().Text("CEIPOL - Comisaría Vial del Estado de Jalisco")
                                .FontSize(10);

                            col.Item().LineHorizontal(1);
                        });

                    page.Content()
                        .PaddingTop(20)
                        .Column(col =>
                        {
                            col.Item().Text($"Reporte: Rep.-{pin.NumeroReporte} de CEIPOL").Bold();
                            col.Item().Text($"Fecha: {pin.Fecha}");
                            col.Item().Text($"Municipio: {pin.Municipio}");
                            col.Item().Text($"Estado: {pin.Estado}");

                            col.Item().PaddingVertical(10).LineHorizontal(1);

                            col.Item().Text(textoPin)
                                .FontSize(10);
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(text =>
                        {
                            text.Span("Documento generado por SGAPI - ");
                            text.Span(System.DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                        });
                });
            })
            .GeneratePdf(rutaArchivo);
        }
    }
}