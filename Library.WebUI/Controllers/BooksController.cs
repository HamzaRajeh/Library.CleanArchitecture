using Library.Application.DTO;
using Library.Domain.Models;
using Library.Infrastructure.Services.Tbbook;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET: api/<ValuesController>
        private readonly  ITbbookServices _TbbookServices;
        public BooksController(ITbbookServices ITbbookServices)
        {
            _TbbookServices= ITbbookServices;   
        }
        [HttpGet]
        public   Task<dynamic> Get()
        {
            return _TbbookServices.GetAll();
        }
        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
         public   Tbbook Get(int id)
        {
             return _TbbookServices.GetItem(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public Task<dynamic> Post([FromBody] TbbookDTO value)
        {
         return   _TbbookServices.AddItem(value); 
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public dynamic Put(int id, [FromBody] TbbookDTO value)
        {
            return _TbbookServices.UpdateItem(id,value);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public dynamic Delete(int id)
        {
            return _TbbookServices.DeleteItem(id);

        }
    }
}
