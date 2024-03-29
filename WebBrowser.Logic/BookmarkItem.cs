﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class BookmarkItem
    {
        public int ID { get; set; }
        public string URL { get; set; }
        public string Title { get; set; }

        public override string ToString()
        {
            return (String.Format("{0} ({1})", Title, URL));
        }
    }
}
