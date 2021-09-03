using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "Developer:\tJared Whaley\n" +
                "SID:\t\tjjw0008\n" +
                "------------------------------------------------\n" +
                "Developed for the course CPSC 2710.");
        }

        private void addressTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            // If the enter key is pressed and released, navigate to the given address.
            if (e.KeyCode == Keys.Enter)
            {
                goButton_Click(sender, e);
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(addressTextBox.Text);
        }
    }
}
