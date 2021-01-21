using System;

using ceTe.DynamicPDF.Conversion;

namespace example_html_to_pdf_dotnet
{
    class ConverterExample
    {
        public static void Convert()
        {
            HtmlConversionOptions options = new HtmlConversionOptions(false);
            HtmlConverter htmlConverter = new HtmlConverter(new Uri(@"http://www.google.com"), options);
            htmlConverter.Convert("output.pdf");
        }
    }
}
