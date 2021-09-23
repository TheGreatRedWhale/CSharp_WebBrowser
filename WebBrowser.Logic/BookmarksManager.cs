using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.WebBrowserDBDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarksManager
    {
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }
        public static void RemoveItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Delete(item.ID);
        }
        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.ID = row.Id;
                item.URL = row.URL;
                item.Title = row.Title;

                results.Add(item);
            }

            return results;
        }
    }
}
