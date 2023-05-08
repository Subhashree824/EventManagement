using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using EventAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventAPI.Repositories;

namespace EventAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;
        public EventsController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        [HttpGet]
        public Task<IEnumerable<Event>> GetEvents()
        {
            return await _eventRepository.Get();
        }
        [HttpGet("{id}")]
        public Task<ActionResult<Event>> GetEvents(int id)
        {
            return await _eventRepository.Get(id);
        }
        [HttpPost]
        public async Task<ActionResult<Event>> PostEvents([FromBody] Event event)
            {
            var newEvent = await _eventRepository.Create(event);
            return CreatedAtAction(nameof(GetEvents), new {id = newEvent.id }, newEvent);
        }
        [HttpPut]
        public async Task<ActionResult>Putevents(int id,[FromBody] Event event)
        {
            if(id != Event.Id)
            {
                return BadRequest();
            }
    await _eventRepository.Update(event);
    return NoContentResult();
        }
        [HttpDelete("{id}")]
{
    public async Task<ActionResult>Delete(int id)
    {
        var eventToDelete = await _eventRepository.Get(id);
        if (eventToDelete == null)
            return NotFound();
        await _evetRepository.Delete(eventToDelete.Id);
        return NoContext()
    }
}

    }
}
