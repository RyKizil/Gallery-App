using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gallery_App.Models;
using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data.Models;

namespace Gallery_App.Controllers
{
    public class GalleryController : Controller
    {
        

        public IActionResult Index()
        {
            var coffeetags = new List<ImageTag>();
            var citytags = new List<ImageTag>();
            var naturetags = new List<ImageTag>();

            var tag1 = new ImageTag() { Description = "Coffee", Id = 1 };
            var tag2 = new ImageTag() { Description = "Nature", Id = 2 };
            var tag3 = new ImageTag() { Description = "Urban", Id = 1 };

            coffeetags.Add(tag1);
            citytags.Add(tag3);
            naturetags.Add(tag2);

            var imageList = new List<GalleryImage>()
            {
                new GalleryImage
                {
                    Title = "coffee",
                    Url ="https://images.pexels.com/photos/302899/pexels-photo-302899.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = coffeetags
                },
                new GalleryImage
                {
                    Title = "city trips",
                    Url ="https://images.pexels.com/photos/708764/pexels-photo-708764.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    Created = DateTime.Now,
                    Tags = citytags
                },
                new GalleryImage
                {
                    Title = "Nature sight",
                    Url ="https://images.pexels.com/photos/4827/nature-forest-trees-fog.jpeg?cs=srgb&dl=fog-foggy-forest-4827.jpg&fm=jpg",
                    Created = DateTime.Now,
                    Tags = naturetags}

            };
            var model = new GalleryIndexModel()
            {
                Images = imageList,
                SearchQuery = ""
            };
            return View(model);
        }
    }
}