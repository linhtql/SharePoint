using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Entity
{
    public class InformationEntity
    {
        public String Id { get; set; }
        public Int32 Type { get; set; }
        public String ImageUrl { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public DateOnly CreatedDate { get; set; }
        public String Extension { get; set; }
    }
}
