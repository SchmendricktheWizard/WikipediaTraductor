using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WikipediaTraductor
{
    public partial class Form1 : Form
    {
        PageGetter pageGetter = new PageGetter();
        WikiPage currentPage;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentPageContent.Text = "";
            currentPageTitle.Text = "";
            currentPage = new WikiPage(pageGetter.GetRandomPage());
            currentPageTitle.Text = currentPage.title;
            foreach(string paragraph in currentPage.Paragraphs())
            {
                currentPageContent.Text += string.Format($"{paragraph}\n");
            }


        }
    }
}
