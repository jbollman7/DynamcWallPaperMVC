using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DynamicWallPaperMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DynamicWallPaperMVC.Controllers
{
    public class WallPaperController : Controller
    {
        private const string BaseUrl = "https://api.imgur.com/3/gallery/r/";
        private string _url;
        private string subreddit = "";
        //private static HttpClient Client = new HttpClient();
        private const string refreshToken = "be2fcb8ea54d0168a8e4aac6a08d46bc35d4320f";
        private List<Datum> images;

        public string UrlBuilder()
        {
            if (subreddit == "")
                _url = $"{BaseUrl}wallpaper/1";
            else
                _url = $"{BaseUrl}{subreddit}";
            return _url;
        }
        
        public async Task<IActionResult> Index()
        {
            await this.FetchJsonImages();
            //ViewData["data"] = FetchJsonImages().Result.data;
            ViewData["images"] = images;
            return View();
        }
        public async Task<DatumList> FetchJsonImages()
        {
            var urlBuilderVar = UrlBuilder();
            var request = new HttpRequestMessage {RequestUri = new Uri(urlBuilderVar), Method = HttpMethod.Get};
            request.Headers.Add("Accept", "application/json");
   
            //Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", refreshToken);
            var authValue = new AuthenticationHeaderValue("Bearer", refreshToken);

            var client = new HttpClient(){
                DefaultRequestHeaders = { Authorization = authValue}
                
            };
            
            var response = await client.GetAsync(urlBuilderVar);
            var content = response.Content;
            var json = await content.ReadAsStringAsync();
            var wrapper = JsonConvert.DeserializeObject<DatumList>(json);
            images = wrapper.data;
            return wrapper;
        }
    }
}
