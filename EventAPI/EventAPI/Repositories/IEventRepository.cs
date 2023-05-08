using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventAPI.Models;


namespace EventAPI.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> Get();
        Task<Event> Get(int id);
        Task<Event>Create(Event event);

        Task Update(int id);
        
        Task Delete(int id);


    }
}
