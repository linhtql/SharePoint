using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Model
{
    public class DocType : DocumentExtension
    {
        public String Id { get; set; }
        public String ImageUrl { get; set; }
        public String Title { get; set; }
    }
}
