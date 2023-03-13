using Library.Application.DTO;
using Library.Infrastructure.Services.Tbbook;
using Library.Infrastructure.Services.Tbrent;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentController : ControllerBase
    {
        private readonly ITbrentServices _ITbrentServices;
        public RentController(ITbrentServices ITbrentServices)
        {
            _ITbrentServices = ITbrentServices;
        }
        [HttpGet]
        public Task<dynamic> Getall()
        {
            return _ITbrentServices.GetRents();
        }

        [HttpPost]
        public Task<dynamic> PostRents([FromBody] TBRentDTO value)
        {

          
            return _ITbrentServices.BookRent(value);
        }
        [HttpPut("{id}")]
        public Task<dynamic> PutRents(int id )
        {

             return _ITbrentServices.ReRent(id);
        }

    }
}
