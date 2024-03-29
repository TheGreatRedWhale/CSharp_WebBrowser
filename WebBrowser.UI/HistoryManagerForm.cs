﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        // CUSTOM METHODS -----------------------------------------------------
        
        // GENERATED METHODS --------------------------------------------------

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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var history = HistoryManager.GetItems();
            HistoryManager.RemoveItem(history[historyListBox.SelectedIndex]);
            HistoryManagerForm_Load(sender, e);
            deleteButton.Enabled = false;
        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            HistoryManager.ClearHistory();
            HistoryManagerForm_Load(sender, e);
            deleteButton.Enabled = false;
        }

        private void historyListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (historyListBox.SelectedIndex == -1)
            {
                deleteButton.Enabled = false;
            }
            else
            {
                deleteButton.Enabled = true;
            }
        }

        private void historyListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (historyListBox.SelectedIndex != -1)
            {
                MainForm mainForm = (MainForm) Application.OpenForms[0];
                if (mainForm.tabControl.SelectedIndex != -1)
                {
                    string historyURL = historyListBox.SelectedItem.ToString();
                    historyURL = Regex.Match(historyURL, @"(www.+|http.+)([\s]|$)").Value;
                    try
                    {
                        mainForm.tabControl.TabPages.Insert(mainForm.tabControl.SelectedIndex + 1, "New Tab");
                        TabPage newTab = mainForm.tabControl.TabPages[mainForm.tabControl.SelectedIndex + 1];
                        ModernBrowser modernBrowser = new ModernBrowser();
                        newTab.Controls.Add(modernBrowser);
                        modernBrowser.webBrowser.Navigate(historyURL);
                        int browserIndex = newTab.Controls.Count - 1;
                        newTab.Controls[browserIndex].Dock = DockStyle.Fill;
                        mainForm.tabControl.SelectedIndex++;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
    }
}
