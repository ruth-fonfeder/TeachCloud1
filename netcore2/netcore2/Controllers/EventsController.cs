using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace netcore2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private static List<Events> events = new List<Events> { new Events { Id = 1, Title = "defulte" } };
        public EventsController()
        {
        
        }
        // GET: api/<EventsController>
        [HttpGet]
        public IEnumerable<Events> Get()
        {
            return events;
        }

        // GET api/<EventsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<EventsController>
        [HttpPost]
        public void Post([FromBody] Events newevent)
        {
            events.Add(new Events { Id = 2, Title = newevent.Title });
        }

        // PUT api/<EventsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Events update)
        {
            foreach (var item in events)
            {
                if (item.Id == id)
                {
                    item.Title = update.Title;
                }
            }
            
        }


        // DELETE api/<EventsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach(var item in events)
            {
                if(item.Id == id)
                   events.Remove(item);
            }
        }
    }
}
