using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class ModernBrowser : UserControl
    {
        public ModernBrowser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the url contained within the address bar.
        /// </summary>
        private void goButton_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser.Navigate(addressBar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Detects keypress events that happen within the address bar and, if the key pressed is "ENTER",
        /// navigates to the specified web address.
        /// </summary>
        private void addressBar_KeyUp(object sender, KeyEventArgs e)
        {
            // If the enter key is pressed and released, navigate to the given address.
            if (e.KeyCode == Keys.Enter)
            {
                goButton_Click(sender, e);
            }
        }

        /// <summary>
        /// Resizes the address bar to fill the empty space between icons.
        /// Does not currently work.
        /// </summary>
        private void resizeAddressBar()
        {
            int width = Width;
            for (int i = 0; i < toolStrip.Items.Count; i++)
            {
                if (toolStrip.Items[i].GetType().ToString().Equals("Button"))
                {
                    width += toolStrip.Items[i].Width + toolStrip.Items[i].Padding.Horizontal;
                }
            }
            addressBar.Width = width;
        }

        /// <summary>
        /// Refreshes the browser window when the refreshbutton is clicked.
        /// </summary>
        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }

        /// <summary>
        /// Goes forward in the browser's history.
        /// </summary>
        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }

        /// <summary>
        /// Goes back in the browser's history.
        /// </summary>
        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void ModernBrowser_SizeChanged(object sender, EventArgs e)
        {
            resizeAddressBar();
        }

        private void ModernBrowser_Load(object sender, EventArgs e)
        {
            ModernBrowser_SizeChanged(sender, e);
        }

        /// <summary>
        /// Sets the Enabled property for the forward and back buttons based on wether there is
        ///     anything for them to navigate to after navigating to the page.
        /// </summary>
        private void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Adjust back and forward button status.
            backButton.Enabled = webBrowser.CanGoBack;
            forwardButton.Enabled = webBrowser.CanGoForward;

            // Change addressBar text.
            addressBar.Text = webBrowser.Url.ToString();

            // Add new webpage to history.
            var historyItem = new HistoryItem();
            historyItem.Date = DateTime.Now;
            if (webBrowser.DocumentTitle.Length > 50)
            {
                historyItem.Title = (webBrowser.DocumentTitle.Substring(0,47) + "...");
            }
            else if (webBrowser.DocumentTitle.Equals(""))
            {
                historyItem.Title = "-NO TITLE-";
            }
            else
            {
                historyItem.Title = webBrowser.DocumentTitle;
            }
            historyItem.URL = webBrowser.Url.ToString();
            HistoryManager.AddItem(historyItem);
        }

        /// <summary>
        /// Checks to see if a bookmark for the specified page already exists, and adds one if none exists.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bookmarkButton_Click(object sender, EventArgs e)
        {
            var bookmarks = BookmarksManager.GetItems();
            var bookmarkExists = false;
            // Check to see if a bookmark for the specified page already exists.
            foreach (var bookmark in bookmarks)
            {
                if (bookmark.URL == webBrowser.Url.ToString())
                {
                    bookmarkExists = true;
                }
            }
            // Add a bookmark if none exists.
            if (!bookmarkExists)
            {
                var bookmark = new BookmarkItem();
                bookmark.Title = webBrowser.DocumentTitle;
                bookmark.URL = webBrowser.Url.ToString();
                BookmarksManager.AddItem(bookmark);
            }
        }
    }
}