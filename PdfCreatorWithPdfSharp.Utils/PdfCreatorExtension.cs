using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace PdfCreatorWithPdfSharp.Utils
{
    public static class PdfCreatorExtension
    {
        public static void CreatePdf(this string text)
        {
            using (PdfDocument pdfDocument = new PdfDocument())
            {
                PdfPage page = pdfDocument.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                gfx.DrawString(text, font, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.Center);
                pdfDocument.Save("CreatedViaPdfSharpCore.pdf");
            }
        }
    }
}
