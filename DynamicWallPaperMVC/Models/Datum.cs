using System;
using System.Collections.Generic;

namespace DynamicWallPaperMVC.Models
{
    public class Datum
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int datetime { get; set; }
        public string type { get; set; }
        public bool animated { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int size { get; set; }
        public int views { get; set; }
        public object bandwidth { get; set; }
        public object vote { get; set; }
        public bool favorite { get; set; }
        public bool nsfw { get; set; }
        public string section { get; set; }
        public object account_url { get; set; }
        public object account_id { get; set; }
        public bool is_ad { get; set; }
        public bool in_most_viral { get; set; }
        public bool has_sound { get; set; }
        public List<object> tags { get; set; }
        public int ad_type { get; set; }
        public string ad_url { get; set; }
        public int edited { get; set; }
        public bool in_gallery { get; set; }
        public string link { get; set; }
        public AdConfig ad_config { get; set; }
        public object comment_count { get; set; }
        public object favorite_count { get; set; }
        public object ups { get; set; }
        public object downs { get; set; }
        public object points { get; set; }
        public int score { get; set; }
        public bool is_album { get; set; }
    }
}
