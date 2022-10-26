using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikipediaTraductor
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            PageGetter pageGetter = new PageGetter();
            WikiPage newPage = new WikiPage(pageGetter.GetRandomPage());

            Console.WriteLine("Page Title: {0}", newPage.title);
            foreach (string topic in newPage.Topics)
            {
                Console.WriteLine("Topic: {0}", topic);
            }
        }
    }
}
