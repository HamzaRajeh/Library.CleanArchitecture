using Library.Application.DTO;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrastructure.Services.Tbbook
{
    public interface ITbbookServices
    {
        Task<dynamic> GetAll();
         dynamic  GetItem(int id);
        Task<dynamic> AddItem(dynamic value);
         dynamic  UpdateItem(int id,dynamic    value);
        Task<dynamic> DeleteItem(int id);
    }
}
