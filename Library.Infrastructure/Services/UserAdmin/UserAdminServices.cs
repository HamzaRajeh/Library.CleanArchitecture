using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Services.UserAdmin
{
    internal class UserAdminServices:IUserAdminServices
    {
        private readonly DblibraryContext _context;
        public UserAdminServices(DblibraryContext context)
        {
            _context = context;
        }
    }
}
