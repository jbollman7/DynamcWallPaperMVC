using System;
using System.Collections.Generic;

namespace DynamicWallPaperMVC.Models
{
    public class AdConfig
    {
        public List<string> safeFlags { get; set; }
        public List<string> highRiskFlags { get; set; }
        public List<object> unsafeFlags { get; set; }
        public List<object> wallUnsafeFlags { get; set; }
        public bool showsAds { get; set; }
    }
}
