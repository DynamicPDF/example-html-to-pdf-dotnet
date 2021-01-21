using ceTe.DynamicPDF;
using System;

namespace example_html_to_pdf_dotnet
{
    class Program
    {

        static void Main(string[] args)
        {
            HtmlConverterExample.Convert();
            CoreSuiteExample.Convert();
            ConverterExample.Convert();
        }
    }
}
