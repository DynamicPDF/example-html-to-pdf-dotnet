using System;

using ceTe.DynamicPDF.HtmlConverter;

namespace example_html_to_pdf_dotnet
{
    class HtmlConverterExample
    {
        public static void Convert()
        {
            ConversionOptions options = new ConversionOptions(PageSize.A4, PageOrientation.Portrait, 50.0f);
            // Set Metadata for the PDF
            options.Author = "Myself";
            options.Title = "My Webpage";
            // Set Header and Footer text
            options.Header = "<div style=\"text-align:center;display:inline-block;width:100%;font-size:12px;\">" +
                "<span class=\"date\"></span></div>";
            options.Footer = "<div style=\"text-align:center;display:inline-block;width:100%;font-size:12px;\">" +
                "Page <span class=\"pageNumber\"></span> of <span class=\"totalPages\"></span></div>";
            // Convert with Options          
            Converter.Convert(new Uri("https://en.wikipedia.org"), "html-converter-output.pdf", options);
        }
    }
}
