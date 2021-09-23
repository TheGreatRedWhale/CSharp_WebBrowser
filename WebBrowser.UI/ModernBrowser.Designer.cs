namespace WebBrowser.UI
{
    partial class ModernBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModernBrowser));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.homeButton = new System.Windows.Forms.ToolStripButton();
            this.bookmarkButton = new System.Windows.Forms.ToolStripButton();
            this.addressBar = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.navigationStatusBar = new System.Windows.Forms.ToolStripProgressBar();
            this.navigationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cursorURLLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.refreshButton,
            this.homeButton,
            this.bookmarkButton,
            this.addressBar,
            this.goButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(809, 27);
            this.toolStrip.TabIndex = 3;
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Enabled = false;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(24, 24);
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Enabled = false;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(24, 24);
            this.forwardButton.Text = "Forward";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(24, 24);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(24, 24);
            this.homeButton.Text = "Home";
            // 
            // bookmarkButton
            // 
            this.bookmarkButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.bookmarkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookmarkButton.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkButton.Image")));
            this.bookmarkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bookmarkButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.bookmarkButton.Name = "bookmarkButton";
            this.bookmarkButton.Size = new System.Drawing.Size(24, 24);
            this.bookmarkButton.Text = "Bookmark";
            this.bookmarkButton.Click += new System.EventHandler(this.bookmarkButton_Click);
            // 
            // addressBar
            // 
            this.addressBar.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.addressBar.Name = "addressBar";
            this.addressBar.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.addressBar.Size = new System.Drawing.Size(587, 24);
            this.addressBar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyUp);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(24, 24);
            this.goButton.Text = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser.Location = new System.Drawing.Point(0, 27);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(809, 512);
            this.webBrowser.TabIndex = 4;
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationStatusBar,
            this.navigationStatusLabel,
            this.cursorURLLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(809, 22);
            this.statusStrip.TabIndex = 5;
            // 
            // navigationStatusBar
            // 
            this.navigationStatusBar.Name = "navigationStatusBar";
            this.navigationStatusBar.Size = new System.Drawing.Size(100, 16);
            // 
            // navigationStatusLabel
            // 
            this.navigationStatusLabel.Name = "navigationStatusLabel";
            this.navigationStatusLabel.Size = new System.Drawing.Size(100, 17);
            this.navigationStatusLabel.Text = "Navigation Status";
            // 
            // cursorURLLabel
            // 
            this.cursorURLLabel.Name = "cursorURLLabel";
            this.cursorURLLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cursorURLLabel.Size = new System.Drawing.Size(66, 17);
            this.cursorURLLabel.Text = "Cursor URL";
            // 
            // ModernBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.toolStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ModernBrowser";
            this.Size = new System.Drawing.Size(809, 539);
            this.Load += new System.EventHandler(this.ModernBrowser_Load);
            this.SizeChanged += new System.EventHandler(this.ModernBrowser_SizeChanged);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.ToolStripButton backButton;
        public System.Windows.Forms.ToolStripButton forwardButton;
        public System.Windows.Forms.ToolStripButton refreshButton;
        public System.Windows.Forms.ToolStripButton homeButton;
        public System.Windows.Forms.ToolStripTextBox addressBar;
        public System.Windows.Forms.ToolStripButton goButton;
        public System.Windows.Forms.ToolStripButton bookmarkButton;
        public System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar navigationStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel navigationStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel cursorURLLabel;
    }
}
