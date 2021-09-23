using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebBrowser.Logic;

namespace WebBrowser.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Closes the browser.
        /// </summary>
        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Shows information about the browser
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Developer:\tJared Whaley\n" +
                "SID:\t\tjjw0008\n" +
                "------------------------------------------------\n" +
                "Developed for the course CPSC 2710.");
        }
        

        /// <summary>
        /// Inserts a new tab.
        /// </summary>
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Insert(tabControl.SelectedIndex + 1 ,"New Tab");
            tabControl.TabPages[tabControl.SelectedIndex + 1].Controls.Add(new ModernBrowser());
            int browserIndex = tabControl.TabPages[tabControl.SelectedIndex + 1].Controls.Count - 1;
            tabControl.TabPages[tabControl.SelectedIndex + 1].Controls[browserIndex].Dock = DockStyle.Fill;
            tabControl.SelectedIndex++;
        }

        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count <= 1)
            {
                exitWebBrowserToolStripMenuItem_Click(sender, e);
            }
            else
            {
                int removalIndex = tabControl.SelectedIndex;
                if (tabControl.SelectedIndex > 0)
                {
                    tabControl.SelectedIndex--;
                }
                tabControl.TabPages.RemoveAt(removalIndex);
            }
        }

        private void manageHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var historyManagerForm = new HistoryManagerForm();
            var history = HistoryManager.GetItems();
            foreach (var item in history)
            {
                historyManagerForm.historyListBox.Items.Add(item);
            }
            historyManagerForm.ShowDialog();
        }

        private void manageBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookmarksManagerForm = new BookmarksManagerForm();
            var bookmarks = BookmarksManager.GetItems();
            foreach (var item in bookmarks)
            {
                bookmarksManagerForm.bookmarksListBox.Items.Add(item);
            }
            bookmarksManagerForm.ShowDialog();
        }

        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
        }
    }
}
