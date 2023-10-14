using Sharepoint.Data.Entity;
using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Data.Convert
{
    public static class EventConvert
    {
        public static Event ToEvent(EventEntity entity)
        {
            var result = new Event();
            result.Id = entity.Id;
            result.Name = entity.Name;
            result.CreateDate = entity.CreateDate;
            result.StartTime = entity.StartTime;
            result.EndTime = entity.EndTime;

            return result;
        }
        public static EventEntity ToEntity(Event eventt)
        {
            var result = new EventEntity();
            if (String.IsNullOrEmpty(eventt.Id))
            {
                eventt.Id = Guid.NewGuid().ToString();
            }
            result.Id = eventt.Id;
            result.Name = eventt.Name;
            result.CreateDate = eventt.CreateDate;
            result.StartTime = eventt.StartTime;
            result.EndTime = eventt.EndTime;

            return result;
        }
    }
}
