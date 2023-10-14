using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Model
{
    public class Information
    {
        public String Id { get; set; }
        public InformationType Type { get; set; }
        public String ImageUrl { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateOnly CreatedDate { get; set; }
        public InformationExtension? Extension { get; set; }
    }
}
