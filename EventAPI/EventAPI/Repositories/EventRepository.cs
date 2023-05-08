using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventAPI.Models


namespace EventAPI.Repositories
{
    public class EventRepository:IEventRepository
    {
        private readonly EventContext_context;
       public EventRepository(EventContext context)
        {
            _context = context;
        }
        public async Task<Event>Create(Event event)
            {
            _context.Events.Add(event);
            await _context.SaveChangesAsync();
            return event;
        }
        public async Task Delete(int id)
        {
            var eventToDelete = await_context.Events.FindAsync(id);
            _context.Events.Remove(eventToDelete);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<Event>>Get()
        {
            return await _context.Events.ToListAsync();
        }
        public async Task<Event>Get(int id)
        {
            return await _context.Events.FindAsync(id);
        }
        public async Task Update(Event event)
            {
            _context.Entry(event).State = EntityState.Modified;
            await _context.SaveChanges();
        }
    }
}
