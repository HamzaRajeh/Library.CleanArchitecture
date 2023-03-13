using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Library.Infrastructure.Services.Tbrent
{
    public interface ITbrentServices
    {
        Task<dynamic> GetRents();
        Task<dynamic> BookRent(dynamic value);
        Task<dynamic> ReRent(int id);
 
    }
}
