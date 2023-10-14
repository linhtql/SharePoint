using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Model
{
    public class DocumentGalleryExtension : GalleryExtension
    {
        public String Id { get; set; }
        public DocumentType Type { get; set; }
        public String Name { get; set; }
        public DocumentExtension? Extension { get; set; }

    }
}
