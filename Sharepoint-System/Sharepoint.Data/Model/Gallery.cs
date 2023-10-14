using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Model
{
    public class Gallery
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public GalleryType Type { get; set; }
        public GalleryExtension? Extension { get; set; }
    }
}
