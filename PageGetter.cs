using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikipediaTraductor
{
    /// <summary>
    /// Retreives pages from wikipedia and returns them as an HtmlDoc
    /// </summary>
    internal class PageGetter
    {
        HtmlWeb web = new HtmlWeb();
     
        /// <summary>
        /// Get a random Wikipedia page
        /// </summary>
        /// <returns></returns>
        public HtmlDocument GetRandomPage()
        {
           return web.Load("https://en.wikipedia.org/wiki/Special:Random");
        }

        /// <summary>
        /// Get a specific Wikipedia page
        /// </summary>
        /// <param name="title">The title of the Wikipedia page you're looking for</param>
        /// <returns></returns>
        public HtmlDocument GetPage(string title)
        {
            return web.Load($"https://en.wikipedia.org/wiki/{title}");
        }
    }
}
