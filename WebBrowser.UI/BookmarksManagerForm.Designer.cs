namespace WebBrowser.UI
{
    partial class BookmarksManagerForm
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
            this.bookmarksListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bookmarksListBox
            // 
            this.bookmarksListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookmarksListBox.FormattingEnabled = true;
            this.bookmarksListBox.Location = new System.Drawing.Point(0, 0);
            this.bookmarksListBox.Name = "bookmarksListBox";
            this.bookmarksListBox.Size = new System.Drawing.Size(800, 450);
            this.bookmarksListBox.TabIndex = 0;
            // 
            // BookmarksManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bookmarksListBox);
            this.Name = "BookmarksManagerForm";
            this.Text = "Bookmarks";
            this.Load += new System.EventHandler(this.BookmarksManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox bookmarksListBox;
    }
}