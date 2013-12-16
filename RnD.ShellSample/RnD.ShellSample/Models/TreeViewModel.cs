using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RnD.ShellSample.Models
{
    public class TreeViewModel
    {
        public TreeViewModel[] children { get; set; }

        public string classes { get; set; }

        public bool expanded { get; set; }

        public bool hasChildren { get; set; }

        public string id { get; set; }

        public string text { get; set; }
    }
}