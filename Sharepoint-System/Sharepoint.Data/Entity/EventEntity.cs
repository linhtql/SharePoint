using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Entity
{
    public class EventEntity
    {
        public String Id { get; set; }
        public String Name { get; set; }

        public DateOnly CreateDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
