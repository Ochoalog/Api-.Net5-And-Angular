using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Events.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Events.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        public IEnumerable<Event> _event = new Event[] {
            new Event()
                {
                    EventId = 1,
                    Theme = "Angular 11 e .NET 5",
                    Local = "Porto Alegre",
                    Batch = "1° Lote",
                    QuantityPeoples = 250,
                    EventDate = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                    ImageUrl = "foto.png"
                },
            new Event()
                {
                    EventId = 2,
                    Theme = "Angular 11 e .NET 5",
                    Local = "Porto Alegre",
                    Batch = "1° Lote",
                    QuantityPeoples = 250,
                    EventDate = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                    ImageUrl = "foto1.png"
                }
        };

        public EventController()
        {

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(e => e.EventId == id);
        }
    }
}
