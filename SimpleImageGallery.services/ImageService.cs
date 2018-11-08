using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SimpleImageGallery.Data;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallery.services
{
    public class ImageService : IImage
    {
        private readonly SimpleImageGalleryDbContext _context;

        public ImageService(SimpleImageGalleryDbContext context)
        {
            _context = context;
        }
        public IEnumerable<GalleryImage> GetAll()
        {
            return _context.GalleryImages.Include(img => img.Tags);
        }

        public GalleryImage GetById(int id)
        {
            return GetAll().Where(img => img.Id == id).First();
        }

        public IEnumerable<GalleryImage> GetByTag(string tag)
        {
           return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }
    }
}
