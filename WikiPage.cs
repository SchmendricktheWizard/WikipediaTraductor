using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikipediaTraductor
{
    /// <summary>
    /// Class <c>WikiPage</c> stores and parses HTML data for a particular Wikipedia page.
    /// </summary>
    internal class WikiPage
    {
        public string title;
        public string[] topics;
        public HtmlDocument htmlDocument;
        public WikiPage(HtmlDocument htmlDocument)
        {
            this.htmlDocument = htmlDocument;

            this.title = htmlDocument.DocumentNode
                .SelectSingleNode("//[class=\"mw-page-title-main\"")
                .InnerText;
        }
        

    }
}
