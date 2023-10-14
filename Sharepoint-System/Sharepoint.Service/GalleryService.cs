using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.Extensions.Logging;
using Sharepoint.Dao;
using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Service
{
    public class GalleryService : IGalleryService
    {
        private readonly GalleryDAO galleryDAO;

        public GalleryService(GalleryDAO gallery)
        {
            this.galleryDAO = gallery;
        }
        public async Task<bool> Add(List<Gallery> galleries)
        {
            var result = await galleryDAO.AddGalleries(galleries);
            return result;
        }

        public async Task<bool> Delete(string Id)
        {
            var result = await galleryDAO.Delete(Id);
            return result;
        }

        public async Task<List<Gallery>> GetAll(GalleryType type)
        {
            var result = await galleryDAO.FindAllByType(type);
            return result;
        }

        public async Task<Gallery> GetById(string id)
        {
            var result = await galleryDAO.FindById(id);
            return result;
        }

        public async Task<bool> Update(Gallery gallery)
        {
            var result = await galleryDAO.Update(gallery);
            return result;
        }
    }



}
