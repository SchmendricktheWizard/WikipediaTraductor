﻿using HtmlAgilityPack;
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
            HtmlWeb htmlWeb = new HtmlWeb();
            var html = 
            WikiPage firstPage = new WikiPage();
            Console.WriteLine("Page Title: ");
        }
    }
}