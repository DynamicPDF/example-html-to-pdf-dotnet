using System;

using ceTe.DynamicPDF;

namespace example_html_to_pdf_dotnet
{
    class CoreSuiteExample
    {
        public static void Convert()
        {
            //Create a PageInfo object with required page settings
            PageInfo layoutPage = new PageInfo(PageSize.A4, PageOrientation.Portrait);
            //Create a Uri to be converte to PDF
            Uri uri = new Uri(@"http://www.google.com");

            //Create a HtmlLayout object using Uri and PageInfo
            HtmlLayout html = new HtmlLayout(uri, layoutPage);

            //Set Header and Footer
            html.Header.Center.Text = "%%PR%%%%SP%% of %%ST%%";
            html.Header.Center.HasPageNumbers = true;
            html.Header.Center.Width = 200;

            html.Footer.Center.Text = "%%PR%%%%SP(A)%% of %%ST(B)%%";
            html.Footer.Center.HasPageNumbers = true;
            html.Footer.Center.Width = 200;

            //Get Document and save
            Document document = html.Layout();
            document.Draw("core-suite-output.pdf");
        }

    }
}
