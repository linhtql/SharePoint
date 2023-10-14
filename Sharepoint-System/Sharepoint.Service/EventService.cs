using Sharepoint.Dao;
using Sharepoint.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sharepoint.Service
{
    public class EventService : IEventService
    {
        private readonly EventDAO eventDAO;

        public EventService(EventDAO eventDAO)
        {
            this.eventDAO = eventDAO;
        }

        public async Task<bool> Add(List<Event> events)
        {
            var result = await eventDAO.AddEvents(events);
            return result;
        }


        public async Task<bool> Delete(string Id)
        {
            var result = await eventDAO.Delete(Id);
            return result;
        }

        public async Task<List<Event>> GetAll()
        {
            var result = await eventDAO.FindAll();
            return result;
        }

        public async Task<Event> GetById(string id)
        {
            var result = await eventDAO.FindById(id);
            return result;
        }

        public async Task<bool> Update(Event eventt)
        {
            var result = await eventDAO.Update(eventt);
            return result;
        }
    }
}
