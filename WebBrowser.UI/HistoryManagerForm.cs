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
    public partial class HistoryManagerForm : Form
    {
        public HistoryManagerForm()
        {
            InitializeComponent();
        }

        private void HistoryManagerForm_Load(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
            var history = HistoryManager.GetItems();
            foreach (var item in history)
            {
                historyListBox.Items.Add(item);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text.Equals(""))
            {
                HistoryManagerForm_Load(sender, e);
            }
            else
            {
                historyListBox.Items.Clear();
                var history = HistoryManager.GetItems();
                foreach (var item in history)
                {
                    if (item.ToString().ToUpper().Contains(searchTextBox.Text.ToUpper()))
                    {
                        historyListBox.Items.Add(item);
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
    }
}
