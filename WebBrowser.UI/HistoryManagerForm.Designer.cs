namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryManagerForm));
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.topToolStrip = new System.Windows.Forms.ToolStrip();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.deleteButton = new System.Windows.Forms.ToolStripButton();
            this.clearHistoryButton = new System.Windows.Forms.ToolStripButton();
            this.topToolStrip.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyListBox.Enabled = false;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(0, 25);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(479, 425);
            this.historyListBox.TabIndex = 0;
            this.historyListBox.SelectedIndexChanged += new System.EventHandler(this.historyListBox_SelectedIndexChanged);
            // 
            // topToolStrip
            // 
            this.topToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchTextBox,
            this.searchButton});
            this.topToolStrip.Location = new System.Drawing.Point(0, 0);
            this.topToolStrip.Name = "topToolStrip";
            this.topToolStrip.Size = new System.Drawing.Size(479, 25);
            this.topToolStrip.TabIndex = 1;
            this.topToolStrip.Text = "toolStrip1";
            // 
            // searchButton
            // 
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 22);
            this.searchButton.Text = "Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(400, 25);
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteButton,
            this.clearHistoryButton});
            this.bottomToolStrip.Location = new System.Drawing.Point(0, 425);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.Size = new System.Drawing.Size(479, 25);
            this.bottomToolStrip.TabIndex = 4;
            this.bottomToolStrip.Text = "toolStrip1";
            // 
            // deleteButton
            // 
            this.deleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteButton.Image")));
            this.deleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 22);
            this.deleteButton.Text = "Delete Entry";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearHistoryButton
            // 
            this.clearHistoryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clearHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("clearHistoryButton.Image")));
            this.clearHistoryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearHistoryButton.Name = "clearHistoryButton";
            this.clearHistoryButton.Size = new System.Drawing.Size(79, 22);
            this.clearHistoryButton.Text = "Clear History";
            this.clearHistoryButton.Click += new System.EventHandler(this.clearHistoryButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.bottomToolStrip);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.topToolStrip);
            this.Name = "HistoryManagerForm";
            this.Text = "History";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.topToolStrip.ResumeLayout(false);
            this.topToolStrip.PerformLayout();
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.ToolStrip topToolStrip;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStrip bottomToolStrip;
        private System.Windows.Forms.ToolStripButton deleteButton;
        private System.Windows.Forms.ToolStripButton clearHistoryButton;
    }
}