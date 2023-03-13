using Library.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Services.Tbrent
{
    public class TbrentServices : ITbrentServices
    {
        private readonly DblibraryContext _context;

        public TbrentServices(DblibraryContext context)
        {
            _context = context;
        }
    public async  Task<dynamic>  BookRent(dynamic value)
        {
            var rent = new Domain.Models.Tbrent(){BookId=value.BookId,FullName=value.FullName ,PhoneNumber=value.PhoneNumber ,StatusId=1,PriodId=1, RentDate=DateTime.Now, ReRentDate = DateTime.Now.AddDays(value.ReRent), ReRent=value.ReRent } ;
            _context.Add(rent);
            _context.SaveChanges();
            return await  GetRents();
        }

        public async Task<dynamic>  GetRents()
        {
            return await _context.Tbrents.ToArrayAsync();
        }

        public async Task<dynamic> ReRent(int id)
        {
            var rent = _context.Tbrents.Find(id);
            if (rent != null)
            {
                rent.ReciveDate = DateTime.Now;
                rent.StatusId = 3;
                _context.SaveChanges();
            }
           
            return await _context.Tbrents.ToArrayAsync();
        }
    }
}
