using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace PdfCreatorWithPdfSharp.Utils
{
    public static class PdfCreatorExtension
    {
        public static void CreatePdf(this string filename, string topText, string centerText, string bottomText)
        {
            using (PdfDocument pdfDocument = new PdfDocument())
            {
                PdfPage page = pdfDocument.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
                gfx.DrawString(topText, font, XBrushes.Black, page.Width / 10f , page.Height / 10f);
                gfx.DrawString(centerText, font, XBrushes.Black, page.Width / 10f, page.Height / 6f);
                gfx.DrawString(bottomText, font, XBrushes.Black, page.Width / 10f, page.Height / 2f);
                pdfDocument.Save(filename + ".pdf");
            }
        }
    }
}
