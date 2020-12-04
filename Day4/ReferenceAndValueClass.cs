using System;

namespace Day4
{
    class ReferenceAndValueClass
    {
        public void ShowTheDifference()
        {

            PrintedPage originalPrintedPage = new PrintedPage();
            originalPrintedPage.Text = "Original printed text";

            
            PrintedPage copyOfPrintedPage = originalPrintedPage;

            copyOfPrintedPage.Text = "Changed printed text";

            
            Console.WriteLine("originalPrintedPage={0}",
                               originalPrintedPage.Text);
           
            WebPage originalWebPage = new WebPage();
            originalWebPage.Text = "Original web text";

            
            WebPage copyOfWebPage = originalWebPage;

            
            copyOfWebPage.Text = "Changed web text";

            
            Console.WriteLine("originalWebPage={0}",
                               originalWebPage.Text);

            
            copyOfWebPage = new WebPage();
            copyOfWebPage.Text = "Changed web page again";

            
            Console.WriteLine("originalWebPage={0}",
                               originalWebPage.Text);




        }


    }

    struct PrintedPage
    {
        public string Text;
    }

    // WebPage is a reference type
    class WebPage
    {
        public string Text;
    }
}
