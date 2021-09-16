using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        public int ID { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            var dateString = Date.ToShortDateString() + " at " + Date.ToShortTimeString();
            return (String.Format("[{0}] {1} ({2})", dateString, Title, URL));
        }
    }
}
