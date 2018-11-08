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
            return _context.GalleryImages.Find(id);
        }

        public IEnumerable<GalleryImage> GetByTag(string tag)
        {
           return GetAll().Where(img => img.Tags.Any(t => t.Description == tag));
        }
    }
}
