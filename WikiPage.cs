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
        private HtmlNodeCollection topics;
        public HtmlDocument htmlDocument;
        public WikiPage(HtmlDocument htmlDocument)
        {
            this.htmlDocument = htmlDocument;

            this.title = htmlDocument.DocumentNode
                .SelectSingleNode("//h1[@id=\"firstHeading\"]")
                .InnerText;
            this.topics = htmlDocument.DocumentNode.SelectNodes("//*[@class=\"mw-headline\"]/span");

        }
        /// <summary>
        /// A list of the subtopic headers on the page as strings
        /// </summary>
        public string[] Topics
        {
            get
            {
                if (topics == null)
                    return null;
                string[] result = new string[topics.Count];
                int i = 0;
                foreach (var topic in topics)
                {
                    if (topic.InnerText != "External Links" && topic.InnerText != "References")
                    {
                        result[i] = topic.InnerText;
                        i++;
                    }
                }
                return result;
            }
        }

    }
}
