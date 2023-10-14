using Newtonsoft.Json;
using Sharepoint.Data.Entity;
using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Convert
{
    public static class GalleryConvert
    {
        public static Gallery ToGallery(GalleryEntity entity)
        {
            var result = new Gallery();
            result.Id = entity.Id;
            result.Name = entity.Name;
            result.Type = (GalleryType)entity.Type;

            if (!String.IsNullOrEmpty(entity.Extension))
            {
                Type extensionType = null;
                switch (result.Type)
                {
                    case GalleryType.Document:
                        extensionType = typeof(DocumentGalleryExtension);
                        break;
                    case GalleryType.Image:
                        extensionType = typeof(ImageGalleryExtension);
                        break;
                    case GalleryType.Video:
                        extensionType = typeof(VideoGalleryExtension);
                        break;
                }
                if (extensionType != null)
                {
                    result.Extension = JsonConvert.DeserializeObject(entity.Extension, extensionType) as GalleryExtension;
                }
            }


            return result;
        }
        public static GalleryEntity ToEntity(Gallery gallery)
        {
            var result = new GalleryEntity();

            if (String.IsNullOrEmpty(gallery.Id))
            {
                gallery.Id = Guid.NewGuid().ToString();
            }

            result.Id = gallery.Id;
            result.Name = gallery.Name;
            result.Type = (Int32)gallery.Type;
            result.Extension = JsonConvert.SerializeObject(gallery.Extension,
                new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto });

            return result;
        }
    }
}
