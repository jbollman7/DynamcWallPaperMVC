using System;
using System.Collections.Generic;

namespace DynamicWallPaperMVC.Models
{
    public class DatumList
    {
        public List<Datum> data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }
    }
}
