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
    public partial class BookmarksManagerForm : Form
    {
        public BookmarksManagerForm()
        {
            InitializeComponent();
        }

        private void BookmarksManagerForm_Load(object sender, EventArgs e)
        {
            bookmarksListBox.Items.Clear();
            var bookmarks = BookmarksManager.GetItems();
            foreach (var item in bookmarks)
            {
                bookmarksListBox.Items.Add(item);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Equals(""))
            {
                BookmarksManagerForm_Load(sender, e);
            }
            else
            {
                bookmarksListBox.Items.Clear();
                var bookmarks = BookmarksManager.GetItems();
                foreach (var item in bookmarks)
                {
                    if (item.ToString().ToUpper().Contains(searchTextBox.Text.ToUpper()))
                    {
                        bookmarksListBox.Items.Add(item);
                    }
                }
            }
        }

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            // If the enter key is pressed and released, navigate to the given address.
            if (e.KeyCode == Keys.Enter)
            {
                searchButton_Click(sender, e);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            // searchButton_Click(sender, e);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var bookmarks = BookmarksManager.GetItems();
            BookmarksManager.RemoveItem(bookmarks[bookmarksListBox.SelectedIndex]);
            BookmarksManagerForm_Load(sender, e);
        }

        private void bookmarksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bookmarksListBox.SelectedIndex == -1)
            {
                deleteButton.Enabled = false;
            }
            else
            {
                deleteButton.Enabled = true;
            }
        }
    }
}
