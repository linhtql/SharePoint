using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Service
{
    public interface IEventService
    {
        Task<Boolean> Add(List<Event> events);
        Task<Boolean> Delete(String Id);
        Task<Boolean> Update(Event eventt);
        Task<Event> GetById(String id);
        Task<List<Event>> GetAll();
    }
}
