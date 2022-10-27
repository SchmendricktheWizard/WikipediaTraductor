using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikipediaTraductor
{
    public partial class MainWindow : Form
    {
        PageGetter pageGetter = new PageGetter();
        WikiPage currentPage;
        public MainWindow()
        {
            InitializeComponent();

        }


        private void random_Click(object sender, EventArgs e)
        {
            currentPageContent.Text = "";
            currentPageTitle.Text = "";
            currentPage = new WikiPage(pageGetter.GetRandomPage());
            currentPageTitle.Text = currentPage.Title;
           
            foreach (string paragraph in currentPage.Paragraphs)
            {
                //htmldecode removes the &#3252 nonsense 

                currentPageContent.Text += WebUtility.HtmlDecode(string.Format($"{paragraph}\n"));
            }
        }

        private void goto_Click(object sender, EventArgs e)
        {
            currentPageContent.Text = "";
            currentPageTitle.Text = "";
            currentPage = new WikiPage(pageGetter.GetPage(searchBar.Text));
            currentPageTitle.Text = currentPage.Title;
            foreach (string paragraph in currentPage.Paragraphs)
            {
                currentPageContent.Text += WebUtility.HtmlDecode(string.Format($"{paragraph}\n"));
            }

        }

        private void Submit(object sender, EventArgs e)
        {
            string translatedText = translationInput.Text;
            translationInput.Text = "";
            translationLog.Text += String.Format(translatedText);
        }
    }
}
