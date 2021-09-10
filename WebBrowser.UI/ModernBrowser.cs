using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            webBrowser.Navigate(addressBar.Text);
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

        private void ModernBrowser_Resize(object sender, EventArgs e)
        {
            resizeAddressBar();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser.Refresh();
        }
    }
}