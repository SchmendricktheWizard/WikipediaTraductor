namespace WikipediaTraductor
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.randomPage = new System.Windows.Forms.Button();
            this.currentPageTitle = new System.Windows.Forms.TextBox();
            this.currentPageContent = new System.Windows.Forms.TextBox();
            this.gotoPage = new System.Windows.Forms.Button();
            this.searchBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // randomPage
            // 
            this.randomPage.Location = new System.Drawing.Point(266, 48);
            this.randomPage.Name = "randomPage";
            this.randomPage.Size = new System.Drawing.Size(113, 23);
            this.randomPage.TabIndex = 0;
            this.randomPage.Text = "Random Page";
            this.randomPage.UseVisualStyleBackColor = true;
            this.randomPage.Click += new System.EventHandler(this.random_Click);
            // 
            // currentPageTitle
            // 
            this.currentPageTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.currentPageTitle.BackColor = System.Drawing.SystemColors.Menu;
            this.currentPageTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPageTitle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.currentPageTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentPageTitle.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPageTitle.Location = new System.Drawing.Point(11, 72);
            this.currentPageTitle.Name = "currentPageTitle";
            this.currentPageTitle.ReadOnly = true;
            this.currentPageTitle.Size = new System.Drawing.Size(366, 20);
            this.currentPageTitle.TabIndex = 2;
            this.currentPageTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentPageContent
            // 
            this.currentPageContent.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.currentPageContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currentPageContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.currentPageContent.Location = new System.Drawing.Point(12, 95);
            this.currentPageContent.Multiline = true;
            this.currentPageContent.Name = "currentPageContent";
            this.currentPageContent.ReadOnly = true;
            this.currentPageContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.currentPageContent.Size = new System.Drawing.Size(367, 343);
            this.currentPageContent.TabIndex = 1;
            this.currentPageContent.TextChanged += new System.EventHandler(this.currentPageContent_TextChanged);
            // 
            // gotoPage
            // 
            this.gotoPage.Location = new System.Drawing.Point(266, 19);
            this.gotoPage.Name = "gotoPage";
            this.gotoPage.Size = new System.Drawing.Size(113, 23);
            this.gotoPage.TabIndex = 3;
            this.gotoPage.Text = "Go To Page";
            this.gotoPage.UseVisualStyleBackColor = true;
            this.gotoPage.Click += new System.EventHandler(this.goto_Click);
            // 
            // searchBar
            // 
            this.searchBar.Location = new System.Drawing.Point(12, 21);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(248, 20);
            this.searchBar.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchBar);
            this.Controls.Add(this.gotoPage);
            this.Controls.Add(this.currentPageTitle);
            this.Controls.Add(this.currentPageContent);
            this.Controls.Add(this.randomPage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Wikipedia Traductor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomPage;
        private System.Windows.Forms.TextBox currentPageTitle;
        private System.Windows.Forms.Button gotoPage;
        private System.Windows.Forms.TextBox searchBar;
        private System.Windows.Forms.TextBox currentPageContent;
    }
}

