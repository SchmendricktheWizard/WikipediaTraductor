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
        private HtmlNodeCollection paragraphs;
        public HtmlDocument htmlDocument;
        public WikiPage(HtmlDocument htmlDocument)
        {
            this.htmlDocument = htmlDocument;

            this.title = htmlDocument.DocumentNode
                .SelectSingleNode("//h1[@id=\"firstHeading\"]")
                .InnerText;
            this.topics = htmlDocument.DocumentNode.SelectNodes("//*[@class=\"mw-headline\"]");
            this.paragraphs = htmlDocument.DocumentNode.SelectNodes("//p");

        }
        /// <summary>
        /// Returns a string array of subtopic headers on the page
        /// </summary>
        public string[] Topics()
        {
            string[] result = new string[topics.Count];
            if (topics == null)
                return new string[0];
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

        public string[] Paragraphs()
        {
            string[] result = new string[paragraphs.Count];
            int i = 0;
            foreach(var paragraph in paragraphs)
            {
                result[i] = paragraph.InnerText;
                i++;
            }
            return result;
        }

    }
}
